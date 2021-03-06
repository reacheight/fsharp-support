﻿using FSharp.Compiler.SourceCodeServices;
using JetBrains.Annotations;
using JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.DeclaredElement.CompilerGenerated;
using JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.Tree;
using JetBrains.ReSharper.Plugins.FSharp.Psi.Tree;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.DeclaredElement
{
  /// Union case or exception field compiled to a property.
  internal class FSharpUnionCaseField<T> : FSharpFieldProperty<T>
    where T : IFSharpDeclaration, IModifiersOwnerDeclaration, ICaseFieldDeclaration, ITypeMemberDeclaration
  {
    internal FSharpUnionCaseField([NotNull] ITypeMemberDeclaration declaration) : base(declaration)
    {
    }

    public override bool IsVisibleFromFSharp => false;
    public override bool CanNavigateTo => true;
  }

  /// Record field compiled to a property.
  internal class FSharpRecordField : FSharpFieldProperty<RecordFieldDeclaration>
  {
    private readonly bool myIsMutable;

    internal FSharpRecordField([NotNull] ITypeMemberDeclaration declaration, [NotNull] FSharpField field) :
      base(declaration) =>
      myIsMutable = field.IsMutable;

    public override bool IsWritable =>
      myIsMutable || GetContainingType().IsCliMutableRecord();
  }

  internal abstract class FSharpFieldProperty<T> : FSharpCompiledPropertyBase<T>, IFSharpFieldProperty
    where T : IFSharpDeclaration, IModifiersOwnerDeclaration, ITypeMemberDeclaration
  {
    internal FSharpFieldProperty([NotNull] ITypeMemberDeclaration declaration) : base(declaration)
    {
    }

    // todo: named case fields have FSharpParameter symbols in resolve cache 
    [CanBeNull] public FSharpField Field => Symbol as FSharpField;
    [CanBeNull] protected virtual FSharpType FieldType => Field?.FieldType;

    public override IType ReturnType => GetType(FieldType);

    public override AccessRights GetAccessRights() =>
      GetContainingType().GetRepresentationAccessRights();

    public IParameter GetParameter() =>
      new FSharpGeneratedParameter(GetContainingType().GetGeneratedConstructor(), this);
  }
}

using System.Linq;
using JetBrains.Application.Settings;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Plugins.FSharp.Psi;
using JetBrains.ReSharper.Plugins.FSharp.Psi.Impl.Tree;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Impl.CodeStyle;

namespace JetBrains.ReSharper.Plugins.FSharp.Services.Formatter
{
  [Language(typeof(FSharpLanguage))]
  public class FSharpFormatterInfoProvider :
    FormatterInfoProviderWithFluentApi<CodeFormattingContext, FSharpFormatSettingsKey>
  {
    public FSharpFormatterInfoProvider(ISettingsSchema settingsSchema) : base(settingsSchema)
    {
      var bindingAndModuleDeclIndentingRulesParameters = new[]
      {
        ("NestedModuleDeclaration", ElementType.NESTED_MODULE_DECLARATION, NestedModuleDeclaration.MODULE_MEMBER),
        ("TopBinding", ElementType.TOP_BINDING, TopBinding.CHAMELEON_EXPR),
        ("LocalBinding", ElementType.LOCAL_BINDING, LocalBinding.EXPR),
      };

      var synExprIndentingRulesParameters = new[]
      {
        ("ForExpr", ElementType.FOR_EXPR, ForExpr.DO_EXPR),
        ("ForEachExpr", ElementType.FOR_EACH_EXPR, ForEachExpr.DO_EXPR),
        ("WhileExpr", ElementType.WHILE_EXPR, WhileExpr.DO_EXPR),
        ("DoExpr", ElementType.DO_EXPR, DoExpr.EXPR),
        ("AssertExpr", ElementType.ASSERT_EXPR, AssertExpr.EXPR),
        ("LazyExpr", ElementType.LAZY_EXPR, LazyExpr.EXPR),
        ("ComputationExpr", ElementType.COMPUTATION_EXPR, ComputationExpr.EXPR),
        ("SetExpr", ElementType.SET_EXPR, SetExpr.RIGHT_EXPR),
      };

      var typeDeclarationIndentingRulesParameters = new[]
      {
        ("EnumDeclaration", ElementType.ENUM_DECLARATION, EnumDeclaration.ENUM_MEMBER),
        ("UnionDeclaration", ElementType.UNION_DECLARATION, UnionDeclaration.UNION_REPR),
        ("TypeAbbreviationDeclaration", ElementType.TYPE_ABBREVIATION_DECLARATION, TypeAbbreviationDeclaration.TYPE_OR_UNION_CASE),
        ("ModuleAbbreviation", ElementType.MODULE_ABBREVIATION, ModuleAbbreviation.TYPE_REFERENCE),
        ("TypeExtenstionDeclaration", ElementType.TYPE_EXTENSION_DECLARATION, TypeExtensionDeclaration.TYPE_MEMBER),
        ("DelegateDeclaration", ElementType.DELEGATE_DECLARATION, DelegateDeclaration.DELEGATE_REPR),
        ("ClassDeclaration", ElementType.CLASS_DECLARATION, ClassDeclaration.TYPE_MEMBER),
        ("InterfaceDeclaration", ElementType.INTERFACE_DECLARATION, InterfaceDeclaration.TYPE_MEMBER),
        ("ObjectTypeDeclaration", ElementType.OBJECT_TYPE_DECLARATION, ObjectTypeDeclaration.TYPE_MEMBER),
        ("NestedTypeUnionCaseDeclaration", ElementType.NESTED_TYPE_UNION_CASE_DECLARATION, NestedTypeUnionCaseDeclaration.UNION_FIELD),
      };

      var typeMemberDeclarationIndentingRulesParameters = new[]
      {
        ("InterfaceImplementation", ElementType.INTERFACE_IMPLEMENTATION, InterfaceImplementation.MEMBER_DECL),
        ("MemberBody", ElementType.MEMBER_DECLARATION, MemberDeclaration.MEMBER_BODY),
        ("AccessorDeclaration", ElementType.ACCESSOR_DECLARATION, AccessorDeclaration.CHAMELEON_EXPR),
        ("AutoPropertyDeclaration", ElementType.AUTO_PROPERTY, AutoProperty.CHAMELEON_EXPR),
        ("ConstructorDeclaration", ElementType.MEMBER_CONSTRUCTOR_DECLARATION, MemberConstructorDeclaration.CTOR_BODY),
      };

      lock (this)
      {
        bindingAndModuleDeclIndentingRulesParameters
          .Union(synExprIndentingRulesParameters)
          .Union(typeDeclarationIndentingRulesParameters)
          .Union(typeMemberDeclarationIndentingRulesParameters)
          .ToList()
          .ForEach(DescribeSimpleIndentingRule);

        Describe<IndentingRule>()
          .Name("MemberWithAccessorsDeclarationIndent")
          .Where(
            Parent().HasType(ElementType.MEMBER_DECLARATION),
            Node().HasType(ElementType.ACCESSOR_DECLARATION))
          .Return(IndentType.External)
          .Build();
      }
    }

    public override ProjectFileType MainProjectFileType => FSharpProjectFileType.Instance;

    private void DescribeSimpleIndentingRule((string name, CompositeNodeType parentType, short childRole) parameters)
    {
      Describe<IndentingRule>()
        .Name(parameters.name + "Indent")
        .Where(
          Parent().HasType(parameters.parentType),
          Node().HasRole(parameters.childRole))
        .Return(IndentType.External)
        .Build();
    }
  }
}

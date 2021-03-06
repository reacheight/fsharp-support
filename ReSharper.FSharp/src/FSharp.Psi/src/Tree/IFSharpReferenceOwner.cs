using JetBrains.Annotations;
using JetBrains.ReSharper.Plugins.FSharp.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Tree
{
  public interface IFSharpReferenceOwner : IFSharpTreeNode
  {
    FSharpSymbolReference Reference { get; }

    [CanBeNull] ITokenNode IdentifierToken { get; }

    [NotNull]
    IFSharpReferenceOwner SetName([NotNull] string name);
  }
}

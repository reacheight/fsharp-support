namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Features.Daemon.Analyzers

open FSharp.Compiler.SourceCodeServices
open JetBrains.ReSharper.Feature.Services.Daemon
open JetBrains.ReSharper.Plugins.FSharp.Psi.Features.Daemon.Highlightings
open JetBrains.ReSharper.Plugins.FSharp.Psi.Tree
open JetBrains.ReSharper.Plugins.FSharp.Psi.Util
open JetBrains.ReSharper.Psi

[<ElementProblemAnalyzer(typeof<INewExpr>,
                         HighlightingTypes = [| typeof<RedundantNewWarning> |])>]
type RedundantNewAnalyzer() =
    inherit ElementProblemAnalyzer<INewExpr>()

    override x.Run(newExpr, _, consumer) =
        let typeName = newExpr.TypeName
        let resolveResult = typeName.Reference.Resolve()
        match resolveResult.DeclaredElement.As<ITypeElement>() with
        | null -> ()
        | typeElement ->

        let predefinedType = newExpr.GetPredefinedType()
        if typeElement.IsDescendantOf(predefinedType.IDisposable.GetTypeElement()) then () else
        if isNull newExpr.NewKeyword then () else

        match newExpr.CheckerService.ResolveNameAtLocation(newExpr, typeName.Names, "RedundantNewAnalyzer") with
        | None -> ()
        | Some symbolUse ->

        match symbolUse.Symbol with
        | :? FSharpEntity -> consumer.AddHighlighting(RedundantNewWarning(newExpr))
        | _ -> ()

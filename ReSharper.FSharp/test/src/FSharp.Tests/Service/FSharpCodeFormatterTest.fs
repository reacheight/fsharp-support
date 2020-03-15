namespace JetBrains.ReSharper.Plugins.FSharp.Tests.Features

open JetBrains.ReSharper.FeaturesTestFramework.Formatter
open JetBrains.ReSharper.Plugins.FSharp.Psi
open JetBrains.ReSharper.Plugins.FSharp.Tests
open NUnit.Framework

[<FSharpTest>]
type FSharpCodeFormatterTest() =
    inherit CodeFormatterWithExplicitSettingsTestBase<FSharpLanguage>()

    override x.RelativeTestDataPath = "features/service/codeFormatter"

    override x.DoNamedTest() =
        use cookie = FSharpRegistryUtil.AllowFormatterCookie.Create()
        base.DoNamedTest()

    [<Test>] member x.``Top binding indent 01 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``Top binding indent 02 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Top binding indent 03 - Big indent``() = x.DoNamedTest()

    [<Test>] member x.``Local binding indent 01 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``Local binding indent 02 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Local binding indent 03 - Big indent``() = x.DoNamedTest()

    [<Test>] member x.``Nested module indent 01 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``Nested module indent 02 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Nested module indent 03 - Big indent``() = x.DoNamedTest()

    [<Test>] member x.``For expr indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``For expr indent 02 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``For expr indent 03 - Big indent``() = x.DoNamedTest()
    
    [<Test>] member x.``ForEach expr indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``ForEach expr indent 02 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``ForEach expr indent 03 - Big indent``() = x.DoNamedTest()
    
    [<Test>] member x.``While expr indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``While expr indent 02 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``While expr indent 03 - Big indent``() = x.DoNamedTest()
    
    [<Test>] member x.``Do expr indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Do expr indent 02 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``Do expr indent 03 - Big indent``() = x.DoNamedTest()
    
    [<Test>] member x.``Assert expr indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Assert expr indent 02 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``Assert expr indent 03 - Big indent``() = x.DoNamedTest()
    
    [<Test>] member x.``Lazy expr indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Lazy expr indent 02 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``Lazy expr indent 03 - Big indent``() = x.DoNamedTest()
    
    [<Test>] member x.``Comp expr indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Comp expr indent 02 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``Comp expr indent 03 - Big indent``() = x.DoNamedTest()
    
    [<Test>] member x.``Set expr indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Set expr indent 02 - No indent``() = x.DoNamedTest()
    [<Test>] member x.``Set expr indent 03 - Big indent``() = x.DoNamedTest()

    [<Test>] member x.``Enum declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Union declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Union declaration indent 02 - Type member - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Union declaration indent 03 - Nested - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Type abbreviation declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Module abbreviation declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Type extension declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Delegate declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Class declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Interface declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Object type declaration indent 01 - Correct indent``() = x.DoNamedTest()

    [<Test>] member x.``Interface implementation indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Member body indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Property declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``AutoProperty declaration indent 01 - Correct indent``() = x.DoNamedTest()
    [<Test>] member x.``Member constructor declaration indent 01 - Correct indent``() = x.DoNamedTest()

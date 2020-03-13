namespace JetBrains.ReSharper.Plugins.FSharp.Tests.Features

open JetBrains.ReSharper.Plugins.FSharp.Psi
open JetBrains.ReSharper.Plugins.FSharp.Tests
open JetBrains.ReSharper.TestFramework
open NUnit.Framework

[<FSharpTest>]
type FSharpParserTest() =
    inherit ParserTestBase<FSharpLanguage>()

    override x.RelativeTestDataPath = "parsing"

    [<Test>] member x.``Module - Anon 01``() = x.DoNamedTest()
    [<Test>] member x.``Module - Anon 02``() = x.DoNamedTest()
    [<Test>] member x.``Module - Top level 01``() = x.DoNamedTest()

    [<Test>] member x.``Namespace 01``() = x.DoNamedTest()
    [<Test>] member x.``Namespace 02 - Qualifier``() = x.DoNamedTest()
    [<Test>] member x.``Namespace 03 - Multiple``() = x.DoNamedTest()
    [<Test>] member x.``Namespace 04 - Multiple qualifiers``() = x.DoNamedTest()
    [<Test>] member x.``Namespace 05 - Global``() = x.DoNamedTest()
    [<Test>] member x.``Namespace 06 - Global, type``() = x.DoNamedTest()
    [<Test>] member x.``Namespace 07 - Global, Multiple``() = x.DoNamedTest()

    [<Test>] member x.``Type decl - Exception 01``() = x.DoNamedTest()
    [<Test>] member x.``Type decl - Exception 02``() = x.DoNamedTest()

    [<Test>] member x.``Type decl - Extension 01``() = x.DoNamedTest()

    [<Test>] member x.``Type decl - Delegate 01``() = x.DoNamedTest()
    [<Test>] member x.``Type decl - Delegate 02``() = x.DoNamedTest()
    [<Test>] member x.``Type decl - Delegate 03 - Ctor``() = x.DoNamedTest()

    [<Test>] member x.``Type decl - Attributes 01``() = x.DoNamedTest()
    [<Test>] member x.``Type decl - Attributes 02``() = x.DoNamedTest()
    
    [<Test>] member x.``Type decl - Enum 01 - With first bar``() = x.DoNamedTest()
    [<Test>] member x.``Type decl - Enum 02 - Without first bar``() = x.DoNamedTest()

    [<Test>] member x.``Let 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Let 02 - Typed``() = x.DoNamedTest()
    [<Test>] member x.``Let 03 - Typed, var type``() = x.DoNamedTest()
    [<Test>] member x.``Let 04 - Typed, var type, space``() = x.DoNamedTest()
    [<Test>] member x.``Let 05 - Typed, space``() = x.DoNamedTest()
    [<Test>] member x.``Let 06 - Unit param``() = x.DoNamedTest()

    [<Test>] member x.``Let - Rec 01``() = x.DoNamedTest()
    [<Test>] member x.``Let - Rec 02 - And``() = x.DoNamedTest()

    [<Test>] member x.``Let - As 01``() = x.DoNamedTest()
    [<Test>] member x.``Let - As 02``() = x.DoNamedTest()

    [<Test>] member x.``Let - Local 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Let - Local 02 - Typed``() = x.DoNamedTest()
    [<Test>] member x.``Let - Local 03 - Typed expr``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Paren 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Quote 01 - Typed``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Quote 02 - Untyped``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Tuple 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Tuple 02``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Const - Numbers 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Const - Unit 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Const - Unit 02 - Parens``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Typed 01 - Simple``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Anon record 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Record 01 - Single Line``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Record 02 - Multiline``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Record 03 - Multiline, semicolons``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Record 04 - Empty``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Record 05 - Single Line with end semicolon``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Record 06 - With qualifier``() = x.DoNamedTest()

    [<Test>] member x.``Expr - While 01 - Simple``() = x.DoNamedTest()

    [<Test>] member x.``Expr - For 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - ForEach - Range 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - ForEach - Range 02 - Step``() = x.DoNamedTest()
    [<Test>] member x.``Expr - ForEach 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - CompExpr - Range 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - CompExpr - Range 02 - Step``() = x.DoNamedTest()
    [<Test>] member x.``Expr - CompExpr 01 - Return``() = x.DoNamedTest()

    [<Test>] member x.``Expr - CompExpr - AndBang 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Lambda 01 - Single id``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 02 - Single wild``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 03 - Tuple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 04 - Long id pattern``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 05 - Multiple wilds``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 06 - Wild and named pats 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 07 - Wild and named pats 02``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 08 - Match expr``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 09 - Long id with or pat``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 10 - Multiple tuples``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 11 - Two wilds``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 12 - Paren``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 13 - Two parens``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 14 - Nested parens``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 15 - Unit``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 16 - Unit in parens``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 17 - As``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 18 - Typed``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 19 - Typed - Multiple params``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 20 - Two units``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 21 - Nested types``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 22 - Attribute``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lambda 23 - Attribute, Typed``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Match 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Match 02 - Simple pat``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Match 03 - When Expr``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Match 04 - Multiple When clauses``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Do 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Do 02 - Let``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Do 03 - Let in do``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Assert 01 - Simple``() = x.DoNamedTest()

    [<Test>] member x.``Expr - LetOrUse 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - TryWith 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - TryWith 02 - Parameters``() = x.DoNamedTest()

    [<Test>] member x.``Expr - TryFinally 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Lazy 01 - Simple``() = x.DoNamedTest()

    [<Test>] member x.``Expr - IfThenElse - Elif 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - IfThenElse - Elif 02``() = x.DoNamedTest()
    [<Test>] member x.``Expr - IfThenElse 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - IfThenElse 02 - Nested 01 - Single line``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Ident 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - LongIdent 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - LongIdentSet 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Cast - Downcast 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Cast - Upcast 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Null``() = x.DoNamedTest()
    [<Test>] member x.``Expr - AddressOf 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Fixed 01 - Simple``() = x.DoNamedTest()

    [<Test>] member x.``Expr - DotGet 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - DotSet 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - App - Logic 01 - And``() = x.DoNamedTest()
    [<Test>] member x.``Expr - App - Logic 02 - Or``() = x.DoNamedTest()

    [<Test>] member x.``Expr - App - Precedence 01 - High``() = x.DoNamedTest()
    [<Test>] member x.``Expr - App - Precedence 02 - Low``() = x.DoNamedTest()
    [<Test>] member x.``Expr - App - Precedence 03``() = x.DoNamedTest()
    [<Test>] member x.``Expr - App - Precedence 04 - High - List``() = x.DoNamedTest()
    [<Test>] member x.``Expr - App - Precedence 05 - High - Multiple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - App - Precedence 06 - High - Multiple``() = x.DoNamedTest()

    [<Test>] member x.``Expr - App - Prefix op 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - App - List 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - App - List 02``() = x.DoNamedTest()

    [<Test>] member x.``Expr - TypeApp 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Expr - TypeApp 02 - Lid``() = x.DoNamedTest()
    [<Test>] member x.``Expr - TypeApp 03 - DotGet``() = x.DoNamedTest()

    [<Test>] member x.``Expr - DotIndexerGet 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - DotIndexerGet 02``() = x.DoNamedTest()
    [<Test>] member x.``Expr - DotIndexerGet 03``() = x.DoNamedTest()
    [<Test>] member x.``Expr - DotIndexerGet 04 - Multiple args``() = x.DoNamedTest()

    [<Test>] member x.``Expr - DotIndexerSet 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - DotIndexerSet 02 - Record``() = x.DoNamedTest()
    [<Test>] member x.``Expr - DotIndexerSet 03 - Two args``() = x.DoNamedTest()
    [<Test>] member x.``Expr - DotIndexerSet 04 - Three args``() = x.DoNamedTest()
    [<Test>] member x.``Expr - DotIndexerSet 05 - Tuple arg``() = x.DoNamedTest()

    [<Test>] member x.``Expr - DotNamedIndexerSet 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - NamedIndexerSet 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - Sequential 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Sequential 02``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Sequential 03``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Sequential 04 - Let``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Sequential 05 - Let``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Sequential 06 - Let``() = x.DoNamedTest()

    [<Test>] member x.``Expr - New 01 - Lid``() = x.DoNamedTest()
    [<Test>] member x.``Expr - New 02 - Generics``() = x.DoNamedTest()

    [<Test>] member x.``Expr - ObjExpr 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - ObjExpr 02 - Interface``() = x.DoNamedTest()

    [<Test>] member x.``Expr - ImplicitZero 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - LetOrUseBang 01``() = x.DoNamedTest()

    [<Test>] member x.``Binding - Return type 01``() = x.DoNamedTest()
    [<Test>] member x.``Binding - Return type 02 - Attrs``() = x.DoNamedTest()
    [<Test>] member x.``Binding - Return type 03 - Attrs, wild type``() = x.DoNamedTest()

    [<Test>] member x.``Attribute 01``() = x.DoNamedTest()
    [<Test>] member x.``Attribute 02 - Simple arg``() = x.DoNamedTest()
    [<Test>] member x.``Attribute 03 - Simple arg - No parens``() = x.DoNamedTest()
    [<Test>] member x.``Attribute 04 - Qualifiers``() = x.DoNamedTest()
    [<Test>] member x.``Attribute 05 - Qualifiers and arg``() = x.DoNamedTest()
    [<Test>] member x.``Attribute 06 - Unit arg``() = x.DoNamedTest()

    [<Test>] member x.``Attributes - Let bindings 01``() = x.DoNamedTest()
    [<Test>] member x.``Attributes - Let bindings 02``() = x.DoNamedTest()
    [<Test>] member x.``Attributes - Let bindings 03 - Modifiers``() = x.DoNamedTest()
    [<Test>] member x.``Attributes - Let bindings 04 - Multiple bindings``() = x.DoNamedTest()
    [<Test>] member x.``Attributes - Type let bindings 01``() = x.DoNamedTest()
    [<Test>] member x.``Attributes - Type let bindings 02``() = x.DoNamedTest()
    [<Test>] member x.``Attributes - Type let bindings 03 - Modifiers``() = x.DoNamedTest()
    [<Test>] member x.``Attributes - Type let bindings 04 - Multiple bindings``() = x.DoNamedTest()

    [<Test>] member x.``Module abbreviation 01``() = x.DoNamedTest()
    [<Test>] member x.``Module abbreviation 02``() = x.DoNamedTest()

    [<Test>] member x.``Types - Simple 01``() = x.DoNamedTest()
    [<Test>] member x.``Types - Simple 02 - Long ident``() = x.DoNamedTest()
    [<Test>] member x.``Types - Simple 03 - Type app``() = x.DoNamedTest()

    // todo: fix parens are not in type nodes in FCS
    [<Test>] member x.``Types - Simple 04 - Parens``() = x.DoNamedTest()
    [<Test>] member x.``Types - Simple 05 - Nested parens``() = x.DoNamedTest()

    [<Test>] member x.``Types - Type app 01``() = x.DoNamedTest()
    [<Test>] member x.``Types - Type app 02 - ML-style``() = x.DoNamedTest()
    [<Test>] member x.``Types - Type app 03 - tuple``() = x.DoNamedTest()
    [<Test>] member x.``Types - Type app 04 - ML-style tuple``() = x.DoNamedTest()

    [<Test>] member x.``Types - Tuple 01``() = x.DoNamedTest()
    [<Test>] member x.``Types - Tuple 02 - Nested``() = x.DoNamedTest()
    [<Test>] member x.``Types - Tuple 03 - Nested 2``() = x.DoNamedTest()
    [<Test>] member x.``Types - Tuple 04 - Struct``() = x.DoNamedTest()
    [<Test>] member x.``Types - Tuple 05 - More items``() = x.DoNamedTest()
    [<Test>] member x.``Types - Tuple 06 - Parens``() = x.DoNamedTest()

    [<Test>] member x.``Types - Fun 01``() = x.DoNamedTest()
    [<Test>] member x.``Types - Fun 02``() = x.DoNamedTest()

    [<Test>] member x.``Types - Anon record 01``() = x.DoNamedTest()
    [<Test>] member x.``Types - Array 01``() = x.DoNamedTest()

    [<Test>] member x.``Types - Measure 01``() = x.DoNamedTest()
    [<Test>] member x.``Types - Measure 02 - Negate``() = x.DoNamedTest()

    [<Test>] member x.``Type member - Ctor - Primary 01``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Ctor - Primary 02 - Modifier``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Ctor - Primary 03 - Attributes``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Ctor - Secondary 01``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Ctor - Secondary 02 - Modifier``() = x.DoNamedTest()

    [<Test>] member x.``Type member - Inherit - Type 01 - Simple``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Inherit - Type 02 - Qualified``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Inherit - Type 03 - Arguments``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Inherit - Type 04 - Type parameters 01``() = x.DoNamedTest()

    [<Test>] member x.``Type member - Let bindings 01``() = x.DoNamedTest()

    [<Test>] member x.``Type member - Member 01 - Wild self id``() = x.DoNamedTest()

    [<Test>] member x.``Module member - Open 01``() = x.DoNamedTest()
    [<Test>] member x.``Module member - Open 02 - Qualifier``() = x.DoNamedTest()

    [<Test>] member x.``Pattern - Record 01``() = x.DoNamedTest()
    [<Test>] member x.``Pattern - Record 02 - Qualified name``() = x.DoNamedTest()

    [<Test>] member x.``Record field 01 - Attribute``() = x.DoNamedTest()


[<FSharpSignatureTest>]
type FSharpSignatureParserTest() =
    inherit ParserTestBase<FSharpLanguage>()

    override x.RelativeTestDataPath = "parsing/signatures"

    [<Test>] member x.``Val - Value 01``() = x.DoNamedTest()

    [<Test>] member x.``Val - Function 01``() = x.DoNamedTest()
    [<Test>] member x.``Val - Function 02 - Named param``() = x.DoNamedTest()
    [<Test>] member x.``Val - Function 03 - Multiple named params``() = x.DoNamedTest()
    [<Test>] member x.``Val - Function 04 - Named tuple param``() = x.DoNamedTest()

    [<Test>] member x.``Val - Active pattern 01``() = x.DoNamedTest()

    [<Test>] member x.``Type repr - Record 01``() = x.DoNamedTest()
    [<Test; Explicit("Needs FCS update")>] member x.``Type repr - Record 02 - Mutable field``() = x.DoNamedTest()
    [<Test>] member x.``Type repr - Record 03 - Field attributes``() = x.DoNamedTest()

    [<Test>] member x.``Type member - Inherit 01``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Inherit 02 - Qualifiers``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Inherit 03 - Generic``() = x.DoNamedTest()

    [<Test>] member x.``Type member - Interface 01``() = x.DoNamedTest()
    [<Test>] member x.``Type member - Constructor 01``() = x.DoNamedTest()

    [<Test>] member x.``Hash directive 01``() = x.DoNamedTest()


[<FSharpTest>]
type FSharpErrorsParserTest() =
    inherit ParserTestBase<FSharpLanguage>()

    override x.RelativeTestDataPath = "parsing/errors"

    [<Test>] member x.``Expr - Unfinished let 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Unfinished let 02 - In``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Unfinished let 03 - Inline in``() = x.DoNamedTest()
    [<Test>] member x.``Expr - Unfinished let 04 - In, before other``() = x.DoNamedTest()

    [<Test>] member x.``Line separators 01``() = x.DoNamedTest()

    [<Test>] member x.``Expr - CompExpr - Range 01``() = x.DoNamedTest()
    [<Test>] member x.``Expr - CompExpr - Range 02 - Step``() = x.DoNamedTest()
    [<Test>] member x.``Expr - CompExpr - Range 03``() = x.DoNamedTest()

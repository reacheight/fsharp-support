module Module

typeof<Foo> |> ignore
typeof<Class> |> ignore

let (f: Foo) = enum 0
System.Nullable<Foo>() |> ignore
System.Nullable<Class>() |> ignore

type T1() =
    inherit Class()

type T2() =
    inherit Foo()
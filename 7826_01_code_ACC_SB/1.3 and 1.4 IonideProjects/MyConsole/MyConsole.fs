module MyConsole

[<EntryPoint>]
let main argv =
    printfn "Hello from MyConsole!"
    MyLib.getHello() |> printfn "%s" 
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code

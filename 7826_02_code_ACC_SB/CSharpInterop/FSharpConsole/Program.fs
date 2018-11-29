open System
open CSharpLibrary

[<EntryPoint>]
let main argv = 
    
    let x = new ExportToFSharp()

    //x.SomeNumber <- 42.0f

    //let notes = x.NotesInTheScale()

    //notes
    //|> Seq.iter (printfn "%s")

    //let printIt n =
    //    sprintf "You passed in number %i" n
    
    //let s = x.UseDelegate( System.Func<int,string>(printIt), 3 )

    //Console.WriteLine(s)
    
    let useInterface (i : IExportToFSharp) =
        Console.WriteLine(i.SayHello())

    let quickInterface = 
        {
            new IExportToFSharp
                with 
                    member this.SayHello() = "Hello from QuickInterface"
                    member this.SayGoodbye() = "Goodbye from QuickInterface"

        }

    useInterface quickInterface

    Console.ReadKey();

    0 // return an integer exit code

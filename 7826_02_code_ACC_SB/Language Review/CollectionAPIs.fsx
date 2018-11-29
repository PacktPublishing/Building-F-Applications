namespace LanguageReview

module CollectionAPIs =

    let testList = List.init 20 (fun n -> n * 5)

    List.length testList

    testList |> List.isEmpty
    testList |> List.min
    testList |> List.filter (fun n -> n < 0)

    testList 
    |> List.filter (fun n -> n % 3 = 0)
    |> List.map (fun n -> n * n)
    |> List.rev

    testList
    |> List.iter (printfn "%i")

    testList 
        |> List.fold (fun acc n -> if n % 3 = 0 then acc else n :: acc) []
    
    testList
        |> List.reduce (fun acc n -> if n%3 = 0 then acc else acc + n)    

    testList
        |> Array.ofList


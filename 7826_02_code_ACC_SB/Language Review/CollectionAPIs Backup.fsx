namespace LanguageReview

module CollectionAPIs =

    let testList = List.init 20 (fun n -> n * 5) 
    
    testList |> List.sum

    testList |> List.tryFind (fun n -> n = 54)

    testList 
        |> List.filter (fun n -> n % 3 = 0)
        |> List.map (fun n -> n * n)
        |> List.rev

    testList 
        |> List.fold (fun acc n -> if n % 3 = 0 then acc else n :: acc) []
    
    testList
        |> List.reduce (fun acc n -> if n%3 = 0 then acc else acc + n)
 



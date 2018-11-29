let newList = 
    testList 
    |> List.filter(fun i -> i % 2 = 0)  
    |> List.map (fun i -> i * i)
    |> List.sort

testList
    |> List.iter (fun n -> printfn "%i" n)

let foldedList = 
    testList
    |> List.fold (fun acc n -> if n % 3 = 0 then acc else n :: acc ) []
    |> List.rev

let reducedList =
    testList
    |> List.reduce (fun acc n -> if n % 3 = 0 then acc else n + acc)

let map2 = dict [(1,"one")]

let list2 = [ 1 ; 2 ; 2 ]

list1 < list2

let seq2 = seq [1 ; 2 ; 5 ]
let array2 = [| 0 ; 2 ; 3 |]

array1 = array2

seq1 = seq2

let set2 = set [ 1 ; 2 ; 3 ]

set1 = set2

let set3 = set2.Add 5

set3.IsSupersetOf set1

let bigList = [1I .. 2_000_000I]
let bigArray = [| 1I .. 2_000_000I |]

bigList |> List.contains 1_999_999I
bigArray |> Array.contains 1_999_999I

bigList |> List.countBy (fun i -> i.IsEven)
bigArray |> Array.countBy (fun i -> i.IsEven)

bigList |> List.rev |> List.where(fun i -> i.IsEven) |> List.length
bigArray |> Array.rev |> Array.where(fun i -> i.IsEven) |> Array.length

bigArray.[0]

    let list11 = 0 :: list1
    let list12 = list1 @ list11

    let rec printTheList l =
        match l with
        | []
            ->  ()
        | head :: tail
            ->  printfn "%i" head
                printTheList tail
    printTheList list1

        let seq4 = Seq.initInfinite (fun id -> id + 1)
    seq3 |> Seq.take 1
    seq3
    seq4 |> Seq.take 1
    seq4
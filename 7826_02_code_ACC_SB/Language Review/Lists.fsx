namespace LanguageReview

module Lists =

    let list1 = [ 1 ; 2 ; 3 ]
    let list2 = [ 1 .. 3 ]
    let list3 = [ for i in 1 .. 3 -> i ]
    let list4 = List.init 3 (fun id -> id + 1)
    let list5 : int list = []

    let list6 = 0 :: list1

    let rec printTheList l =
        match l with
        | []
            ->  ()
        | head :: tail
            ->  printfn "%i" head
                printTheList tail

    list6 |> printTheList
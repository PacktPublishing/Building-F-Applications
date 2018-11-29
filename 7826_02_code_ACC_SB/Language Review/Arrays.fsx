namespace LanguageReview

module Arrays =

    let array1 = [| 1 ; 2 ; 3 |]
    let array2 = [| 1 .. 3 |]
    let array3 = [| for i in 1 .. 3 -> i |]
    let array4 = Array.init 3 (fun id -> id + 1)
    let array5 = Array.create 3 0

    array1.[1] <- 5
    array1
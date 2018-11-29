namespace LanguageReview

module Tuples =

    let tuple1 = (5,10)
    let tuple2 = (4.4, "The quick brown fox jumped over the lazy dog.")

    let tupleFunc (x, y) =
        (x + y, x * y)

    tuple1 |> tupleFunc

    let x, y = tuple1

    let tuple3 = (5,10)
    tuple1 = tuple3

    tuple1 < (5, 11)

    let tuple4 = struct (1,1)


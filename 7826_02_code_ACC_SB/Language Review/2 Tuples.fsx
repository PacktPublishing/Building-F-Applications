namespace LanguageReview

module Tuples =

    let a = (5,10)

    let tupleFunc (x, y) =
        (x + y, x * y)

    a |> tupleFunc

    let x, y = a

    let b = (5,10)
    a = b

    a < (5, 11)

    let c = struct (1,1)


namespace LanguageReview

module ImmutableTypes =

    let a = (5,10)

    let tupleFunc (x, y) =
        (x + y, x * y)

    a |> tupleFunc

    let x, y = a

    let b = (5,10)
    a = b

    a < (5, 11)

    let c = struct (1,1)

   
    [<Struct>]
    type PersonRecord =
        {
            FirstName : string
            LastName : string
            Age : int
        }
    let richard =
        {
            FirstName = "Richard"
            LastName = "Broida"
            Age = 17
        }

    type TrafficSignals =
    | Red
    | Yellow
    | Green

    type Shape =
    | Circle of float
    | Rectangle of float * float
    | Square of float

    let safeDivide (x,y) =
        if y = 0.0
            then None
            else Some (x/y)
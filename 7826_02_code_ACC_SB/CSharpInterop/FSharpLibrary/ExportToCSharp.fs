  namespace FSharpLibrary
  
  module ExportToCSharp =

    let exportedFunction x y =
        x * y

    let exportedFunctionWithTuple(x, y) =
        x * y

    let exportedTuple1 = ( "Do", "Re", "Mi" )
    let exportedTuple2 = ( "Do", "Re", "Mi" )

    let exportedStructTuple1 = struct ( "Fa", "So", "La")
    let exportedStructTuple2 = struct ( "Fa", "So", "La")

    type ExportedRecord =
        {
            FirstNote : string
            SecondNote : string
            ThirdNote : string
        }

    type ExportedUnion =
    | SingleString of string
    | TwoString of string * string
    | TwoBool of bool * bool


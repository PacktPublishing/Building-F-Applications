namespace LanguageReview

module Sequences =

    let seqArray1 = seq [| 1 ; 2 ; 3 |]
    let seqArray2 = seq [| 1 .. 3 |]
    let seqList1 = seq [ 1 ; 2 ; 3 ]
    let seqList2 = seq [ 1 .. 3 ]

    let seq1 = seq { 1 .. 3 }
    seq1 |> Seq.take 1
    seq1

    let seq2 = seq { for i in 1 .. 3 -> i }
    let seq3 = Seq.init 3 (fun id -> id + 1)

    let seq4 = Seq.initInfinite (fun id -> id + 1)

    seq4 |> Seq.take 1
    seq4

namespace LanguageReview

module Collections =

    let array1 =     [| 1 .. 10 |]
    let list1 =      [  1 .. 10  ]
    let seq1 =   seq {  1 .. 10  }
    let set1 =   set {  1 .. 10  }
    let map1 =   Map.empty
                    .Add(1,"one").Add(2,"two").Add(3,"three")
                    .Add(4,"four").Add(5,"five").Add(6,"six")
                    .Add(7,"seven").Add(8,"eight")
                    .Add(9,"nine").Add(10,"ten")
    
    
    
namespace LanguageReview

module Functions =

    let func1 x : float = 
        x * x

    func1 12.0
    
    let func2 () =
        printfn "Hello functions!"

    let func3 x y =
        x * y

    let func4 = func3 11

    func4 8

    let func5 (x, y) =
        x * y

    let func6 () =
        (fun x -> x * x)

    func6() 55

    let func7 f x =
        f x

    6 |> func7 (fun x -> x * x)

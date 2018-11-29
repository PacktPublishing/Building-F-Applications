namespace LanguageReview

module Records =

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

    let func1 person =
        ( person.FirstName, person.Age )
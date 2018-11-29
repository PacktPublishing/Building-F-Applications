module SingleValuedUnions

type CheckingAccountApplication =
    {
        FirstName : string
        LastName : string
        HomePhone : string
        EmailAddress : string
    }

let makeCheckingAccountApplication 
    firstName lastName homePhone emailAddress =
    {
        FirstName = firstName
        LastName = lastName
        HomePhone = homePhone
        EmailAddress = emailAddress
    }

let application = 
    makeCheckingAccountApplication "James" "Henry" "111-222-3333" "a@b.com"


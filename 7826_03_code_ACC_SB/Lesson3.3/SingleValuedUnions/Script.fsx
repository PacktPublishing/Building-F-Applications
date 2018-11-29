module SingleValuedUnions

type FirstName = FirstName of string
type LastName = LastName of string
type PhoneNumber = PhoneNumber of string
type EmailAddress = EmailAddress of string

type CheckingAccountApplication =
    {
        FirstName : FirstName
        LastName : LastName
        HomePhone : PhoneNumber
        EmailAddress : EmailAddress
    }

let makeCheckingAccountApplication 
    firstName lastName homePhone emailAddress =
    {
        FirstName = firstName
        LastName = lastName
        HomePhone = homePhone
        EmailAddress = emailAddress
    }

let firstName = FirstName "Henry"
let lastName = LastName "James"
let phoneNumber = PhoneNumber "111-222-3333"
let emailAddress = EmailAddress "a@b.com"

let application = 
    makeCheckingAccountApplication firstName lastName phoneNumber emailAddress 

let s = match firstName with FirstName s -> s
let (FirstName s1) = firstName

module MustBeValid

    module CheckingAccounts =

        // To open a checking account, a customer provides
        // two forms of identification.

        type CheckingAccount = CheckingAccount

        type Identification = 
            | DriverLicense of string
            | SSNCard of string
            | MilitaryId of string
            | Passport of string

        type TwoIds = 
            | Ids of Identification * Identification

        let openCheckingAccount (ids : TwoIds) =

            let Ids (id1, id2) = ids
            // check whether id1 and id2 are valid ...
            CheckingAccount

    module Tests =
        open CheckingAccounts

        let goodIds = Ids ((DriverLicense "abc"), (Passport "123"))
        let account1 = openCheckingAccount goodIds

        let badIds = Ids ((DriverLicense "abc"), (DriverLicense "123"))
        let account2 = openCheckingAccount badIds

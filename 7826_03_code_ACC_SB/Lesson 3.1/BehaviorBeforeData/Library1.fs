module BehaviorBeforeData

    // To open a checking account, a customer provides
    // an application,
    // two forms of identification,
    // and an initial deposit.

    // The deposit must be at least $500.00.
    
    type CheckingAccount = 
        | CheckingAccount
    type Application = Application
    type Identification = Identification
    type Deposit = decimal

    let openCheckingAccount    
        (application : Application)
        (id : Identification * Identification)
        (deposit : Deposit) =
            if deposit >= 500M
                then Some CheckingAccount
                else None
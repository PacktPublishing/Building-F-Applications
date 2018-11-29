module UnitsOfMeasure

    type CheckingAccount = CheckingAccount
    [<Measure>] type money
    type Deposit = decimal<money>

    let openCheckingAccount (deposit : Deposit) =
            if deposit >= 500M<money>
                then Some CheckingAccount
                else None

    openCheckingAccount 888M<money>
   


    let someFeet = 12.0<ft>
    let someSecs = 2.34<sec>

    let feetSec = someFeet / someSecs

    someSecs * feetSec

    7778.987 * 1.0<ft>

    let doubleIt (fl : float<_>) =
        fl + fl

    doubleIt someFeet
    doubleIt someSecs
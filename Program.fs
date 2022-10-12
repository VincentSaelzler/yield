open System;

let inputNumbers = [1; 2; 3;]
printfn "randomNumbers: %A" inputNumbers

// the yield construct may only be used within list, array, or sequence expressions
// i.e. expressions of the form [..], [|..|], seq {..}
// these use the syntax for .. in .. do .. yield

let numList = [
    for n in inputNumbers do
        printfn "List Check %i" n
        yield n
]

let numArray = [|
    for n in inputNumbers do
    printfn "Array Check %i" n
    yield n
|]

printfn "numList: %A" numList
printfn "numArray: %A" numArray
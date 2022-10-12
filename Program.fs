open System;

let inputNumbers = [1; 2; 3; 4]
printfn "randomNumbers: %A" inputNumbers

// the yield construct may only be used within list, array, or sequence expressions
// i.e. expressions of the form [..], [|..|], seq {..}
// these use the syntax for .. in .. do .. yield

let numList = [
    for n in inputNumbers do
        printfn "List Check %i" n
        if n > 1 then yield n
]

let numArray = [|
    for n in inputNumbers do
    printfn "Array Check %i" n
    if n > 1 then yield n
|]

let numSeq = seq {
    for n in inputNumbers do
    printfn "Seq Check %i" n
    if n > 1 then yield n
}

printfn "numList: %A" numList
printfn "numArray: %A" numArray
printfn "numSeq: %A" numSeq

// the seq has lazy evaluation, so the output looks like this:
// numSeq: Seq Check 1
// Seq Check 2
// Seq Check 3
// Seq Check 4
// seq [2; 3; 4]

let NoThree = Seq.takeWhile (fun n -> n < 3) inputNumbers
printfn "NoThree: %A" NoThree

let NoThreeNoOne = Seq.takeWhile (fun n -> n < 3) numSeq
printfn "NoThreeNoOne: %A" NoThreeNoOne

// the takewhile cuts execution short when it encounters the three, so the output looks like this:
// NoThreeNoOne: Seq Check 1
// Seq Check 2
// Seq Check 3
// seq [2]

// Yield keyword is nice trick to save some memory and not load entire collection in memory at once.
// Bohdan Stupak

open System;

let randomNumbers = [2; 3; 7; 8]

printfn "%A" randomNumbers

for n in randomNumbers do
    Console.Write("About to Check ")
    Console.WriteLine(n)

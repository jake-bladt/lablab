// Given a directory, determine if it meets the following criteria:
// 1. It contains one or more .jpg files
// 2. Each of those file names starts with a number > 0 and <= the number of JPEGs
// 3. Each of those files has a string of text (called the subject name) after the number, separated by a dash -
// 4. None of the numbers duplicate
// 5. None of the subject names duplicate

open System
open System.IO

let usage = 
    printfn "Usage: gvaldir <election directory path>"

[<EntryPoint>]
let main argv =
    
    printfn "Hello World from F#!"
    0 // return an integer exit code

// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let dnu = System.Console.ReadLine // doesn't block
    0 // return an integer exit code

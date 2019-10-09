open System

let mult x y = x * y
let add x y = x + y

[<EntryPoint>]
let main argv =
    let a = add 2 2
    sprintf "Simple addition: %d" a |> Console.WriteLine

    let b = (+) 4 4
    sprintf "Outfix addition: %d" b |> Console.WriteLine

    let c = 8 |> add(8)
    sprintf "Curry addition: %d" c |> Console.WriteLine

    let d = 8 |> mult <| 8
    sprintf "Midfix multiplication: %d" d |> Console.WriteLine

    let e = (16, 0) ||> mult
    sprintf "Double-pipe multiplication: %d" d |> Console.WriteLine

    0

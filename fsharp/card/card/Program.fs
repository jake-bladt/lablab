open System
open Microsoft.FSharp.Collections

type Suit = Clubs=1 | Diamonds=2 | Hearts=3 | Spades=4

type Face = 
    Deuce=2 
    | Trey=3 
    | Four=4 
    | Five=5 
    | Six=6
    | Seven=7
    | Eight=8
    | Nine=9
    | Ten=10
    | Jack=11
    | Queen=12
    | King=13 
    | Ace=14 

type Card(face: Face, suit: Suit) =
    let SuitNames = [ "any", "clubs", "diamonds", "hearts", "spades" ]
    let FaceNames = [ "any", "any", "two", "three", "four", "five", "six",
        "seven", "eight", "nine", "ten", "jack", "queen", "king", "ace" ]
    
    member this.CardFace = face
    member this.CardSuit = suit

    member this.LongName() =
        printf "%s of %s", FaceNames.[int this.CardFace], SuitNames.[int this.CardSuit]

let CardParser str = 
    
    let suits = "cdhs"
    let faces = "23456789TJQKA"

    if String.IsNullOrEmpty str || str.Length < 2 then
        (null, str)
    else
        let faceIndex = faces.IndexOf str.[0]
        let suitIndex = suits.IndexOf str.[1]

        if faceIndex = -1 || suitIndex = -1 then
            (null, str)
        else
            let theFace:Face = enum (faceIndex + 2)
            let theSuit:Suit = enum (suitIndex + 1)
            (new Card(theFace, theSuit), str.[2..])

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code

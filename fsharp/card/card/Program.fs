open System

type Suit = Clubs=1 | Diamonds=2 | Hearts=3 | Spades=4

type Face = 
    Deuce=2 |
    Trey=3  |
    Four  = 4  |
    Five  = 5  |
    Six   = 6  |
    Seven = 7  |
    Eight = 8  |
    Nine  = 9  |
    Ten  = 10  |
    Jack = 11  |
    Queen = 12 |
    King  = 13 |
    Ace   = 14 

type Card(Face face, Suit suit) =
    member this.Face = face
    member this.Suit = suit

    let SuitNames = [ "any", "clubs", "diamonds", "hearts", "spades" ]
    let FaceNames = [ "any", "any", "two", "three", "four", "five", "six",
        "seven", "eight", "nine", "ten", "jack", "queen", "king", "ace" ]

    member this.LongName() =
        fprint("%s of %s", FaceNames[this.Face], SuitNames[this.Suit])

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code

// Given a directory, determine if it meets the following criteria:
// 1. It contains one or more .jpg files
// 2. Each of those file names starts with a number > 0 and <= the number of JPEGs
// 3. Each of those files has a string of text (called the subject name) after the number, separated by a dash -
// 4. None of the numbers duplicate
// 5. None of the subject names duplicate

open System
open System.IO
open System.Text

let usage() = 
    printfn "Usage: gvaldir <election directory path>"
    1

let dirDne d =
    printfn "Directory %s does not exist" d
    1

let join arr joiner =
    let ret = new StringBuilder()
    0
    // ret.ToString()

let stripExt fileName = 
    fileName.ToString().Replace(".jpg", String.Empty)

let electionEntryParse fileName:String =
    let parts = fileName.ToString().Split '-'
    (int parts.[0], parts.[1..])
    
[<EntryPoint>]
let main argv =
    if argv.Length < 1 then
        usage()
    else
        let path = argv.[0]
        if Directory.Exists(path) then
            let pathDI = new DirectoryInfo(path)
            let parsed = pathDI.GetFiles "*.jpg" |>
                Array.map f -> stripExt f                
            0
        else
            dirDne path
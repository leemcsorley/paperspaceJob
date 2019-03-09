// Learn more about F# at http://fsharp.org

open System
open System.IO

[<EntryPoint>]
let main argv =
    printfn "Paperspace TEST"
    File.WriteAllLines("artifacts/file.txt", [|"hello"; "world"; "paperspace"|])
    0 // return an integer exit code

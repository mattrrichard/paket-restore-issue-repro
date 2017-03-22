open FSharp.Configuration

type Settings = AppSettings<"app.config">

[<EntryPoint>]
let main argv = 
    printfn "Hello, %s!" Settings.GreetTarget
    0

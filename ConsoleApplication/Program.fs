open FSharp.Configuration

[<EntryPoint>]
let main argv = 
    printfn "%A" SecondProject.Config.config.DB.ConnectionString
    0 // return an integer exit code

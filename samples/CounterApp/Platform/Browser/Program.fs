namespace CounterApp.Browser
open System.Runtime.Versioning
open Avalonia
open Avalonia.Browser

module public Program =
    [<assembly: SupportedOSPlatform("browser")>]
    do ()

    [<CompiledName "BuildAvaloniaApp">] 
    let public buildAvaloniaApp () = 
        AppBuilder
            .Configure(fun () -> Program.startApplication App.program)

    [<EntryPoint>]
    let main argv =
        buildAvaloniaApp()
            .SetupBrowserApp("out")
            |> ignore
        0

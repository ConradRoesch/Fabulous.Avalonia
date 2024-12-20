namespace ComponentNavigation.iOS

open Foundation
open ComponentNavigation
open UIKit

open Avalonia
open Avalonia.iOS
open Fabulous.Avalonia
open Foundation
open UIKit

[<Register(nameof AppDelegate)>]
type AppDelegate() =
    inherit AvaloniaAppDelegate<FabApplication>()
    override this.CreateAppBuilder() = App.create().UseiOS()

module Main =
    [<EntryPoint>]
    let main (args: string array) =
        UIApplication.Main(args, null, typeof<AppDelegate>)
        0
module Program
//these are similar to C# using statements
open canopy.runner.classic
open canopy.configuration
open canopy.classic
open canopy
open canopyExtensions
open types




[<EntryPoint>]
let main _ =
  configuration.wipSleep <- 0.2
  configuration.compareTimeout <- 10.0
  configuration.elementTimeout <- 10.0
  configuration.pageTimeout <- 10.0
  configuration.autoPinBrowserRightOnLaunch <- false
  configuration.failFast := true
  configuration.chromeDir <- @"C:\work"

  

  start chrome
  resize (1400, 900)

  //application.all()
  

  run()

  System.Console.ReadKey() |> ignore
  quit()

  failedCount


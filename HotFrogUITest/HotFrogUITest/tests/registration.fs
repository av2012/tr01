module registration

open canopy
open common
open canopy.runner.classic
open canopy.configuration
open canopy.classic

open canopyExtensions
open types

open page_registrationStep1

let all () =
  //context "application"

    
  "Data is set properly" &&& fun _ ->
    "_address" == "http://www.turtletest.com"
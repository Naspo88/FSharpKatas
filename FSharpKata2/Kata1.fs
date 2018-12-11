module Kata1

open Xunit
open Swensen.Unquote


// Add function implementation
let add list = 0





[<Fact>]
let ``Add empty list is 0`` () =
    let result = add []
    test <@ result = 0 @>

[<Fact>]
let ``Add singleton`` () =
    let result = add [ 7 ]
    test <@ result = 7 @>

[<Fact>]
let ``Add negative numbers`` () =
    let result = add [ -7; 4 ]
    test <@ result = -3 @>


let numbers =
    "Kata1"
    |> Utils.getLines
    |> List.map int

[<Fact>]
let ``Add numbers from input`` () =
    let result = add numbers
    test <@ result = 508 @>

module Kata1

open Xunit
open Swensen.Unquote

(*

    # Summing a list

    Implement sum which sums a list of numbers, both positive and negative (without using List.sum or List.sumBy 😬)

    Bonus points for making it work with an empty list.

*)

// Add function implementation
let sum (list : int list) : int = 0






[<Fact>]
let ``Add singleton`` () =
    let result = sum [ 7 ]
    test <@ result = 7 @>

[<Fact>]
let ``Add negative numbers`` () =
    let result = sum [ -7; 4 ]
    test <@ result = -3 @>


let numbers =
    "Kata1"
    |> Utils.getLines
    |> List.map int

[<Fact>]
let ``Add numbers from input`` () =
    let result = sum numbers
    test <@ result = 508 @>

[<Fact>]
let ``Add empty list is 0`` () =
    let result = sum []
    test <@ result = 0 @>

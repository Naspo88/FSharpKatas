module Kata7

open Xunit
open Swensen.Unquote

(*

    # Write Number in Expanded Form

    You will be given a number and you will need to return it as a string in Expanded Form. For example:

        expandedForm 12 = "10 + 2"
        expandedForm 42 = "40 + 2"
        expandedForm 70304 = "70000 + 300 + 4"

    NOTE: All numbers will be whole numbers greater than 0.

*)


// Add implementation here
let expandedForm (num : int) : string = ""



[<Theory>]
[<InlineData(30, "30")>]
[<InlineData(12, "10 + 2")>]
[<InlineData(42, "40 + 2")>]
[<InlineData(70304, "70000 + 300 + 4")>]
let ``Check expandedForm`` (input, output) =
    test <@ expandedForm input = output @>


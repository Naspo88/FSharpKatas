module Kata4

open Xunit
open Swensen.Unquote

(*

    # FizzBuzz!

    Implement the function fizzBuzz that generates a list of strings. If a number is divisible by 3, make the string "Fizz", if by 5 it should be "Buzz". If it's divisible by both, make it "FizzBuzz". For every other number just make it a stringified version of the number, e.g. "4".

    ## Hint:
    The function `string` stringifies a number. E.g. string 123 = "123"

*)

// Add your implementation here
let fizzBuzz (start : int) (max : int) : string list = []







[<Fact>]
let ``Results for first 30`` () =
    let upTo30 =
        [ "1";
          "2";
          "Fizz";
          "4";
          "Buzz";
          "Fizz";
          "7";
          "8";
          "Fizz";
          "Buzz";
          "11";
          "Fizz";
          "13";
          "14";
          "FizzBuzz";
          "16";
          "17";
          "Fizz";
          "19";
          "Buzz";
          "Fizz";
          "22";
          "23";
          "Fizz";
          "Buzz";
          "26";
          "Fizz";
          "28";
          "29";
          "FizzBuzz" ]

    test <@ fizzBuzz 1 30 = upTo30 @>

[<Fact>]
let ``Results for random range`` () =
    let randomRange =
        [ "347";
          "Fizz";
          "349";
          "Buzz";
          "Fizz";
          "352";
          "353";
          "Fizz";
          "Buzz";
          "356";
          "Fizz";
          "358";
          "359";
          "FizzBuzz";
          "361";
          "362";
          "Fizz";
          "364" ]

    test <@ fizzBuzz 347 364 = randomRange @>
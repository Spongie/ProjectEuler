namespace Program

open System

module Problem17 =

    let getNameForSmallNumber x =
        match x with
        | 0 -> ""
        | 1 -> "one"
        | 2 -> "two"
        | 3 -> "three"
        | 4 -> "four"
        | 5 -> "five"
        | 6 -> "six"
        | 7 -> "seven"
        | 8 -> "eight"
        | 9 -> "nine"
        | _ -> ""

    let getNameForTenPlace x =
        match x with 
        | 0 -> ""
        | 2 -> "twenty"
        | 3 -> "thirty"
        | 4 -> "forty"
        | 5 -> "fifty"
        | 6 -> "sixty"
        | 7 -> "seventy"
        | 8 -> "eighty"
        | 9 -> "ninety"
        | _ -> ""

    let getNameForTeenNumber x =
        match x with
        | 10 -> "ten"
        | 11 -> "eleven"
        | 12 -> "twelve"
        | 13 -> "thirteen"
        | 14 -> "fourteen"
        | 15 -> "fifteen"
        | 16 -> "sixteen"
        | 17 -> "seventeen"
        | 18 -> "eighteen"
        | 19 -> "nineteen"
        | _ -> ""

    let getNameForNumberUnder100 x =
        let numbers = x.ToString().ToCharArray() |> Array.map (fun a -> Int32.Parse(a.ToString()))
        if numbers.Length = 1 then getNameForSmallNumber numbers.[0]
        else
        match numbers.[0] with
        | 1 -> getNameForTeenNumber x
        |_ -> sprintf "%s%s" (getNameForTenPlace numbers.[0]) (getNameForSmallNumber numbers.[1])

    let getAndText x =
        match x with
        | "" -> ""
        | _ -> "and"

    let getNameForNumberOver100 x =
        if x = 1000 then "onethousand"
        else
        let numbers = x.ToString().ToCharArray() |> Array.map (fun a -> Int32.Parse(a.ToString()))
        let hundreds = ((getNameForSmallNumber numbers.[0]) + "hundred")
        let tens = (getNameForNumberUnder100 (int (numbers.[1].ToString() + numbers.[2].ToString())))
        sprintf "%s%s%s" hundreds (getAndText tens) tens

    let getFullNameForNumber x =
        match x with 
        | y when y < 10 -> getNameForSmallNumber y
        | y when y >= 10 && y <= 19 -> getNameForTeenNumber y
        | y when y < 100 -> getNameForNumberUnder100 y
        | _ -> getNameForNumberOver100 x

    let Solve =
        [1..1000]
        |> Seq.map getFullNameForNumber
        |> Seq.map (fun x -> x.Length)
        |> Seq.sum


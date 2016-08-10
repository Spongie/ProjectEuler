namespace Program

module Problem5 =

    let DivisionTest x =
        match x % 10 with
        |0 -> [2..19]
              |>Seq.filter (fun z -> x % z = 0)
              |>Seq.length = 18
        |_ -> false

    let InfSeq =
        Seq.unfold(fun x -> Some(x, x + 1)) 20
        
    let Solve =
        InfSeq
        |>Seq.skipWhile(fun x -> (DivisionTest x) = false)
        |>Seq.head
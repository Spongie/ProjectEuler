namespace Program

module Problem7 =

    let InfSeq =
        Seq.unfold(fun x -> Some(x, x + 1L)) 1L

    let FindPrime =
        InfSeq
        |>Seq.filter(fun x -> Problem3.IsPrime x)
        |>Seq.nth 10001

    let Solve =
        FindPrime


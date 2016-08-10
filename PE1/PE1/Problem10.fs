namespace Program

module Problem10 =

    let Solve =
        [2L..2000000L]
        |>Seq.filter (fun x -> Problem3.IsPrime x)
        |>Seq.sum


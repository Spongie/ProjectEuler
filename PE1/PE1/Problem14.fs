namespace Program

module Problem14 =
    
    let getCollatzSequencLengthe x =
        let rec getCollatzSequence xx acc =
            match xx with
            | 1L -> 1L::acc
            | y when y % 2L = 0L -> 
                let newAcc = xx::acc 
                getCollatzSequence (xx / 2L) newAcc
            | _ -> 
                let newAcc = xx::acc 
                getCollatzSequence ((xx * 3L) + 1L) newAcc
        let sequence = getCollatzSequence x []
        (x, sequence.Length)

    let Solve =
        [1L..1000000L]
        |>Seq.map getCollatzSequencLengthe
        |>Seq.maxBy (fun (i, x) -> x)
        |> sprintf "%A"


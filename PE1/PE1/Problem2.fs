namespace Program

module Problem2 =

    let FibonacciSeq = 
        Seq.unfold(fun (current, next) -> Some(current, (next, current + next))) (0, 1)
    
    let Solve =
        FibonacciSeq
        |>Seq.takeWhile(fun x -> x < 4000000)
        |>Seq.filter(fun x -> x % 2 = 0)
        |>Seq.sum
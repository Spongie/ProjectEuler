namespace Program

module Problem6 =

    let SumOfSquares =
        [1..100]
        |>Seq.map(fun x -> x*x)
        |>Seq.sum

    let SquareOfSums =
        [1..100]
        |>Seq.sum
        |>fun x -> x * x

    let Solve =
        SquareOfSums - SumOfSquares


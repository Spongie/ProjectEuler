namespace Program

module Problem4 =

    let rec IsPalindrome (x:string) start length =
        let endOffset = length - 1
        if start = endOffset then true
        elif start > endOffset then true
        elif x.[start] = x.[endOffset] then IsPalindrome x (start + 1) (endOffset)
        else false

    let Multiply x =
        [100..999]
        |>Seq.map(fun t -> t * x)

    let Solve =
        [100..999]
        |>Seq.collect(fun x -> Multiply x)
        |>Seq.filter(fun z -> (IsPalindrome (z.ToString()) 0 (z.ToString().Length)))
        |>Seq.max
                
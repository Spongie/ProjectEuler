namespace Program

module Problem12 =
    
    let rec getasd x y z =
        if x >= z then y
        else
        getasd (x + 1) (y + x) z

    let getTriangular x =
        getasd 0 0 x

    let TriangleSeq =
        Seq.unfold(fun x -> Some(getTriangular x, x + 1)) 1

    let getNrOfDivisors x =
        let upper = x / 2
        {1..upper}
        |>Seq.filter(fun t -> x % t = 0)
        |>Seq.length
        |> (+) 1

    let Solve =
        TriangleSeq
        |>Seq.find(fun x -> (getNrOfDivisors x) > 500)
        


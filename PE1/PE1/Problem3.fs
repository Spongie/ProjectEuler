namespace Program

module Problem3 =

    let IsPrime (x:int64) =
        match x with
        | 1L | 2L | 3L -> true
        | _ ->  if x % 3L = 0L || x % 2L = 0L then false
                else
                let upper = (int64 (sqrt (float x)))
                seq{2L..upper}
                |>Seq.filter(fun m -> x % m = 0L)
                |>Seq.length = 0
        
    let Solve = 
        let upper = (int64 (sqrt (float 600851475143L)))
        [2L..upper]
        |>Seq.filter (fun y -> 600851475143L % y = 0L)
        |>Seq.filter IsPrime
        |>Seq.max
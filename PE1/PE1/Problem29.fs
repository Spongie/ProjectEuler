namespace Program

open System

module Problem29 =
          
    let getPowers x start limit =
        [start..limit]
        |> Seq.map (fun b -> Math.Pow(float x, float b))

    let Solve =
        [2..100]
        |>Seq.collect (fun x -> (getPowers x 2 100))
        |>Seq.distinct
        |>Seq.length
        
        


namespace Program

open System

module Problem16 =

    let toString x =
        x.ToString().ToCharArray()
    
    let Solve = 
        Numerics.BigInteger (Math.Pow(2.0, 1000.0))
        |> toString
        |> Array.map (fun x -> Int32.Parse(x.ToString()))
        |> Array.sum
        
        


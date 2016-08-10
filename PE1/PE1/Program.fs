namespace Program

module main =
    
    open System
    open System.Diagnostics

    let rec forever () =
         let input = Console.ReadLine()
         match input with
         |"1" -> printf "Solution to Problem1: %d\n" Problem1.Solve
         |"2" -> printf "Solution to Problem2: %d\n" Problem2.Solve
         |"3" -> printf "Solution to Problem3: %d\n" Problem3.Solve
         |"4" -> printf "Solution to Problem4: %d\n" Problem4.Solve
         |"5" -> printf "Solution to Problem5: %d\n" Problem5.Solve
         |"6" -> printf "Solution to Problem6: %d\n" Problem6.Solve
         |"7" -> printf "Solution to Problem7: %d\n" Problem7.Solve
         |"8" -> printf "Solution to Problem8: %d\n" Problem8.Solve
         |"9" -> printf "Solution to Problem9: %d\n" Problem9.Solve
         |"10" -> printf "Solution to Problem10: %d\n" Problem10.Solve
         |"11" -> printf "Solution to Problem11: %i\n" Problem11.Solve
         |"12" -> printf "Solution to Problem12: %d\n" Problem12.Solve
         |"13" -> printf "Solution to Problem13: %s\n" Problem13.Solve
         | _ -> ()
         match Int32.TryParse input with
         |true,_ -> forever ()
         |_,_ -> ()

    [<EntryPoint>]
    let main argv =       
        printf "Available Problems: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13\n"
        forever ()
        0
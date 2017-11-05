namespace Program

open System
open System.Collections.Generic

module Problem18 =
    
    let pyramid = [[3]
                   [7;4]
                   [2;4;6]
                   [8;5;9;3]]

    let height = 3;
    

    let rec traverse x y acc cache =
        //addToCache cache (x, y) pyramid.[y].[x]
        3

    let main =
        let cache = new Dictionary<int * int, int>();
        for x = 0 to pyramid.[height].Length do
            traverse x height 0 cache

    let test =
        let legnth = pyramid.Length
        let l = pyramid.[3].Length
        let l2 = pyramid.[2].Length
        3

    let Solve =
        test
namespace Program

module Problem9 =

    let IsTriplet a b c =
        (a*a) + (b*b) = (c*c)

    let IsSum1000 a b c =
        a + b + c = 1000

    let Solve =
        let start = [1..1000]
        [
        for x in start do
            let second = [x..1000]
            for y in second do
                let third = [y..1000]
                for z in third do
                    if IsTriplet x y z && IsSum1000 x y z then yield x*y*z
        ]
        |>List.head
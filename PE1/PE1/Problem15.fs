namespace Program

module Problem15 =
    
    let getPossibleWays width height =
        let rec countWays currentX currentY acc =
            if currentX < width && currentY < height then
                let xAcc = (countWays (currentX + 1) currentY acc)
                let yAcc = (countWays currentX (currentY + 1) acc)
                xAcc + yAcc + acc
            else if currentX < width then
                let xAcc = (countWays (currentX + 1) currentY acc)
                xAcc + acc
            else if currentY < height then
                let yAcc = (countWays currentX (currentY + 1) acc)
                yAcc + acc
            else
                acc + 1L
        countWays 0 0 0L

    let Solve =
        getPossibleWays 20 20



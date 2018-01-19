function solve() {
    let longestCycle = 0;
    let longestCycleNumber = 0;
    
    for (let i = 2; i < 1000; i++) {
        let remainders = [];
        let remainder = 1;
        
        while (remainder !== 0) {
            remainder = (remainder * 10) % i;

            if (remainders.includes(remainder)) {

                if (remainders.length > longestCycle) {
                    longestCycle = remainders.length;
                    longestCycleNumber = i;
                }

                break;
            }

            remainders.push(remainder);
        }
    }

    console.log(longestCycleNumber + " - " + longestCycle);
}

solve();
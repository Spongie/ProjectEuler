function isPrime(number) {
    if (number === 1)
        return false;
    else if (number === 2)
        return true;
    else if (number % 2 === 0)
        return false;

    for (let i = 3; i <= Math.sqrt(number); i++) {
        if (number % i === 0)
            return false;
    }

    return true;
}

function solve() {
    let consecutive = 0;
    let largestProduct = 0;


    for (let a = -999; a < 1000; a++) {
        for (let b = -999; b < 1000; b++) {
            let consecutivePrimes = 0;

            for (let n = 0; n < 10000000; n++) {
                let number = (n * n) + (n * a) + b;

                if (!isPrime(Math.abs(number))) {
                    if (consecutivePrimes >= consecutive) {
                        consecutive = consecutivePrimes;
                        largestProduct = a * b;
                    }
                    break;
                }
                consecutivePrimes++;
            }
        }
    }

    console.log(largestProduct);
}

solve();
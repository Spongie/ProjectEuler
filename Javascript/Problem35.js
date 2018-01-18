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

function getRotations(number) {
    let numberString = number.toString();
    let numbers = [];

    if (numberString.length === 0)
        return number;

    let nextNumber = numberString;
    for (let i = 0; i < numberString.length; i++) {
        let newNumber = nextNumber[0];

        for (let x = 1; x < nextNumber.length; x++) {
            newNumber += nextNumber[x];
        }

        numbers.push(newNumber);

        let currentStart = nextNumber[0];
        nextNumber = nextNumber.substring(1) + currentStart;
    }

    return numbers;
}

function isAllPrimes(numberList) {
    for (let i = 0; i < numberList.length; i++) {
        if (!isPrime(parseInt(numberList[i])))
            return false;
    }

    return true;
}

function findCircularPrimes() {
    let circularPrimes = 0;
    for (let i = 1; i < 1000000; i++) {
        if (!isPrime(i))
            continue;
        
        var numbers = getRotations(i);

        if (isAllPrimes(numbers))
        {
            circularPrimes++;
        }
    }

    console.log(circularPrimes);
}


findCircularPrimes();
function calcFac(number) {
    if (number === 1)
        return 1;
    
    return number * calcFac(number -1 );
}

function replaceAt(string, index, replace) {
    return string.substring(0, index) + replace + string.substring(index + 1);
  }

function solve() {
    let numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
    let totalPermutationsFound = 0;

    for (let i = 0; i < numbers.length; i++) {
        let permutations = calcFac(numbers.length - 1);

        if (permutations + totalPermutationsFound > 1000000) {
            let startNumber = numbers[i];

            let currentNumber = startNumber.toString();
            for (let x = 0; x < numbers.length; x++) {
                if (numbers[x] === startNumber)
                    continue;

                currentNumber += numbers[x].toString();
            }

            currentNumber = parseInt(currentNumber) - 1;
            
            let currentNumberString = currentNumber.toString();
            startNumber = startNumber.toString();
            while (currentNumberString[0] == startNumber) {
                currentNumber++;
                let foundNumbers = [];
                let goodNumber = true;
                currentNumberString = currentNumber.toString();
                for(let x = 0; x < currentNumberString.length; x++) {
                    if (!foundNumbers.includes(currentNumberString[x]))
                        foundNumbers.push(currentNumberString[x]);
                    else {
                        goodNumber = false;
                        break;
                    }
                }

                if (!goodNumber)
                    continue;

                totalPermutationsFound++;

                if (totalPermutationsFound === 1000000) {
                    console.log(currentNumberString);
                    break;
                }
            }
        }
        else {
            totalPermutationsFound += permutations;
        }
    }
}

solve();
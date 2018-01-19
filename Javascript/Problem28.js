const directionRight = 0;
const directionLeft = 1;
const directionUp = 2;
const directionDown = 3;

function generateBaseGrid(size) {
    let grid = new Array(size);
    for (let i = 0; i < size; i++) {
        grid[i] = new Array(size);
    }

    return grid;
}

function generateSpiral(size) {
    let grid = generateBaseGrid(size);

    let x = Math.floor(size / 2);
    let y = Math.floor(size / 2);

    let currentValue = 2;
    let delta = 1;
    let direction = directionRight;
    let targetIndex = x + 1;
    grid[x][y] = 1;

    while (true) {
        if (x === size -1 && y === 0)
            break;
        if (direction === directionRight) {
            x++;
        }
        else if (direction === directionLeft) {
            x--;
        }
        else if (direction === directionDown) {
            y++;
        }
        else if (direction === directionUp) {
            y--;
        }

        grid[x][y] = currentValue++;

        if (direction === directionRight && x === targetIndex) {
            direction = directionDown;
            targetIndex = y + delta;
        }
        else if (direction === directionLeft && x === targetIndex) {
            direction = directionUp;
            targetIndex = y - delta;
        }
        else if (direction === directionDown && y === targetIndex) {
            direction = directionLeft;
            delta++;
            targetIndex = x - delta;
        }
        else if (direction === directionUp && y === targetIndex) {
            direction = directionRight;
            delta++;
            targetIndex = x + delta;
        }
    }

    return grid;
}

function getDiagonalSum() {
    const size = 1001;
    let grid = generateSpiral(size);
    let sum = 0;
    let center = Math.floor(size / 2);

    for (let x = 0; x < size; x++) {
        sum += grid[x][x];

        if (x !== center)
            sum += grid[size - x - 1][x];
    }

    console.log(sum);
}

getDiagonalSum();
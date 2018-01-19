function coinSums(targetValue) {
    let combinations = 0;
    for (let p1 = 0; p1 <= 200; p1++) {
        for (let p2 = 0; p2 <= 100; p2++) {
            for (let p5 = 0; p5 <= 40; p5++) {
                for (let p10 = 0; p10 <= 20; p10++) {
                    for (let p20 = 0; p20 <= 10; p20++) {
                        for (let p50 = 0; p50 <= 4; p50++) {
                            for (let p100 = 0; p100 <= 2; p100++) {
                                for (let p200 = 0; p200 <= 1; p200++) {
                                    let totalValue = (p1 * 1) + (p2 * 2) + (p5 * 5) + (p10 * 10) + (p20 * 20) + (p50 * 50) + (p100 * 100) + (p200 * 200);

                                    if (totalValue === targetValue) {
                                        combinations++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    console.log(combinations);
}

coinSums(200);
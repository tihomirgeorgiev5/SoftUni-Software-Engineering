function toyShop(input) {
    let tripPrice = Number(input[0]);
    let puzzlesCount = Number(input[1]);
    let talkingDollCount = Number(input[2]);
    let teddyBearsCount = Number(input[3]);
    let mignionsCount = Number(input[4]);
    let trucksCount = Number(input[5]);

    let totalPrice = (puzzlesCount * 2.60) + (talkingDollCount * 3)
    + (teddyBearsCount * 4.10) + (mignionsCount * 8.20) +
    (trucksCount * 2);

    if((puzzlesCount + talkingDollCount + teddyBearsCount + mignionsCount
        + trucksCount) >= 50) {
            totalPrice = 0.75 * totalPrice;
        }

        totalPrice = 0.9 * totalPrice;
    if(totalPrice >= tripPrice) {
        console.log(`Yes! ${(totalPrice - tripPrice).toFixed(2)} lv left.`)
    }
    else {
        console.log(`Not enough money! ${(tripPrice - totalPrice).toFixed(2)} lv needed.`);
    }
}
toyShop(["320", "8", "2", "5", "5", "1"])
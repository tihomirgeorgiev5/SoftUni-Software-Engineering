function godzillaVsKong (input) {
    let budget = Number(input[0]);
    let statistsCount = Number(input[1]);
    let wearPriceForOneStatist = Number(input[2]);
    let totalWearPrice = wearPriceForOneStatist * statistsCount;

    let decorPrice = 0.1 * budget;

    if(statistsCount > 150) {
        totalWearPrice = totalWearPrice -(totalWearPrice * 0.1);
    }

    let totalPrice = decorPrice + totalWearPrice;

    if(totalPrice > budget) {
        console.log("Not enough money!");
        console.log(`Wingard needs ${Math.abs(totalPrice - budget).toFixed(2)} leva more.`);
    } else {
        console.log("Action!");
        console.log(`Wingard starts filming with ${Math.abs(totalPrice - budget).toFixed(2)} leva left.`);
    }



}
godzillaVsKong(["9587.88",
"222",
"55.68"])
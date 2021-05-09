function input(input) {
    let areaForGreening = input[0];
    let priceForOneSqMeter = 7.61;
    let discount = 0.18;
    let totalPriceForGreening = areaForGreening * priceForOneSqMeter;
    let discountPrice = discount * totalPriceForGreening;
    let totalPrice = totalPriceForGreening - discountPrice;

    console.log(`The final price is: ${totalPrice} lv.`);
    console.log(`The discount is: ${discountPrice} lv.`)


}
input (["550"]);
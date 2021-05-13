function vegetableMarket (input) {
    let priceVegetables = Number(input[0]);
    let priceFruits = Number(input[1]);
    let countVegetables = Number(input[2]);
    let countFruits = Number(input[3]);

    let totalPriceVegeteables = (priceVegetables * countVegetables) / 1.94;
    let totalPriceFruits = (priceFruits * countFruits) / 1.94;

    let totalPrise = (totalPriceFruits + totalPriceVegeteables).toFixed(2);
    console.log(totalPrise);

}
vegetableMarket([
    "0.194",
    "19.4",
    "10",
    "10"]);
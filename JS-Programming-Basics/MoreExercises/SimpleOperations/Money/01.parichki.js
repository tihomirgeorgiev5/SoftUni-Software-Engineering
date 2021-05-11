function parichki(input) {
    let bitcoinsCount = Number(input[0]);
    let chineseIuans = Number(input[1]);
    let comissionRate = Number(input[2]);

    let bitcoinPrice = 1168;
    let chineseIuansPrice = 0.15 * 1.76;

    let priceInLevs = 
    (bitcoinsCount * bitcoinPrice) +
    (chineseIuans * chineseIuansPrice);

    let priceInEuro = priceInLevs / 1.95;
    let totalPrice = priceInEuro - (priceInEuro * (comissionRate * 0.01));
    console.log(totalPrice.toFixed(2));
    


}
parichki (["1","5","5"]);
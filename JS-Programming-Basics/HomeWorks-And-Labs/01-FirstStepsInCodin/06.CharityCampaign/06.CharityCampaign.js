function charityCampaign (input) {
    let daysOfCampaign = Number(input[0]);
    let confectionersCount = Number(input[1]);
    let cakesCount = Number(input[2]);
    let wafflesCount = Number(input[3]);
    let pancakesCount = Number(input[4]);

    let cakePrice = 45;
    let wafflePrice = 5.80;
    let pancakePrice = 3.20;

    let priceOfProductsForOneDay = 
    (cakesCount * cakePrice) +
    (wafflesCount * wafflePrice) +
    (pancakesCount * pancakePrice);

    let totalProductsPrice =
    priceOfProductsForOneDay * daysOfCampaign * confectionersCount;

    let totalSum = totalProductsPrice - (totalProductsPrice / 8);
    console.log(totalSum);

    /*
⦁	Броят на дните, в които тече кампанията – цяло число
⦁	Броят на сладкарите – цяло число 
⦁	Броят на тортите – цяло число в интервал
⦁	Броят на гофретите – цяло число в интервала
⦁	Броят на палачинките – цяло число в интервал
*/

}
charityCampaign (["131",
"5",
"9",
"33",
"46"]);
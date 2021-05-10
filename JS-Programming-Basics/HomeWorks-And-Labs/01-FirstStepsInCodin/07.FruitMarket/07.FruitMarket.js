function fruitMarket(input){
    let strawberryPrice = Number(input[0]);
    let bananasCount = Number(input[1]);
    let orangesCount = Number(input[2]);
    let raspberriesCount = Number(input[3]);
    let strawberryCount = Number(input[4]);

    let raspberriesPrice = strawberryPrice / 2;
    let orangesPrice = raspberriesPrice * 0.6;
    let bananasPrice = raspberriesPrice * 0.2;

    let totalSum =
    (strawberryPrice * strawberryCount) +
    (raspberriesPrice * raspberriesCount) +
    (orangesPrice * orangesCount) +
    (bananasPrice * bananasCount);

    console.log(totalSum);

    /* 
⦁	Цена на ягодите в лева – реално число в ин
⦁	Количество на бананите в килограми – реално число в 
⦁	Количество на портокалите в килограми – реално чис
⦁	Количество на малините в килограми – реално число 
⦁	Количество на ягодите в килограми – реално число 
*/

}
fruitMarket (["63.5",
"3.57",
"6.35",
"8.15",
"2.5"])
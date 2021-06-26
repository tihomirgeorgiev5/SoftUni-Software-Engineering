function solve(input){ 
    let countCats = Number(input[0]);

    let countCatsGroup1 = 0;
    let countCatsGroup2 = 0;
    let countCatsGroup3 = 0;

    let totalFoods = 0;

    for (let index = 1; index <= countCats; index++) {
        let currentFood = Number(input[index]);
        if (currentFood >= 100 && currentFood < 200) {
            countCatsGroup1++;
            totalFoods+= currentFood;
        }
        else if (currentFood >= 200 && currentFood < 300) {
            countCatsGroup2 ++;
            totalFoods+= currentFood;
        }
        
        else if (currentFood >= 300 && currentFood < 400) {
            countCatsGroup3++;
            totalFoods+= currentFood;
        }
        
    }
    let totalPriceFood = (totalFoods / 1000) * 12.45;
    console.log(`Group 1: ${countCatsGroup1} cats.`);
    console.log(`Group 2: ${countCatsGroup2} cats.`);
    console.log(`Group 3: ${countCatsGroup3} cats.`);

    console.log(`Price for food per day: ${totalPriceFood.toFixed(2)} lv.`);


}
solve((["6",
"102",
"236",
"123",
"399",
"342", 
"222"]))

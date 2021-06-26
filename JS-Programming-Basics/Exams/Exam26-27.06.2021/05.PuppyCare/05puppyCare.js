function solve(input) {
    let foodCountKg = Number(input[0]);
    let foodCount = foodCountKg * 1000;
    let index = 1;

    let eatedFood = 0;
    let command = input[index];

    while (command !== 'Adopted') {
        eatedFood += Number(command);
        index++;





        command = input[index];


    }
    let diff = Math.abs(foodCount - eatedFood);
    if (foodCount >= eatedFood) {
        console.log(`Food is enough! Leftovers: ${diff} grams.`);

    }
    else {
        console.log(`Food is not enough. You need ${diff} grams more.`)
    }
   
}
solve((["2",
"999",
"456",
"999",
"999",
"123",
"456",
"Adopted"]));
    


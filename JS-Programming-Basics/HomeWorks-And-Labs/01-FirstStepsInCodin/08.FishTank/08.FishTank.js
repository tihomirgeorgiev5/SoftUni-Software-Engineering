function fishTank(input) {
    let length = Number(input[0]);
    let width = Number(input[1]);
    let height = Number(input[2]);
    let rate = Number(input[3]);

    let currentAquariumCapacity =
    length * width * height;
    
    let currentAquariumCapacityInLitres =
    currentAquariumCapacity / 1000;

    let pureAquariumCapacity = 
    currentAquariumCapacityInLitres - (currentAquariumCapacityInLitres * (rate * 0.01));
    console.log(pureAquariumCapacity);

/* 
⦁	Дължина в см –число 
⦁	Широчина в см –число 
⦁	Височина в см –число 
⦁	Процент  –число 
*/


}
fishTank (["105",
"77",
"89",
"18.5"]);
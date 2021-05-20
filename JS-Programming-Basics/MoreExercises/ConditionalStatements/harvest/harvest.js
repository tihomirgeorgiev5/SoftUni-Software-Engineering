function harvest(input) {
    let areaX = Number(input[0]);
    let productionForOneSqMY = Number(input[1]);
    let neededLitresWineZ = Number(input[2]);
    let countOfWorkers = Number(input[3]);

    let neededKgForWine = (0.4 * (areaX * productionForOneSqMY));
    let litresForWine = neededKgForWine / 2.5;


    if (litresForWine < neededLitresWineZ) {
        console.log(`It will be a tough winter! More ${Math.floor(Math.abs(litresForWine - neededLitresWineZ))} liters wine needed.`)
    } else {
        console.log(`Good harvest this year! Total wine: ${Math.floor(litresForWine)} liters.`);
        console.log(`${Math.ceil(Math.abs(litresForWine - neededLitresWineZ))} liters left -> ${Math.ceil(Math.ceil(Math.abs(litresForWine - neededLitresWineZ)) / countOfWorkers)} liters per person.`);
    }



}
harvest(["1020", "1.5", "425", "4"])
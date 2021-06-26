function solve(input){ 
    let averageSpeed = Number(input[0]);
    let litresNeededFor100km = Number(input[1]);

    let totalHours = ((384400 * 2) / averageSpeed) + 3;
    console.log(Math.ceil(totalHours));

    let neededLitres = (((384400 * 2) * litresNeededFor100km)/ 100);
    console.log(neededLitres);


}
solve(["10000",
"5"]);

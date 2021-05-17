function worldSwimmingRecord (input) {
    let record = Number(input[0]);
    let distance = Number(input[1]);
    let timeInSecForOneMeter = Number(input[2]);

    let waterResistanceInSec = (Math.floor(distance / 15)) * 12.5;
    let ivanTime = (distance * timeInSecForOneMeter) 
    + waterResistanceInSec;

    if(ivanTime < record) {
        console.log(` Yes, he succeeded! The new world record is ${ivanTime.toFixed(2)} seconds.`);

    } else {
        console.log(`No, he failed! He was ${(Math.abs(ivanTime - record)).toFixed(2)} seconds slower.`);
    }




}
worldSwimmingRecord(["55555.67",
"3017",
"5.03"])
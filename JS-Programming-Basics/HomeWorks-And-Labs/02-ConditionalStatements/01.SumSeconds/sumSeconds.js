function sumSeconds(input) {
    let time1 = Number(input[0]);
    let time2 = Number(input[1]);
    let time3 = Number(input[2]);

    let sumTimeInSec = time1 + time2 + time3;

    let timeInHours = Math.floor (sumTimeInSec / 60);
    let timeInSeconds = sumTimeInSec % 60;
    if(timeInSeconds < 10) {
        console.log(`${timeInHours}:0${timeInSeconds}`);
    } else {
        console.log(`${timeInHours}:${timeInSeconds}`);
    }

}
sumSeconds(["22", "7", 
"34"])
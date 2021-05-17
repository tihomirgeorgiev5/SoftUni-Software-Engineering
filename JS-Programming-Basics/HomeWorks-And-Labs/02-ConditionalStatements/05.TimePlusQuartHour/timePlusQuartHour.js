function timePlusTime(input) {
    let hour = Number(input[0]);
    let minutes = Number(input[1]);

    let totalMinutes = (hour * 60) + minutes + 15;

    let hourOutput = Math.floor(totalMinutes / 60);
    let minOutput = totalMinutes % 60;

    if(hourOutput > 23) {
        hourOutput = 0;
    }

    if (minOutput < 10) {
        console.log(`${hourOutput}:0${minOutput}`);
    } else {
        console.log(`${hourOutput}:${minOutput}`);
    }

}
timePlusTime(["0", "01"])

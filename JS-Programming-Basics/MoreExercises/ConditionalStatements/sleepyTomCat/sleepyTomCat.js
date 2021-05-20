function sleepyCat (input) {
    let countOfFreeDays = Number(input[0]);

    let goodStandardPlaysMinutes = 30000;
 
    let workingDaysTotalMinutes = (365 - countOfFreeDays) * 63;
    let freeDaysTotalMinutes = countOfFreeDays * 127;
    let diff = Math.abs(30000 - (workingDaysTotalMinutes + freeDaysTotalMinutes))
    let diffInHours = Math.floor(diff / 60);
    let diffInMin = diff % 60; 
     if((workingDaysTotalMinutes + freeDaysTotalMinutes) 
     > goodStandardPlaysMinutes) {
         console.log("Tom will run away")
         console.log(`${diffInHours} hours and ${diffInMin} minutes more for play`);
     } else {
         console.log("Tom sleeps well");
         console.log(`${diffInHours} hours and ${diffInMin} minutes less for play`)
     }




}
sleepyCat (["20"])
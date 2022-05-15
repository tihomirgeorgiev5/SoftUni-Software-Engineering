function solve(steps, footInM, speed){ 
    let totalLengthInM = steps * footInM;
    let speedInMInSec = speed / 3.6;

    let breakMinutes = (Math.floor(totalLengthInM / 500));

    let time = totalLengthInM / speedInMInSec;
    
    let timeHours = Math.floor(time / 3600);
    let timeinMinutes = Math.floor(time / 60);
    let timeInSec = Math.round(time - (timeinMinutes * 60));

    
    
    return `${((timeHours === 0 ? '00' : '')||(timeHours < 10 ? '0' : '') + timeHours)}:${(timeinMinutes < 10 ? '0' : '') + (timeinMinutes + breakMinutes)}:${(timeInSec < 10 ? '0' : '') + timeInSec}`


}
console.log(solve(4000, 0.60, 5))

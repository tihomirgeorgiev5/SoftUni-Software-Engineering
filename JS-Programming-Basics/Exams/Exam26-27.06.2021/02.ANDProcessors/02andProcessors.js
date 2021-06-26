function solve(input){ 
    let neededProcessor = Number(input[0]);
    let countOfWorkers = Number(input[1]);
    let workingDays = Number(input[2]);;

    let totalHours = countOfWorkers * workingDays * 8;
    let countOfProcessors = Math.floor(totalHours / 3);

    let diffCountProcessors = Math.abs(neededProcessor - countOfProcessors);
    

    if (countOfProcessors >=  neededProcessor) {
        console.log(`Profit: -> ${(diffCountProcessors * 110.10).toFixed(2)} BGN`);
    }
    else {
        console.log(`Losses: -> ${(diffCountProcessors * 110.10).toFixed(2)} BGN`);
    }


}
solve((["500",
"8",
"20"]));


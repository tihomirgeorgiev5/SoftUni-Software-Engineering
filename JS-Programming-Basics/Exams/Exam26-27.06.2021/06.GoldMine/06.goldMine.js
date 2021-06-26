function solve(input) {
    let countLocation = Number(input[0]);
    let i = 1;
    let sumAverageGold = 0;
    let sumGold = 0;

    for (let index = 0; index < countLocation; index++) {
        let averageCountGold = Number(input[i]);
        i++;
        let daysWorking = Number(input[i]);
        i++;
        if (sumGold > 0) {
            sumGold = 0;
            sumAverageGold = 0;
        }

        for (let index2 = 0; index2 < daysWorking; index2++) {
           let goldForDay = Number(input[i]);
           i++;
           sumAverageGold+= goldForDay;
           sumGold = sumAverageGold / daysWorking;
            
        }

        if (sumGold >= averageCountGold) {
            console.log(`Good job! Average gold per day: ${sumGold.toFixed(2)}.`);
            
        }
        else if (sumGold < averageCountGold) {
            console.log(`You need ${(averageCountGold - sumGold).toFixed(2)} gold.`);
        }

        
        


    }



}
solve((["2",
    "10",
    "3",
    "10",
    "10",
    "11",
    "20",
    "2",
    "20",
    "10"]))

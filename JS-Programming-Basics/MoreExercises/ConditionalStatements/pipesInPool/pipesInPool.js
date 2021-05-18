function pipesInPool (input) {
    let volumeV = Number(input[0]);
    let debitP1ForHour = Number(input[1]);
    let debitP2ForHour = Number(input[2]);
    let missingHoursN = Number(input[3]);

    let totalDebitP1 = debitP1ForHour * missingHoursN;
    let totalDebitP2 = debitP2ForHour * missingHoursN;
    let totalDebit = totalDebitP1 + totalDebitP2;

    if(totalDebit <= volumeV) {
      console.log(`The pool is ${((totalDebit / volumeV) * 100).toFixed(2)}% full.
       Pipe 1: ${((totalDebitP1 / totalDebit) * 100).toFixed(2)}%. Pipe 2: ${((totalDebitP2 / totalDebit) * 100).toFixed(2)}%.`);  
    } else {
        console.log(`For ${missingHoursN} hours the pool overflows with ${(totalDebit - volumeV).toFixed(2)} liters.`)
    }



}
pipesInPool (["100","100","100","2.5"])
function depositCalculator (input){
let sumToDeposit = Number(input[0]);
let depositTerm = Number(input[1]);
let annualInterestRate = Number(input[2]);

/* ⦁	Депозирана сума
⦁	Срок на депозита(в месеци) 
⦁	Годишен лихвен процент

сума =
 депозирана сума  + срок на депозита * 
((депозирана сума * годишен лихвен процент )
 / 12)
*/

let monthSum = (sumToDeposit * (annualInterestRate * 0.01)) / 12;
let totalSum = sumToDeposit + depositTerm * monthSum;

console.log(totalSum);
}
depositCalculator (["2350",
"6",
"7"]);
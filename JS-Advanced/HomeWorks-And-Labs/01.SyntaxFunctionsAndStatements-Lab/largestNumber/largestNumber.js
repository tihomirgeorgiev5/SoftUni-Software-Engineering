function solve(num1, num2, num3) {
    let largestNum = Math.max(num1,num2,num3);
    console.log(`The largest number is ${largestNum}.`);

}
solve(-3, -5, -22.5)

function largestNumber(num1, num2, num3) {
    let result;
    if (num1 > num2 && num1 > num3) {
        result = num1;
    } else if (num2 > num1 && num2 > num3) {
        result = num2;
    } else if (num3 > num1 && num3 > num2){
        result = num3;
    }
    console.log(`The largest number is ${result}.`);
}
largestNumber(-3, -5, -22.5)
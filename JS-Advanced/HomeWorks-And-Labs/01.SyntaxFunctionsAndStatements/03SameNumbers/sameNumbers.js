/*function solve(num){ 
    let string = String(num);
    let sum = 0;
    let isSame;

    for (let i = 0; i < string.length; i++) {
        sum += Number(string[i]);
        isSame = Number(string[0]) == Number(string[i]);    
    }

   console.log(isSame)
   console.log(sum)
}
solve(2222222);*/

function sameNumbers(input) {
    let inputString = String(input);
    let isSame = true;
    let digitSum = 0;
    let inputLength = inputString.length;
    let digitToCompare = Number(inputString[0]);


    for (let index = 0; index < inputLength; index++) {
        digitSum += Number(inputString[index]);
        
        if (Number(inputString[index]) !== digitToCompare) {
            isSame = false;
        } 
    }
    console.log(isSame);
    console.log(digitSum);

}
sameNumbers(1234);

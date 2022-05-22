/*function solve(arr){
    let newArr = [];
    for (let i = 0; i < arr.length; i++) {
        newArr.push(Number(arr[i]))
        
    }
    let sum = 0;
    for (let j = 0; j < newArr.length; j++) {
        
        if ((j===0) || (j === newArr.length-1)) {
            sum += newArr[j];
            
        }
        
    } 

    return(sum);


}
console.log(solve(['5', '10']))*/

function sumFirstLast(input) {
let first = input.shift();
let last = input.pop();

let result = Number(first) + Number(last);

console.log(result);
}
sumFirstLast(['20', '30', '40']);
sumFirstLast(['5', '10']);

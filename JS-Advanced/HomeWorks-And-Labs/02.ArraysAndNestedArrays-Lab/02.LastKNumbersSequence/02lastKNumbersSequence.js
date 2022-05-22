/*function solve(num1, num2) {
    let nNum = Number(num1);
    let kNum = Number(num2);

    let newArr = [1];


    for (let i = 1; i < nNum; i++) {
        let sum = 0;
        for (let j = i - 1; j >= 0 && j >= i - kNum; j--) {
            sum += newArr[j];

        }
        newArr[i] = sum;


    }
    return newArr;


}
console.log(solve(6, 3))*/


function lastKNum(n, k) {
    const arrLength = Number(n);
    let steps = Number(k);
    let arr = [1];

    for (let index = 1; index < arrLength; index++) {
       let nextNum = sum(arr,steps);
       arr.push(nextNum);
        
    }

    function sum(arr, steps) {
        steps = arr.length < steps ? arr.length : steps;

        let result = 0;

        for (let index = 1; index <= steps; index++) {
            result += arr[arr.length - index];   
        }
        return result;
    }
    return arr;

}
console.log(lastKNum(6, 3));
console.log(lastKNum(8, 2));


/*function solve(arr) {
    arr.sort((a, b) => a - b);
    
    let newArr = [];
    
    while (arr.length > 0) {
        newArr.push(arr.shift());
        if (arr.length > 0) {
            newArr.push(arr.pop());
        }
    }
    return newArr;
    

}
console.log(solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]))*/

function sortingNumbers(arr) {
    let sortedArr = arr.sort((a,b) => a-b);
    
     const newArr = [];
    while (arr.length !== 0) {
        newArr.push(sortedArr.shift());
        newArr.push(sortedArr.pop());
    }
    return newArr;
}
console.log(sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));

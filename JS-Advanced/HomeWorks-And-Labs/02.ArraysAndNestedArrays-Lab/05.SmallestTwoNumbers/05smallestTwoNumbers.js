/*function solve(arr){ 
    arr.sort((a,b)=>a-b);
    
    return (arr[0] + ' ' + arr[1]);



}
console.log(solve([30, 15, 50, 5]))*/

function smallestTwoNum(arr) {
    let newArr = [];
    arr.sort((a,b) => a-b);
    arr.splice(2);
    console.log(arr);

}
smallestTwoNum([30, 15, 50, 5]);
console.log('----');
smallestTwoNum([3, 0, 10, 4, 7, 3]);

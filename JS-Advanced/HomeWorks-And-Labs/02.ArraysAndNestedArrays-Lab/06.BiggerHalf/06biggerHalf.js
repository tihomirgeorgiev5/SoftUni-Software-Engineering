
/*function solve(arr){ 
    arr.sort((a,b)=> a - b);
    let newArr = [];
    let point = 0;

    if (arr.length % 2 == 0) {
        point = arr.length / 2;
        newArr = arr.slice(point);     
    } else {
        point = arr.length / 2;
        newArr = arr.slice(point);    
    }
    
    return newArr;
}
console.log(solve([4, 7, 2, 5]))*/

function biggestHalf(arr) {
    arr.sort((a, b) => a - b);
    const result = [];

    for (let index = Math.floor(arr.length / 2); index < arr.length; index++) {
        
        result.push(arr[index]);
    }
    return result;

}
console.log(biggestHalf([4, 7, 2, 5]));
console.log(biggestHalf([3, 19, 14, 7, 2, 19, 6]));



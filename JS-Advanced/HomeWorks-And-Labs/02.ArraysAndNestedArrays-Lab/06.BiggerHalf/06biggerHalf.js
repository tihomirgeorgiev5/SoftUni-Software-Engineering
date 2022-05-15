
function solve(arr){ 
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
console.log(solve([4, 7, 2, 5]))


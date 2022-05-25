/*function solve(arr, step){ 
    let newArr = [];
    for (let i = 0; i < arr.length; i++) {
        if (i % Number(step) === 0){
            newArr.push(arr[i]); 
        }
        
        
        
    }
    return newArr;

}
console.log(solve(['5', 
'20', 
'31', 
'4', 
'20'], 
2))*/

function printElFromArr(arr, step){
    let newArr = [];
    for (let index = 0; index < arr.length; index+=step) {
        newArr.push(arr[index]);    
    }

    return newArr;

}
console.log(printElFromArr(['5', 
'20', 
'31', 
'4', 
'20'], 
2));
console.log(printElFromArr(['dsa',
'asd', 
'test', 
'tset'], 
2
));
console.log(printElFromArr(['1', 
'2',
'3', 
'4', 
'5'], 
6));

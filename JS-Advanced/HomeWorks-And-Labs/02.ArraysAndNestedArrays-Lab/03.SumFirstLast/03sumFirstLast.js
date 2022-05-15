function solve(arr){
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
console.log(solve(['5', '10']))

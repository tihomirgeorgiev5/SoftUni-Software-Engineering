function solve(arr){ 
    let newArr = [];
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] < 0) {
            newArr.unshift(arr[i]);
            
        }
        else if (arr[i] > 0) {
            newArr.push(arr[i]);
        } else {
            newArr.push(arr[i]);
        }
        
        
    }
    for (j = 0; j < newArr.length; j++) {
        console.log(newArr[j]);
        
    }

}
solve([7, -2, 8, 9]);

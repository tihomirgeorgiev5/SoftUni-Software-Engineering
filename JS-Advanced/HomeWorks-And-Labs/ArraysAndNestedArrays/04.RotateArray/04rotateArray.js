function solve(arr, num){ 
    let realRotate = num % arr.length;
    for (let index = 0; index < realRotate; index++) {
        let ex = arr.pop();
        arr.unshift(ex);

    }
    return arr.join(' ');

}
console.log(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15);

function solve(num){ 
    let string = String(num);
    let sum = 0;
    let isSame;

    for (let i = 0; i < string.length; i++) {
        sum += Number(string[i]);
        isSame = Number(string[0]) == Number(string[i]);    
    }

   console.log(isSame)
   console.log(sum)
}
solve(2222222);

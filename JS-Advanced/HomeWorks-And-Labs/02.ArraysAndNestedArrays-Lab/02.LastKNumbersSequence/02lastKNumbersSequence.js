function solve(num1, num2){ 
    let nNum = Number(num1);
    let kNum = Number(num2);

    let newArr = [1];
    

    for (let i = 1; i < nNum; i++) {
        let sum = 0;
        for (let j = i-1; j >= 0 && j >= i - kNum; j--) {
            sum += newArr[j];
            
        }
        newArr[i] = sum;
        
        
  }
  return newArr;


}
console.log(solve(6, 3))

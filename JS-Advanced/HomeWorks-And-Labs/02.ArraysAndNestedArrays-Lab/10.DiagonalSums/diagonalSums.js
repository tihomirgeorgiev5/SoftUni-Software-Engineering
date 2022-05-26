function diagonalSums(matrix){
    let newarr = [];
   
   
    
  
let firstDiagonalSum = 0;
let secondDiagonalSum = 0;
/*
for (let rowIndex = 0; rowIndex < matrix.length; rowIndex++) {
    const row = matrix[rowIndex];
    for (let colIndex = 0; colIndex < row.length; colIndex++) {
         if (row[colIndex] > maxNum) {
             maxNum = row[colIndex];
         }
        

    }

}*/
for (let i = 0; i < matrix.length; i++) {
    firstDiagonalSum+= matrix[i][i];
    secondDiagonalSum+= matrix[i][matrix.length -1 -i];
    
    
}
newarr.push(firstDiagonalSum, secondDiagonalSum)
console.log(newarr.join(' '));
}
diagonalSums([[20, 40],
    [10, 60]]);
    console.log('----');
    diagonalSums([[3, 5, 17],
        [-1, 7, 14],
        [1, -8, 89]]);

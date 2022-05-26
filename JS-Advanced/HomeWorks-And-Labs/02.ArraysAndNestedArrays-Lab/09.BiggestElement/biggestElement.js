function biggestEl(matrix) {
    let maxNum = Number.MIN_SAFE_INTEGER;
    for (let rowIndex = 0; rowIndex < matrix.length; rowIndex++) {
        const row = matrix[rowIndex];
        for (let colIndex = 0; colIndex < row.length; colIndex++) {
             if (row[colIndex] > maxNum) {
                 maxNum = row[colIndex];
             }
            

        }

    }
    return maxNum;

}
console.log(biggestEl([[20, 50, 10],
    [8, 33, 145]]));
/*console.log(biggestEl([[20, 50, 10],
    [8, 33, 145]]));*/
console.log('---');
console.log(biggestEl([[3, 5, 7, 12],
[-1, 4, 33, 2],
[8, 3, 0, 4]]));

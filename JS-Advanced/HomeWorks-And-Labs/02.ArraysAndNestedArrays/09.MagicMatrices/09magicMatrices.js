/*function solve(matrix) {
    let magicSum = Number.MIN_SAFE_INTEGER;

    let isMagicMatrix = true;;


    for (let row = 0; row < matrix.length; row++) {
        let sum = matrix[row].reduce((a, x) => a + x);

        if (magicSum === Number.MIN_SAFE_INTEGER) {
            magicSum = sum;

        }

        if (sum !== magicSum) {
            isMagicMatrix = false;

        }
    }

    for (let col = 0; col < matrix[0].length; col++) {
        let sum = 0;
        for (let row = 0; row < matrix.length; row++) {
            let el = matrix[row][col];
            sum += el;
            
        }

        if (sum !== magicSum) {
            isMagicMatrix = false;
        }
        

    }
    

    return (isMagicMatrix);

}
console.log(solve([[4, 5, 6],
[6, 5, 4],
[5, 5, 5]]))*/

function magicMatrices(arr) {
    let sumRow = arr[0].reduce((a,b) => a + b);
    for (let index = 0; index < arr[0].length; index++) {
        let currentColSum = 0;
        for (let i = 0; i < arr.length; i++) {
            currentColSum += arr[i][index];  
        }
        if (currentColSum !== sumRow) {
            return false;
        }
        
    }
    return true;


}
console.log(magicMatrices([[4, 5, 6],
[6, 5, 4],
[5, 5, 5]]));
console.log('----');
console.log(magicMatrices([[11, 32, 45],
[21, 0, 1],
[21, 1, 1]]));
console.log('----');
console.log(magicMatrices([[1, 0, 0],
[0, 0, 1],
[0, 1, 0]]));

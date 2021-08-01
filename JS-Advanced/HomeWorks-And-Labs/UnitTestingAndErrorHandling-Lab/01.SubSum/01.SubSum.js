function subSum(arr, start, end) {
    //If the first element is not an array, return NaN
    if(!Array.isArray(arr)) {
        return NaN;
    }

    //If the start index is less than zero,
     //consider its value to be a zero

     if (Number(start) < 0) {
         start = 0;
     }
    //If the end index is outside the bounds of the array,
    //assume it points to the last index of the array

    if (Number(end) > arr.length - 1) {
        end = arr.length - 1;
    }

    let sum = 0;
    for (let i = start; i <= end; i++){
        sum += Number(arr[i]);
       
    }

    return sum;

}

console.log(subSum([10, 20, 30, 40, 50, 60], 3, 300));
console.log(subSum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1));
console.log(subSum([10, 'twenty', 30, 40], 0, 2));
console.log(subSum([], 1, 2));
console.log(subSum('text', 0, 2));


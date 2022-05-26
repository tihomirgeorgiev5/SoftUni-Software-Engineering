/*function solve(arr) {
    let maxNum = Number.MIN_SAFE_INTEGER;

    let result = arr.reduce((a, x) => {
        if (x >= maxNum) {
            maxNum = x;
            a.push(x);

        }
        return a;
    }, []);




    return result;

}
console.log(solve([20,
    3,
    2,
    15,
    6,
    1]));*/

function solve(arr) {
    let sum = 0;

    let result = arr.reduce((a,x) => {
        if (x >= sum) {
            sum = x;
            a.push(x);
        }
        return a;
    }, []);

    return result;
    

}
console.log(solve([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24]));
console.log('-----');
console.log(solve([1,
    2,
    3,
    4]));
console.log('-----');
console.log(solve([20,
    3,
    2,
    15,
    6,
    1]));
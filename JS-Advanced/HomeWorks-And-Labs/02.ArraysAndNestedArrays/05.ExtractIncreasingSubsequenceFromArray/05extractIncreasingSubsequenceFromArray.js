function solve(arr) {
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
    1]));

function aggregateElements(elements) {
    let totalSum = 0;
    let inverseSum = 0;
    let concatNum = '';

    for (let num of elements) {
        totalSum += num;
        inverseSum += 1 / num;
        concatNum += num;
    }

    console.log(totalSum);
    console.log(inverseSum);
    console.log(concatNum);


}
aggregateElements([1, 2, 3])

function aggElements(elements) {
    let sum = 0;
    let invSum = 0;
    let concNum = '';

    for (const num of elements) {
        sum += num;
        invSum += 1 / num;
        concNum += num;
    }

    console.log(sum);
    console.log(invSum);
    console.log(concNum);

}
aggElements([2, 4, 8, 16])
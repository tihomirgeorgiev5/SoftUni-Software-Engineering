function solve(arr){ 
return arr.filter((a, i) => i % 2 !== 0)
.map(x => x * 2)
.reverse()
.join(' ');

}
console.log(solve([10, 15, 20, 25]))

function processOddPosition (input) {
    const oddPositions = input.filter((x,i) => i % 2 != 0);
    const doubled = oddPositions.map(x => x*2);
    doubled.reverse();
    return doubled.join(' ');



}
console.log(processOddPosition([10, 15, 20, 25]));
console.log(processOddPosition([3, 0, 10, 4, 7, 3])); 

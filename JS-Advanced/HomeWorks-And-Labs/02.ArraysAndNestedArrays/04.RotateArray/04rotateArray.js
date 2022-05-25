/*function solve(arr, num){ 
    let realRotate = num % arr.length;
    for (let index = 0; index < realRotate; index++) {
        let ex = arr.pop();
        arr.unshift(ex);

    }
    return arr.join(' ');

}
console.log(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15);*/

function rotateArr(arr, rotation) {

    for (let index = 0; index < rotation; index++) {
        const lastEl = arr.pop();
        arr.unshift(lastEl);
    }
    return arr.join(' '); 
}
console.log(rotateArr(['1', 
'2', 
'3', 
'4'], 
2));
console.log(rotateArr(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15));

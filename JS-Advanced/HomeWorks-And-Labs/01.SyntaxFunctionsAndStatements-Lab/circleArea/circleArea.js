function radius(input) {
    let typeInput = typeof(input);

    if(typeInput === 'number') {
        let circleArea = Math.pow(input,2) * Math.PI;
        console.log(circleArea.toFixed(2))
    } else {
        console.log(`We can not calculate the circle area, because we receive a ${typeof(input)}.`)
    }

}
radius('name')

function circleArea(input) {
    let result;
    let inputType = typeof(input);
    if (inputType === 'number') {
        result = Math.pow(input, 2) * Math.PI;
        console.log(result.toFixed(2));
    } else {
        console.log(`We can not calculate the circle area, because we receive a ${inputType}.`)
    } 
}
circleArea('name')
function rectangle(width, height, color) {

    function getColor(input) {
        return input.charAt(0).toUpperCase() + input.slice(1);
    }

    function calcArea(width, height) {
        return this.width * this.height;
    }

    return {
        width,
        height,
        color: getColor(color),
        calcArea,
    }
}
let rect = rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());
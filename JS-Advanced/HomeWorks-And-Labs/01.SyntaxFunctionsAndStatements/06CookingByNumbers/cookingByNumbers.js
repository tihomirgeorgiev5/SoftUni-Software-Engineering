/*function solve(num,op1,op2,op3,op4,op5) {
    /*
chop - divide the number by two
dice - square root of number
spice - add 1 to number
bake - multiply number by 3
fillet - subtract 20% from number

    let number = Number(num);
    let arrayOp = [];
    arrayOp.push(op1,op2,op3,op4,op5);

    for (let i = 0; i < arrayOp.length; i++) {
        switch (arrayOp[i]) {
            case 'chop': number /= 2; console.log(number);break;
            case 'dice': number = Math.sqrt(number);console.log(number); break;
            case 'spice': number++; console.log(number);break;
            case 'bake': number *= 3; console.log(number);break;
            case 'fillet': number *= 0.8; console.log(number);break;

        }


    }
}
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet') */

function cooking(num, op1, op2, op3, op4, op5) {
    let number = Number(num);
    let array = [];
    array.push(op1,op2,op3,op4,op5);

    for (let index = 0; index < array.length; index++) {
        switch (array[index]) {
            case 'chop': number /= 2; console.log(number);break;
            case 'dice': number = Math.sqrt(number); console.log(number);break;
            case 'spice': number ++; console.log(number);break;
            case 'bake': number = number*3; console.log(number);break;
            case 'fillet': number *= 0.8 ; console.log(number);break;
        }
        
    }
}
cooking('9', 'dice', 'spice', 'chop', 'bake', 'fillet')

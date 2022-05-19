function solve(x,y){
    while(y){
        let any= y;
        y = x % y;
        x = any;
    }
    return(x);
    
}

console.log(solve(15, 5));
console.log(solve(2154, 458));

function gCD (num1, num2) {
    let divident1 = Number(num1);
    let divident2 = Number(num2);

    while (divident1 !== divident2) {
        if (divident1 > divident2) {
            divident1-= divident2;
        } else {
            divident2-=divident1;
        }
    }
    console.log(divident1);


}
gCD(2154, 458);
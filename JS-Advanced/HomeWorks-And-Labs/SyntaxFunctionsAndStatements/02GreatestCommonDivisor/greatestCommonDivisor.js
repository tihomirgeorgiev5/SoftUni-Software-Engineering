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
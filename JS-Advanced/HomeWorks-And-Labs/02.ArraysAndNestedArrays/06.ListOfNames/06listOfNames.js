function solve(arr){ 
    arr.sort((a, b) => a.localeCompare(b));
    
    for (i = 0; i < arr.length; i++) {
        let num = i + 1;
        console.log(`${num}.${arr[i]}`);
        
    }

}
solve(["John", "Bob", "Christina", "Ema"]);

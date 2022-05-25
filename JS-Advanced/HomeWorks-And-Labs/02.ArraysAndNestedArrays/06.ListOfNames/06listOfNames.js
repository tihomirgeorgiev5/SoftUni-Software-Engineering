/*function solve(arr){ 
    arr.sort((a, b) => a.localeCompare(b));
    
    for (i = 0; i < arr.length; i++) {
        let num = i + 1;
        console.log(`${num}.${arr[i]}`);
        
    }

}
solve(["John", "Bob", "Christina", "Ema"]);*/

function listNames(arr){
   
    arr.sort((a,b) => a.localeCompare(b));
    

    for (let index = 0; index < arr.length; index++) {
       
        console.log(`${index + 1}.${arr[index]}`);
        
    }

}
listNames(["John", "Bob", "Christina", "Ema"]);

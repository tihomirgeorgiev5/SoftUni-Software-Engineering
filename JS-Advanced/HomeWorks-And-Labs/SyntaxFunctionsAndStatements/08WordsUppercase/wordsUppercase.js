function solve(input) {
let array = input.toUpperCase().match(/\w+/g);
return(array.join(', '));
}

console.log((solve ('Hi, how are you?')));

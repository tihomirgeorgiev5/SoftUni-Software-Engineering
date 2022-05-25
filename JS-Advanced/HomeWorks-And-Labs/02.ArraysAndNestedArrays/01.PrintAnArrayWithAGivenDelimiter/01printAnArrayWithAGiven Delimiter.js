/*function solve(arr, string){
    let result = arr.join(string);
    
    return result;

}
console.log(solve(['One', 
'Two', 
'Three', 
'Four', 
'Five'], 
'-'))*/

function givenDelimeter(arr, string) {
    let delimeter = string;
    let newArr = arr.join(delimeter);
    console.log(newArr);

}
givenDelimeter(['One', 
'Two', 
'Three', 
'Four', 
'Five'], 
'-');
givenDelimeter(['How about no?', 
'I',
'will', 
'not', 
'do', 
'it!'], 
'_');

/*function solve(arr){ 

   function sorter(a, b) {
       if (a.length > b.length) {
           return 1;
           
       } else if (a.length == b.length) {
           return a.localeCompare(b);

       } else {
           return -1;
       }
   }

   arr.sort(sorter);

   //console.log(arr)

   for (const iterator of arr) {
       console.log(iterator);
   } 

    
}
solve
    (['Isacc', 
    'Theodor', 
    'Jack', 
    'Harrison', 
    'George'])*/

    function sortedByCriteria(arr){
        arr.sort((a, b) => a.length - b.length || a.localeCompare(b));
console.log(arr.join('\n'));
    }
    sortedByCriteria(['alpha', 
    'beta', 
    'gamma']);
    console.log('------');
    sortedByCriteria(['Isacc', 
    'Theodor', 
    'Jack', 
    'Harrison', 
    'George']
    );
    console.log('------');
    sortedByCriteria(['test', 
    'Deny', 
    'omen', 
    'Default']);
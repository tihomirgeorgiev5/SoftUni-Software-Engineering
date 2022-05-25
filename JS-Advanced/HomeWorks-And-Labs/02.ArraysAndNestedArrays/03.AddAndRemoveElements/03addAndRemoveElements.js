/*function solve(arr) {
    let newArr = [];
    let iniNum = 1;
    
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === 'add') {
            newArr.push(iniNum + i)

        //} else if (arr[0] === 'remove') {
            //console.log('Empty');
           // let x = new Boolean(isEmpty);
            

        } else {
            newArr.pop(arr[i]);

        }

    }
    if (newArr.length > 0) {
        newArr.forEach(element => console.log(element));
        
        
    } else {
        console.log('Empty');
       

    }

}
solve(['remove',
    'remove',
    'remove'])*/


function addRemoveEl(arr) {
    const newArr = [];

    for (let index = 0; index < arr.length; index++) {
        const element = arr[index];
        if (element === 'add') {
            newArr.push(index + 1);
        } else if (element === 'remove') {
            newArr.pop();
        }

    }
    if (newArr.length === 0) {
        return 'Empty';
    } else {
        return newArr.join('\n');
    }   

}
console.log(addRemoveEl(['add',
    'add',
    'add',
    'add']
));
console.log('....');
console.log(addRemoveEl(['add',
    'add',
    'remove',
    'add',
    'add']));
    console.log('....');
console.log(addRemoveEl(['remove',
    'remove',
    'remove']));
function solve(arr) {
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
    'remove'])

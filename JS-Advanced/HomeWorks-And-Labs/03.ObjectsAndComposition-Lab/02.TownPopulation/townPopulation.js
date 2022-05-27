function towns(arr){
    //iterate input
    // parse each element
    //store result

    const result = {};

    for (const town of arr) {
        const tokens = town.split(' <-> ');
        const name = tokens[0];
        const popul = Number(tokens[1]);

        if (result[name] == undefined) {
            result[name] = popul;
        } else {
            result[name] += popul;

            
        }

        

    }
    //print result
    for (const town in result) {
        console.log(`${town} : ${result[town]}`);
    }
   

}
towns(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']);
console.log('---');
towns(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']);
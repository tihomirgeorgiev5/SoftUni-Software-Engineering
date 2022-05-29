function solve(input) {
    let result = [];

    while(input.length) {
        let heroData = input.shift();
        let [name, level, itemsArr] = heroData.split(' / ');
        level = Number(level);
        const items = itemsArr ? itemsArr.split(', ') : [];
        result.push({name, level, items});
    }



return JSON.stringify(result);
}
console.log(solve(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']));

//[{"name":"Isacc","level":25,"items":["Apple","GravityGun"]},{"name":"Derek","level":12,"items":["BarrelVest","DestructionSword"]},{"name":"Hes","level":1,"items":["Desolator","Sentinel","Antara"]}]  
console.log('-----');
console.log(solve((['Jake / 1000 / Gauss, HolidayGrenade'])));
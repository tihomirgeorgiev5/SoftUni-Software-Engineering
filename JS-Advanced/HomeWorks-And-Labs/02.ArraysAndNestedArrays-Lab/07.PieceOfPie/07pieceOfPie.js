/*function solve(arrPies, firstPie, lastPie){ 
    let firstIndexPie = arrPies.indexOf(firstPie);
    let lastIndexPie = arrPies.indexOf(lastPie);

    return arrPies.slice(firstIndexPie, lastIndexPie + 1);

}
console.log(solve(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'))*/

function piecePie(input, start, end) {
    const startIndex = input.indexOf(start);
    const endIndex = input.indexOf(end) + 1;

    return input.slice(startIndex, endIndex);

}
console.log(piecePie['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie');
console.log(piecePie(['Apple Crisp',
'Mississippi Mud Pie',
'Pot Pie',
'Steak and Cheese Pie',
'Butter Chicken Pie',
'Smoked Fish Pie'],
'Pot Pie',
'Smoked Fish Pie'))
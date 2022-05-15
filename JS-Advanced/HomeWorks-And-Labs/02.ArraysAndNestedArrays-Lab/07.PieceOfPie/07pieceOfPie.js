function solve(arrPies, firstPie, lastPie){ 
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
'Lemon Meringue Pie'))

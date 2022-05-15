function stringLength(str1, str2, str3) {
    let string1Length = str1.length;
    let string2Length = str2.length;
    let string3Length = str3.length;

    let totalSumOfLength = string1Length + string2Length + string3Length;
    let averageLength = Math.floor(totalSumOfLength / 3);

    console.log(totalSumOfLength);
    console.log(averageLength);

}
stringLength('chocolate', 'ice cream', 'cake')

function stringLength(input1, input2, input3) {
    let input1Length = input1.length;
    let input2Length = input2.length;
    let input3Length = input3.length;

    let sumLength = input1Length + input2Length + input3Length;
    let averageLength = Math.floor(sumLength / 3);
    console.log(sumLength);
    console.log(averageLength);

}
stringLength('pasta', '5', '22.3')
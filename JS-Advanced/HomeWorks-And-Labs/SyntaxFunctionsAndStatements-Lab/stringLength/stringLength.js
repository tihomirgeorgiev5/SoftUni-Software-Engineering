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
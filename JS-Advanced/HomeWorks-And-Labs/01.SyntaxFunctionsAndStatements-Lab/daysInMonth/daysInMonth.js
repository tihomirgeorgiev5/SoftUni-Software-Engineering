function daysInMonth(num1, num2) {

    let month = num1;
    let year = num2;
    let result = new Date(year, month,'0');
    console.log(result.getDate());
}
daysInMonth(2, 2021)
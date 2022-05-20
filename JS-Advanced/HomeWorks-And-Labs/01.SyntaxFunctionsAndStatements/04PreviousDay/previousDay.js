function previousDay(num1, num2, num3) {
    let year = Number(num1);
    let month = Number(num2);
    let day = Number(num3);
    let dateInput = `${year}-${month}-${day}`;
    let date = new Date(dateInput);
    date.setDate(date.getDate()-1);
    console.log(`${date.getFullYear()}-${date.getMonth()+1}-${date.getDate()}`);
    
}
previousDay(2016, 9, 30)
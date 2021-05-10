function vacationBook(input) {
    let bookPages = Number(input[0]);
    let readingPagesForOneHour = Number(input[1]);
    let daysForReading = Number(input[2]);

    let totalHoursForReading = bookPages / readingPagesForOneHour;
    let countOfHoursPerDayForReading = totalHoursForReading / daysForReading;

    console.log(countOfHoursPerDayForReading);

/* 
⦁	Брой страници в текущата книга – цяло число 
⦁	Страници, които може да прочита за 1 час – цяло число 
⦁	Броя на дните, за които трябва да прочете книгата – цяло число
*/

} 
vacationBook
(["432",
"15",
"4"])
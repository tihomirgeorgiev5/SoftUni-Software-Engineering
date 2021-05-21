function transportPrice (input) {
    let kilometres = Number(input[0]);
    let timePeriod = input[1];
    let totalPrice = 0;
    let dayPrice = 0;
    let nightPrice = 0;

   /* if(kilometres < 20) {
        let beginningPrice = 0.70;
        let dayTariffTaxi = 0.79 * kilometres;
        let nightTariffTaxi = 0.90 * kilometres;
    } else if(kilometres < 100) {
        let tariffBus = 0.09 * kilometres;
    } else {
        let tariffTrain = 0.08 * kilometres;
    } */

    if(kilometres >= 100) {
         totalPrice = totalPrice + kilometres * 0.06;
        console.log(totalPrice.toFixed(2));
    } else if(kilometres >= 20) {
         totalPrice = totalPrice + kilometres * 0.09;
         console.log(totalPrice.toFixed(2));
    } else if(timePeriod === "day") {
    
        dayPrice = dayPrice + (0.79 * kilometres) + 0.70;
        console.log(dayPrice.toFixed(2));

    } else {
        nightPrice = nightPrice + (0.90 * kilometres) + 0.70;
        console.log(nightPrice.toFixed(2));
    }

}
transportPrice (["180","night"])
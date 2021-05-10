function birthdayParty(input){
    let hallRent = Number(input[0]);

    let animatorPrice = hallRent / 3;
    let cakePrice = hallRent * 0.2;
    let drinksPrice = 0.55 * cakePrice;

    let totalPrice = hallRent + cakePrice + drinksPrice + animatorPrice;

    console.log(totalPrice);


/* 
⦁   Торта  – цената ѝ е 20% от наема на залата
⦁	Напитки – цената им е 45% по-малко от тази на тортата
⦁	Аниматор – цената му е 1/3 от цената за наема на залата
*/

}
birthdayParty (["3720"]);
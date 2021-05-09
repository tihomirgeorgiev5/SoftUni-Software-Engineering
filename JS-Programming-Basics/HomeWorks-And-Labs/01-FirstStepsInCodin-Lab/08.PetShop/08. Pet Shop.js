function input(input) {
    let numOfDogs = input[0];
    let numOfOtherAnimals = input[1];
    let priceForDogFood = 2.50;
    let priceForOtherAnimalFood = 4;
    let totalPriceDogFood = numOfDogs * priceForDogFood;
    let totalPriceOtherAnimalsFood = numOfOtherAnimals * priceForOtherAnimalFood;
    let totalPrice = totalPriceDogFood + totalPriceOtherAnimalsFood;

    console.log(`${totalPrice} lv.`)


}
input (["5", "4"]);
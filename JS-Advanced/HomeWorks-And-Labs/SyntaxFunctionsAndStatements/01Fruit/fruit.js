function solve(string, num1, num2){ 
    let weightInG = num1;
    let pricePerKg = num2;

    let price = (weightInG / 1000) * pricePerKg;

    return `I need $${price.toFixed(2)} to buy ${(weightInG / 1000).toFixed(2)} kilograms ${string}.`

}
console.log(solve('orange', 2500, 1.80));


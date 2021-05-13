function celsiusToFahrenheit(input) {
    // T (° F) = T (° C) × 1,8 + 32
    let celsius = Number(input[0]);
    let fahrenheit = ((celsius * 1.8) + 32).toFixed(2);

    console.log(fahrenheit);

}
celsiusToFahrenheit(["25"])
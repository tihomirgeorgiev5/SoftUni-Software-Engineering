function numbers(input) {
    let inch = Number(input[0]);
    let centimeters = inch * 2.54;
    
    console.log(centimeters.toLocaleString("en-US"));
    }
    numbers (["5"]);
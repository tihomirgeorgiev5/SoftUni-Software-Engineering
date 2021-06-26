function solve(input) {
    let catBreed = input[0];
    let catGender = input[1];
    let validCat = true;

    let catLifeHumanYears = 0;

    if (catGender === 'm') {
        switch (catBreed) {
            case 'British Shorthair': catLifeHumanYears = 13; break;
            case 'Siamese': catLifeHumanYears = 15; break;
            case 'Persian': catLifeHumanYears = 14; break;
            case 'Ragdoll': catLifeHumanYears = 16; break;
            case 'American Shorthair': catLifeHumanYears = 12; break;
            case 'Siberian': catLifeHumanYears = 11; break;

            default: validCat = false; console.log(`${catBreed} is invalid cat!`); break;
        }

    } else if (catGender === 'f') {
        switch (catBreed) {
            case 'British Shorthair': catLifeHumanYears = 14; break;
            case 'Siamese': catLifeHumanYears = 16; break;
            case 'Persian': catLifeHumanYears = 15; break;
            case 'Ragdoll': catLifeHumanYears = 17; break;
            case 'American Shorthair': catLifeHumanYears = 13; break;
            case 'Siberian': catLifeHumanYears = 12; break;

            default: validCat = false; console.log(`${catBreed} is invalid cat!`); break;
        }

    }
    let catMonthsLife = Math.floor((catLifeHumanYears * 12)/ 6);

    if(validCat) {
        console.log(`${catMonthsLife} cat months`);
    }


    //console.log(`${catMonthsLife} cat months`);

}
solve(["Tom",
"m"]);

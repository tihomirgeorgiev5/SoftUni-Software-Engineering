function traininigLab(input) {
    let lengthInCentimetres = Number(input[0]) * 100;
    let widthInCentimetres = Number(input[1]) * 100 - 100;

    //let widthWithoutCorridor = widthInCentimetres - 100;

    //let totalPlace = lengthInCentimetres * widthInCentimetres;

    
    let workPlacewidth = Math.floor(widthInCentimetres / 70);
    let workPlaceLength = Math.floor(lengthInCentimetres / 120);

    let totalPlaces = workPlaceLength * workPlacewidth - 3;


    
    console.log(totalPlaces);



}
traininigLab (["8.4","5.2"]);
function areaFigures(input) {
    let typeOfFigure = input[0];
    if(typeOfFigure === "square") {
        let a = Number(input[1]);
        let area = a * a;
        console.log(area.toFixed(3));
    }
    else if (typeOfFigure === "rectangle") {
        let a = Number(input[1]);
        let b = Number(input[2]);
        let area = a * b;
        console.log(area.toFixed(3));
    }
    else if(typeOfFigure === "circle") {
        let r = Number(input[1]);
        let area = Math.PI * Math.pow(r,2);
        console.log(area.toFixed(3));
        
    }
    else if(typeOfFigure === "triangle") {
        let a = Number(input[1]);
        let h = Number(input[2]);
        let area = (a * h) / 2;
        console.log(area.toFixed(3));

    }
    
}
areaFigures (["triangle",
"4.5",
"20"])
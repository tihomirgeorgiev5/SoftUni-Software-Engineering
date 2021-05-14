function housePainting(input) {
    let x = Number(input[0]);
    let y = Number(input[1]);
    let h = Number(input[2]);

    let greenPaintConsumption = 3.4;
    let redPaintConsumption = 4.3;

    let areaDoor = 1.2 * 2;
    let areaWindow = 1.5 * 1.5;// x 2

    let areaFrontWall = (x * x) - areaDoor;
    let areaBehindWall = x * x;
    let areaSiteWalls = ((x * y) - areaWindow) * 2;

    let areaRectangularRoofs = (x * y) * 2;
    let areaTriangleRoofs = ((x * h) / 2) * 2;

    let totalConsumptionGreenPaint = (areaFrontWall + areaBehindWall
    + areaSiteWalls) / greenPaintConsumption;
    let totalConsumptionRedPaint = (areaRectangularRoofs + areaTriangleRoofs) 
    / redPaintConsumption;

    console.log(totalConsumptionGreenPaint.toFixed(2));
    console.log(totalConsumptionRedPaint.toFixed(2));





}
housePainting(["6","10","5.2"]);
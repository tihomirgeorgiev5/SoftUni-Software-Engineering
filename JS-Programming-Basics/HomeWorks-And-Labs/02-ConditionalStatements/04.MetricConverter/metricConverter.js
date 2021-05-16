function metricConverter(input) {
    let num = Number(input[0]);
    let inputMetric = input[1];
    let outputMetric = input[2];

    let inputInMm = 0;
    let output = 0;

    if(inputMetric === "mm") {
        inputInMm = num;
    } else if(inputMetric === "cm") {
        inputInMm = num * 10;
    } else {
        inputInMm = num * 1000;
    }

    if(outputMetric === "mm") {
        output = inputInMm;
        
    } else if(outputMetric === "cm") {
        output = inputInMm / 10;
        
    } else {
        output = inputInMm / 1000;
    }

    console.log(output.toFixed(3));

    

}
metricConverter(["150","m","cm"])

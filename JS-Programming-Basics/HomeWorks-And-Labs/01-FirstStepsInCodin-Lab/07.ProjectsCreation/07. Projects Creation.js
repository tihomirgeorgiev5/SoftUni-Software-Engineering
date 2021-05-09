function concatenateData(input) {
    let name = input[0];
    let numOfProjects = input[1];

    let projectTime = 3;
    let neededTime = numOfProjects * projectTime;
    
    console.log(`The architect ${name} will need ${neededTime} hours to complete ${numOfProjects} project/s.`);
    }
    concatenateData (["George", "4"]);
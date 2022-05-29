/*function carFactory(input) {

    let result = {};
    let engine = {};
    let carriage = {};
    
    result.model = input.model;

    if (input.power <= 90) {
        engine.power = 90;
        engine.volume = 1800;

    } else if (input.power <= 120) {
        engine.power = 120;
        engine.volume = 2400;
        
    } else if (input.power <= 200) {
        engine.power = 200;
        engine.volume = 3500;   
    }

    carriage.type = input.carriage;
    carriage.color = input.color;

    if (input.wheelsize % 2 === 0) {
        input.wheelsize --;
    }
    result.engine = engine;
    result.carriage = carriage;

     result.wheels = [input.wheelsize,input.wheelsize,input.wheelsize,input.wheelsize];
    
     return result;
   
}*/
function carFactory(input) {
    const {
        model,
        power,
        carriage,
        type,
        color,
        wheelsize,
    } = input;
    function getEngine(power) {
        const engines = [
            { power: 90, volume: 1800 },
            { power: 120, volume: 2400 },
            { power: 200, volume: 3500 },
        ].sort((a, b) => a.power - b.power);
        let result;
        /* for (let i = 0; i < engines.length; i++) {
             if (engines[i].power >= power) {
                 result = engines[i];
                 break;
             }
             
         }*/
        return engines.find(el => el.power >= power);
    }

    function getCarriage(type, color) {
        return {
            type : carriage,
            color,
        };
    }

    function getWheels(wheelsize) {
        let wheel =
            wheelsize % 2 == 0 
            ? wheelsize - 1 
            : wheelsize;

            return [wheel, wheel, wheel, wheel];
    }
    return {
        model,
        engine: getEngine(power),
        carriage: getCarriage(type,color),
        wheels: getWheels(wheelsize),
    }
}

console.log(carFactory({
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
}));

console.log('-----');

console.log(carFactory({
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17
}));
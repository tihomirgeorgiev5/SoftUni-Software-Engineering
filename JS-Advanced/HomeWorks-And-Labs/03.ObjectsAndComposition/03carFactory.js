function carFactory(input) {

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
   
}
console.log(carFactory({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 })); 

console.log('-----');

console.log(carFactory({ model: 'Opel Vectra',
power: 110,
color: 'grey',
carriage: 'coupe',
wheelsize: 17 }));
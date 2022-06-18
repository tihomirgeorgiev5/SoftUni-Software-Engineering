function solve(arr) {
    const cars = {};

    for (const car of arr) {
        const [brand, model, quantity] = car.split(' | ');
        if (!cars.hasOwnProperty(brand)) {
            cars[brand] = {};
        }

        if (!cars[brand].hasOwnProperty(model)) {
            cars[brand][model] = 0;
        }

        cars[brand][model] += Number(quantity);
    }

    for (const [brand,models] of Object.entries(cars)) {
        console.log(brand);

        for (const [model, quantity] of Object.entries(models)) {
            console.log(`###${model} -> ${quantity}`);
        }
    }

    
}
solve(['Audi | Q7 | 1000',
'Audi | Q6 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10']);
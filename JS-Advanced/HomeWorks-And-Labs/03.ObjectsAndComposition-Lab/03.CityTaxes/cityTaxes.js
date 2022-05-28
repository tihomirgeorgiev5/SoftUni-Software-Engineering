function cityTaxes(name, population, treasury) {
    const result = {
        name,
        population,
        treasury,
        taxRate: 10,
        collectTaxes() {
            this.treasury += Math.floor(this.population * this.taxRate); 
        },
        applyGrowth(percent) {
            this.population += Math.floor(this.population * (percent / 100));
         },
        applyRecession(percent) {
            this.treasury -= Math.floor(this.treasury *(percent / 100));
         },

    };
    return result;


}
const city = cityTaxes('Tortuga', 7000, 15000);

const asString = JSON.stringify(city);

console.log(asString); // {"name":"Tortuga","population":7000,"treasury":15000,"taxRate":10}

const cityFromString = '{"name":"Tortuga","population":7000,"treasury":15000,"taxRate":10}';
const parsed = JSON.parse(cityFromString);
console.log(parsed); // {name: 'Tortuga', population: 7000, treasury: 15000, taxRate: 10}
console.log(`${parsed.name} => ${parsed.population}`);
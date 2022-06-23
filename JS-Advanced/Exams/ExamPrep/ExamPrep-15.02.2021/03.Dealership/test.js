const { assert } = require('chai');
const dealership = require('./dealership');

describe('dealership tests', () => {

    it('New CarCost', () => {

        assert.equal(dealership.newCarCost('Audi A6 4K', 100000),80000 );
    });

    it('carEquipment',() => {
        assert.deepEqual(dealership.carEquipment(
            ['a', 'f', 'z', 'r'], [0, 2, 3]), ['a', 'z', 'r']);  
    });
    it('euroCategory', ()=> {
        assert.equal(dealership.euroCategory(3),(
            'Your euro category is low, so there is no discount from the final price!'
        ));
        assert.equal(dealership.euroCategory(4),(
            `We have added 5% discount to the final price: 28500.`
        ));
    })

})
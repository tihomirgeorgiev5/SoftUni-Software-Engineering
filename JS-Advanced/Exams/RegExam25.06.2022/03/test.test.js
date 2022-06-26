const {expect} = require('chai');
const {carService} = require('./03.solution');

describe('carServise tests', () => {
    describe('isItExpensive', ()=> {
       
        it('check values of parameter', ()=> {
            expect(carService.isItExpensive()).is.equal(`The overall price will be a bit cheaper`);
            // expect(carService.isItExpensive(input)).is.equal("Engine");

        });
    });

    describe('discount', ()=> {
        it('check prices', ()=> {
            expect(typeof(carService.discount).is.deep.equal("number"));
        })
    })
})

const sum = require('./04.SumNumbers');
const { expect } = require('chai');

//Take an array of numbers as argument
//Return the sum of the values of all elements inside the array


describe('Sum numbers', () => {
    it('sums single number', () => {
        expect(sum([1])).to.equal(1);
    })

    it('sums multiple numbers', () => {
        expect(sum([1,1])).to.equal(2);
    })

})
const { isOddOrEven } = require('./oddEven');
const { expect } = require('chai');

// unit tests for a function isOddOrEven() 

describe('isOddOrEven function test', () => {
    // If the passed parameter is NOT a string return undefined.
    it('should return undefined if parameter is number', () => {
        expect(typeof isOddOrEven('ab')).to.equal('string');
    });

    // that checks whether the length of a passed string is even or odd.
    it('should return even', () => {
        expect(isOddOrEven('ab')).to.equal('even');
    });

    it('should return odd', () => {
        expect(isOddOrEven('abc')).to.equal('odd');
    });

    it('should return undefined if parameter is number', () => {
        expect(isOddOrEven(10)).to.be.undefined;
    });

    it('should return undefined if parameter is undefined', ()=> {
        expect(isOddOrEven(undefined)).to.be.undefined;
    });

    it('should return undefined if parameter is object', ()=> {
        expect(isOddOrEven({})).to.be.undefined;
    });

    it('should return undefined if parameter is array', ()=> {
        expect(isOddOrEven([])).to.be.undefined;
    });
});
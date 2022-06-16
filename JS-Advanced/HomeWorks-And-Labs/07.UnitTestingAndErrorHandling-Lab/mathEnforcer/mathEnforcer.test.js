const { expect } = require('chai');
const { mathEnforcer } = require('./mathEnforcer');

describe('mathEnforcer object tests', () => {
    describe('addFive', () => {
        // ⦁If the parameter is NOT a number, the function should return undefined.
        const expected = undefined;

        it('should return undefined with string parameter', () => {
            expect(mathEnforcer.addFive('')).to.equal(expected);  
        });
        it('should return undefined with array parameter', () => {
            expect(mathEnforcer.addFive([])).to.equal(expected);  
        });
        it('should return undefined with object parameter', () => {
            expect(mathEnforcer.addFive({})).to.equal(expected);  
        });
        it('should return undefined with null like parameter', () => {
            expect(mathEnforcer.addFive(null)).to.equal(expected);  
        });
        it('should return undefined with undefined parameter', () => {
            expect(mathEnforcer.addFive(undefined)).to.equal(expected);  
        });

        // ⦁If the parameter is a number, add 5 to it, and return the result.
        it('added positive numbers as input', () => {
            expect(mathEnforcer.addFive(6)).to.equal(11);        
        });
        it('added negative numbers as input', () => {
            expect(mathEnforcer.addFive(-2)).to.equal(3);        
        });
        it('added floating-point numbers as input', () => {
            expect(mathEnforcer.addFive(5.5)).to.equal(10.5);        
        });

    });

    describe('subtractTen', () => {
        // ⦁If the parameter is NOT a number, the function should return undefined.
        const expected = undefined;

        it('should return undefined with string parameter', () => {
            expect(mathEnforcer.subtractTen('')).to.equal(expected);  
        });
        it('should return undefined with array parameter', () => {
            expect(mathEnforcer.subtractTen([])).to.equal(expected);  
        });
        it('should return undefined with object parameter', () => {
            expect(mathEnforcer.subtractTen({})).to.equal(expected);  
        });
        it('should return undefined with null like parameter', () => {
            expect(mathEnforcer.subtractTen(null)).to.equal(expected);  
        });
        it('should return undefined with undefined parameter', () => {
            expect(mathEnforcer.subtractTen(undefined)).to.equal(expected);  
        });

        // ⦁If the parameter is a number, subtract 10 from it, and return the result.
        it('added positive numbers as input', () => {
            expect(mathEnforcer.subtractTen(16)).to.equal(6);        
        });
        it('added negative numbers as input', () => {
            expect(mathEnforcer.subtractTen(-2)).to.equal(-12);        
        });
        it('added floating-point numbers as input', () => {
            expect(mathEnforcer.subtractTen(12.5)).to.equal(2.5);        
        });


        describe('sum', () => {

            // ⦁If any of the 2 parameters is NOT a number, the function should return undefined.
            const expected = undefined;
            it('should return undefined when first parameter is not number', () => {              
                expect(mathEnforcer.sum('',3)).to.equal(expected);
            });

            it('should return undefined when second parameter is not number', () => {              
                expect(mathEnforcer.sum(3,'')).to.equal(expected);
            });

            // ⦁If both parameters are numbers, the function should return their sum. 

            it('should return sum from  two positive numbers', () => {              
                expect(mathEnforcer.sum(3,3)).to.equal(6);
            });
            it('should return sum from two negative numbers', () => {              
                expect(mathEnforcer.sum(-3,-3)).to.equal(-6);
            });
            it('should return sum from two float-point numbers', () => {              
                expect(mathEnforcer.sum(3.3,3.3)).to.equal(6.6);
            });
        });

    });
});
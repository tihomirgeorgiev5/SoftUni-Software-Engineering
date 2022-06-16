const { expect } = require('chai');
const { lookupChar } = require('./charLookup');

describe('lookupchar function tests', () => {

    // ⦁	Returning the char at the specified index

    it('return the char at the specified index', () => {
        expect(lookupChar('abc',0)).to.equal('a');
    });

    // ⦁	Returning an "Incorrect index"

    // string.length <= index || index < 0
    it('index over the stringLength', () => {
        expect(lookupChar('abc',3)).to.equal('Incorrect index');
    });

    // ⦁	Returning an "Incorrect index"
    it('negative index', () => {
        expect(lookupChar('abc', -1)).to.equal('Incorrect index');
    });

    // ⦁	Returning an "Incorrect index"
    it('empty string as input', () => {
        expect(lookupChar('', 0)).to.equal('Incorrect index');
    });



    // ⦁	Returning undefined
    it('incorrect string parameter', () => {
        expect(lookupChar(10,4)).to.be.undefined;
    });

    it('incorrect number parameter', () => {
        expect(lookupChar('abc','a')).to.be.undefined;
    });   
    
    it('incorrect number parameter', () => {
        expect(lookupChar('abc',12.3)).to.be.undefined;
    });  

    // added testing

    it('return character at wrong index', () => {
        expect(lookupChar('abc',1)).to.equal('b');
    }); 
});
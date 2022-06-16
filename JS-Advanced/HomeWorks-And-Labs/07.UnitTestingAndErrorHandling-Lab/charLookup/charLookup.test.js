const { expect } = require('chai');
const { lookupChar } = require('./charLookup');

describe('lookupchar function tests', () => {

    // // ⦁	Returning the char at the specified index

    // it('return the char at the specified index', () => {
    //     expect(lookupChar('abc',0)).to.equal('a');
    // });

    // // ⦁	Returning an "Incorrect index"

    // // string.length <= index || index < 0
    // it('index over the stringLength', () => {
    //     expect(lookupChar('abc',3)).to.equal('Incorrect index');
    // });

    // // ⦁	Returning an "Incorrect index"
    // it('negative index', () => {
    //     expect(lookupChar('abc', -1)).to.equal('Incorrect index');
    // });

    // // ⦁	Returning an "Incorrect index"
    // it('empty string as input', () => {
    //     expect(lookupChar('', 0)).to.equal('Incorrect index');
    // });



    // // ⦁	Returning undefined
    // it('incorrect string parameter', () => {
    //     expect(lookupChar(10,4)).to.be.undefined;
    // });

    // it('incorrect number parameter', () => {
    //     expect(lookupChar('abc','a')).to.be.undefined;
    // });   
    
    // it('incorrect number parameter', () => {
    //     expect(lookupChar('abc',12.3)).to.be.undefined;
    // });  

    // // added testing

    // it('return character at wrong index', () => {
    //     expect(lookupChar('abc',1)).to.equal('b');
    // }); 

    it('should return undefined when the first input is not a string', () => {
        //arrange phase
        let expected = undefined;
        //assert and act phase
        expect(lookupChar(0, 0)).to.equal(expected);
        expect(lookupChar(undefined, 0)).to.equal(expected);
        expect(lookupChar(null, 0)).to.equal(expected);
        expect(lookupChar([], 0)).to.equal(expected);
        expect(lookupChar({}, 0)).to.equal(expected);
    })
    it('should return undefined when the second input is not an intiger', () => {
        //arrange phase
        let expected = undefined;
        //assert  and act phase
        expect(lookupChar('hello', "1")).to.equal(expected);
        expect(lookupChar('hello', [])).to.equal(expected);
        expect(lookupChar('hello', {})).to.equal(expected);
        expect(lookupChar('hello', null)).to.equal(expected);
        expect(lookupChar('hello', 4.4)).to.equal(expected);
        expect(lookupChar('hello', '')).to.equal(expected);
 
    })
 
    it('should return "Incorrect Index" if the second param is out of range to the strings length', () => {
        //arrange phase
        let expected = "Incorrect index";
        //assert and act phase
        expect(lookupChar('hello', -1)).to.equal(expected);
        expect(lookupChar('hello', 5)).to.equal(expected);
        expect(lookupChar('hello', 100)).to.equal(expected);
        expect(lookupChar('hello', -100)).to.equal(expected);
        expect(lookupChar('', 0)).to.equal(expected);
 
    })
 
    it('should return the char of the string at the given index - happy case', () => {
        //assert  and act phase
        expect(lookupChar('hello', 0)).to.equal('h');
        expect(lookupChar('hello', 4)).to.equal('o');
        expect(lookupChar('hello', 3)).to.equal('l');
    })
});
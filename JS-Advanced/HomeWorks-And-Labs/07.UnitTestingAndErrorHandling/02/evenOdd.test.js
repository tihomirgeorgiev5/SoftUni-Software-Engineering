const { assert} = require('chai');
const isOddOrEven = require('./evenOdd.js');

describe('isOddOrEven', () => {

    it('works', () => {
        assert.equal(isOddOrEven(10), undefined);

    });
});
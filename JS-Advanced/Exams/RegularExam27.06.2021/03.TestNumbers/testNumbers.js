const testNumbers = {
    sumNumbers: function (num1, num2) {
        let sum = 0;

        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        } else {
            sum = (num1 + num2).toFixed(2);
            return sum
        }
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input % 2 === 0) {
            return 'The number is even!';
        } else {
            return 'The number is odd!';
        }

    },
    averageSumArray: function (arr) {

        let arraySum = 0;

        for (let i = 0; i < arr.length; i++) {
            arraySum += arr[i]
        }

        return arraySum / arr.length
    }
};

describe("testNumbers …", function () {
    describe("sumNumbers …", function () {
        it("sumNumbers throw error …", function () {
            expect(testNumbers.sumNumbers('gdf', 1)).to.equal(undefined);
            expect(testNumbers.sumNumbers('1', 'gfg')).to.equal(undefined);
            expect(testNumbers.sumNumbers(1, 'gfg')).to.equal(undefined);
 
        });
 
        it("sumNumbers return result …", function () {
            expect(testNumbers.sumNumbers(1, 1)).to.equal('2.00');
            expect(testNumbers.sumNumbers(2.5, 2.5)).to.equal('5.00');
            expect(testNumbers.sumNumbers(1, 1, 435455)).to.equal('2.00');
        });
 
        describe("numberChecker …", function () {
            it("numberChecker throw error …", function () {
                assert.throw(() => testNumbers.numberChecker("fkd"), Error, "The input is not a number!");
                assert.throw(() => testNumbers.numberChecker(undefined), Error, "The input is not a number!");
                assert.throw(() => testNumbers.numberChecker("456fdg"), Error, "The input is not a number!");
 
            });
 
            it("numberChecker return result …", function () {
                assert.strictEqual(testNumbers.numberChecker("4"), "The number is even!");
                assert.strictEqual(testNumbers.numberChecker("1"), "The number is odd!");
                assert.strictEqual(testNumbers.numberChecker("12"), "The number is even!");
                assert.strictEqual(testNumbers.numberChecker("231"), "The number is odd!");
            });
        });
 
        describe("averageSumArray …", function () {
            it("averageSumArray  should work …", function () {
               
                expect(testNumbers.sumNumbers('3')).to.equal(undefined);
                assert.deepEqual(testNumbers.averageSumArray([1,2,3],[]), 2);
                assert.strictEqual(testNumbers.averageSumArray([1],[2]), 1);
                assert.deepEqual(testNumbers.averageSumArray(['d','r','a'],['a','b','cd']), NaN);
 
            });
 
        });
    });
});




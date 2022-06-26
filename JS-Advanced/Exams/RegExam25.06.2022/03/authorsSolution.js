describe('carService', () => {
    describe('isItExpensive', () => {
      it('issue is equal to "Engine"', () => {
        expect(carService.isItExpensive('Engine')).to.equal(
          'The issue with the car is more severe and it will cost more money'
        );
      });
      it('issue is equal to "Transmission"', () => {
        expect(carService.isItExpensive('Transmission')).to.equal(
          'The issue with the car is more severe and it will cost more money'
        );
      });
      it('issue is not equal to "Transmission" or "Engine"', () => {
        expect(carService.isItExpensive('test')).to.equal('The overall price will be a bit cheaper');
      });
    });
    describe('discount', () => {
      it('Invalid input', () => {
        expect(() => carService.discount('1', 1)).to.throw('Invalid input');
        expect(() => carService.discount(1, '1')).to.throw('Invalid input');
        expect(() => carService.discount('1', '1')).to.throw('Invalid input');
      });
   
      it('numberOfParts is smaller than 2', () => {
        expect(carService.discount(1, 1)).to.equal('You cannot apply a discount');
      });
      it('numberOfParts is equal to 2', () => {
        expect(carService.discount(2, 1)).to.equal('You cannot apply a discount');
      });
      it('numberOfParts is between 3 - 7', () => {
        expect(carService.discount(5, 1)).to.equal('Discount applied! You saved 0.15$');
      });
      it('numberOfParts is equal to 7', () => {
        expect(carService.discount(7, 1)).to.equal('Discount applied! You saved 0.15$');
      });
      it('numberOfParts is bigger than 7', () => {
        expect(carService.discount(8, 10)).to.equal('Discount applied! You saved 3$');
      });
    });
    describe('partsToBuy', () => {
      it('Invalid input', () => {
        expect(() => carService.partsToBuy(['1'], 1)).to.throw('Invalid input');
        expect(() => carService.partsToBuy(1, ['1'])).to.throw('Invalid input');
        expect(() => carService.partsToBuy(1, '1')).to.throw('Invalid input');
      });
      it('valid inputs', () => {
        const partsCatalog = [
          { part: 'test_1', price: 145 },
          { part: 'test_2', price: 5 },
          { part: 'test_3', price: 115 },
        ];
        const neededParts = ['test_1', 'test_2'];
        expect(carService.partsToBuy(partsCatalog, neededParts)).to.equal(150);
      });
      it('valid inputs', () => {
        const partsCatalog = [
          { part: 'test_1', price: 145 },
          { part: 'test_2', price: 5 },
          { part: 'test_3', price: 115 },
        ];
        const neededParts = ['test_11', 'test_22'];
        expect(carService.partsToBuy(partsCatalog, neededParts)).to.equal(0);
      });
      it('valid inputs', () => {
        const partsCatalog = [
          { part: 'test_1', price: 145 },
          { part: 'test_2', price: 5 },
          { part: 'test_3', price: 115 },
        ];
        const neededParts = [];
        expect(carService.partsToBuy(partsCatalog, neededParts)).to.equal(0);
      });
    });
  });
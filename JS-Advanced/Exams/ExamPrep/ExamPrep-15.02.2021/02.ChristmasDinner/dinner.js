class ChristmasDinner {
    constructor(budget) {
        this.budget = budget,
        this.dishes = [];
        this.products = [];
        this.guests = {};
    }

    get budget() {
        return this._budget;
    }

    set budget(value) {
        if (value < 0) {
            throw new Error("The budget cannot be a negative number");
        }
        return this._budget = value;
    }

    shopping(product) {
        let [type, price] = product;

        if (this._budget < price) {
            throw new Error("Not enough money to buy this product");
        } else {
            this.products.push(type);
            this._budget -= price;
            return `You have successfully bought ${type}!`
        }
    }

    recipes(recipe) {
        // { 
        //     recipeName: string,
        //  productsList: [string] }

        const recipeName = recipe.recipeName;
        const productsList = recipe.productsList;

        productsList.forEach((el) => {
            if (!this.products.includes(el)) {
                throw new Error("We do not have this product")
            }
        });

        this.dishes.push({ recipeName, productsList } );
        return `${recipeName} has been successfully cooked!`;
    }

    inviteGuests(name, dish) {
        if (!this.dishes.values(dish)) {
            throw new Error("We do not have this dish");
        }
        if (this.guests[name]) {
            throw new Error("This guest has already been invited");
        }

        this.guests[name] = dish;
        return `You have successfully invited ${name}!`
    }

    showAttendance() {
        let result = [];
        for (const name in this.guests) {
            let dish = this.guests[name];
            let products = this.dishes.find((el) => el.recipeName == dish)
            result.push(`${name} will eat ${dish}, which consists of ${products.productsList.join(', ')}`);
        }
        return result.join('\n').trimEnd();
    }

}

let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());


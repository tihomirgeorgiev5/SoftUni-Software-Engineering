class Restaurant {
    constructor(budget) {
      this.budgetMoney = budget;
      this.menu = {};
      this.stockProducts = {};
      this.history = [];
    }
    loadProducts(products) {
      products.forEach(product => {
        const tokens = product.split(' ');
        const productName = tokens[0];
        const productQuantity = Number(tokens[1]);
        const productTotalPrice = Number(tokens[2]);
        if (productTotalPrice <= this.budgetMoney) {
          if (!Object.keys(this.stockProducts).includes(productName)) {
            this.stockProducts[productName] = 0;
          }
          this.stockProducts[productName] += productQuantity;
          this.history.push(`Successfully loaded ${productQuantity} ${productName}`);
          this.budgetMoney -= productTotalPrice;
        } else { this.history.push(`There was not enough money to load ${productQuantity} ${productName}`); }
      });
   
      return this.history.join('\n');
    }
    addToMenu(meal, neededProducts, price) {
      if (!Object.keys(this.menu).includes(meal)) {
        const products = {};
        neededProducts.forEach(info => {
          let [productName, quantity] = info.split(' ');
          quantity = Number(quantity);
          products[productName] = quantity;
        });
        this.menu[meal] = { products: products, price: price };
      } else { return `The ${meal} is already in the our menu, try something different.`; }
   
      if (Object.keys(this.menu).length == 1) {
        return `Great idea! Now with the ${meal} we have 1 meal in the menu, other ideas?`;
      } else { return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meals in the menu, other ideas?`; }
    }
   
    makeTheOrder(meal) {
      if (!Object.keys(this.menu).includes(meal)) {
        return `There is not ${meal} yet in our menu, do you want to order something else?`;
      } else {
        const stocks = Object.keys(this.stockProducts);
        const { products, price } = this.menu[meal];
        for (let product of Object.keys(products)) {
          const haveProduct = stocks.includes(product);
          const haveEnough = products[product] <= this.stockProducts[product];
          if (!haveProduct || !haveEnough) { return `For the time being, we cannot complete your order (${meal}), we are very sorry...`; }
        }
        for (const product in products) {
          this.stockProducts[product] -= products[product];
        }
        this.budgetMoney += price;
        return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${price}.`;
      }
    }
   
    showTheMenu() {
      if (Object.keys(this.menu).length === 0) {
        return 'Our menu is not ready yet, please come later...';
      }
      const meals = [];
      for (const meal in this.menu) {
        meals.push(`${meal} - $ ${this.menu[meal].price}`);
      }
      return meals.join('\n');
    }
   
  }
   
  let kitchen = new Restaurant(1000);
  console.log(kitchen.loadProducts(['Banana 10 5', 'Banana 20 10', 'Strawberries 50 30', 'Yogurt 10 10', 'Yogurt 500 1500', 'Honey 5 50']));
   
  console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
  console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));
  console.log(kitchen.showTheMenu());
   
function solve(input) {
    let products = [];

    while (input.length) {
        let productsData = input.shift().split(' | ');
        let [town, product, price] = productsData;

        if (products.filter(x => x.product === product).length > 0) {
            
            let obj = products.find(x => x.product === product);

            if (obj.price > Number(price)) {
                obj.price = Number(price);
                obj.town = town;
            }
        } else {
            let obj = {town, product, price:Number(price)};
            products.push(obj);
        }
    }
    for (const product of products) {
        console.log(`${product.product} -> ${product.price} (${product.town})`);
    }
 
    

}
console.log(solve([
'Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10'
]));
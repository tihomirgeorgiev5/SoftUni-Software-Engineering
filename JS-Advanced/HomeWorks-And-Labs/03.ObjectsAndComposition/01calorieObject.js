function calorieObject(input) {
    let result = {};

    for (let i = 0; i < input.length; i+=2) {
        let food = input[i];
        let calorie = Number(input[i+1]);
        result[food] = calorie;
        
        
    }
 
    console.log(result);
}
calorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
calorieObject(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);
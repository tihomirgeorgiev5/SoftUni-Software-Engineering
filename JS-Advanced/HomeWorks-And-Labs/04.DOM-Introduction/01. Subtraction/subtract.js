function subtract() {
    let firstNum = document.getElementById('firstNumber');
    let secondNum = document.getElementById('secondNumber');

    const firstParsedNum = Number(firstNum.value);
    const secondParsedNum = Number(secondNum.value);

    let subtract = firstParsedNum - secondParsedNum;

    document.getElementById('result').textContent = subtract;

    

    console.log(subtract);
}
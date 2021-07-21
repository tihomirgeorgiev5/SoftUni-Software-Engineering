function calc() {
    const numOne = Number(document.getElementById('num1').value);
    const numTwo = Number(document.getElementById('num2').value);

    const result = numOne + numTwo;
    document.getElementById('sum').value = result;
}

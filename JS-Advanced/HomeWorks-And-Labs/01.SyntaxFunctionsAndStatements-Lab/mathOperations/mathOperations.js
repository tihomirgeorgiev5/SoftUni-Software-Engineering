function solve(num1, num2, string) {
  let result = 0;
  
  switch (string) {
      case '+': result = num1+num2;break;
      case '-': result = num1-num2;break;
      case '/': result = num1/num2;break;
      case '*': result = num1*num2;break;
      case '%': result = num1%num2;break;
      case '**': result = num1**num2;break;
  }
  console.log(result);

}

function mathOper(num1, num2, string) {
  let result;
  switch (string) {
    case '+':
      result = num1 + num2;
      break;
      case '-':
      result = num1 - num2;
      break;
      case '/':
      result = num1 / num2;
      break;
      case '*':
      result = num1 * num2;
      break;
      case '%':
      result = num1 % num2;
      break;
      case '**':
      result = num1 ** num2;
      break;
  
    default:
      break;
  }
  console.log(result)
}
mathOper(5, 6, '+')
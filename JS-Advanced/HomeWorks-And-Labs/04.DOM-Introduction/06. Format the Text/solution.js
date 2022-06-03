function solve() {
  const input = document.getElementById('input').value;
  const textArr = input.split('.').filter(s => s !== '');
  const result = document.getElementById('output');

  while (textArr.length > 0) {
    const text = textArr.splice(0, 3).join('. ')+ '.';
    const p = document.createElement('p');
    p.textContent = text;
    result.appendChild(p);
  }
}
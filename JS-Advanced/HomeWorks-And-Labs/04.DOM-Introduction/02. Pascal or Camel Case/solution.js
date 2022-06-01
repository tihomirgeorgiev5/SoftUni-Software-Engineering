function solve() {
  let text = document.getElementById('text').value;
  let convention = document.getElementById('naming-convention').value;
  let result = '';


  if (convention === 'Camel Case') {
    for (let i = 0; i < text.length; i++) {
      if (text[i] === ' ') {
        result += text[i + 1].toUpperCase();
        i++;
      } else {
        result += text[i].toLowerCase();
      }

    }

  } else if (convention === 'Pascal Case') {
    result += text[0].toUpperCase();
    for (let j = 1; j < text.length; j++) {
      if (text[j] === ' ') {
        result += text[j + 1].toUpperCase();
        j++;
      } else {
        result += text[j].toLowerCase();
      }

    }
  } else {
    result += 'Error!'
  };

  document.getElementById('result').textContent = result;


}
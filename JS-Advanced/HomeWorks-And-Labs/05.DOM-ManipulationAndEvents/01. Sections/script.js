function create(words) {
   const result = document.getElementById('content');


   for (const word of words) {
      const p = document.createElement('p');
      const div = document.createElement('div');
      const text = document.createTextNode(word);
      p.appendChild(text);
      p.style.display = 'none';
      div.appendChild(p);
      div.addEventListener('click', onClick);
      result.appendChild(div);
   }
   
   function onClick(ev) {
     ev.target.children[0].style.display = 'block';
   }
  
}
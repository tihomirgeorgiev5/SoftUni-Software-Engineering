function create(words) {
   const content = document.getElementById('content');
   console.log(content);

   for (const str of words) {
      const divElement = document.createElement('div');
      const paragraph = document.createElement('p');
      paragraph.textContent = str;
      paragraph.style.display = 'none';
      divElement.appendChild(paragraph);
    
      content.appendChild(divElement);
      divElement.addEventListener('click', onClick);

      
   }
   function onClick (event) {
      event.target.children[0].style.display = 'block';
   }
}
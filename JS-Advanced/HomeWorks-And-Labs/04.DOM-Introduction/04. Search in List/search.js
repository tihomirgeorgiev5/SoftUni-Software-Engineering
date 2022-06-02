function search() {
   const searchText = document.getElementById('searchText').value;
   const result = document.getElementById('result');

   const towns = Array.from(document.querySelectorAll('#towns li'));
   let count = 0;
 

   for (const town of towns) {
      if (town.textContent.includes(searchText)) {
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
         count ++;
      } else {
         town.style.fontWeight = 'normal';
         town.style.textDecoration = 'none';
      }
   }

   result.textContent = `${count} matches found`;
    
}

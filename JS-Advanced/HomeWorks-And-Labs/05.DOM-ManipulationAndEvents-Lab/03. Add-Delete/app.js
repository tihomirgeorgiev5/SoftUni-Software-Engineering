function addItem() {
    //select input field and read its value

    const input = document.getElementById('newItemText');
    // create <li> element and assign input value to element text content
    const liElement = document.createElement('li');
    liElement.textContent = input.value;

    // create [Delete] anchor 
    const deleteBtn = document.createElement('a');
    deleteBtn.textContent = '[Delete]';
    deleteBtn.href = '#';
    liElement.appendChild(deleteBtn);
    deleteBtn.addEventListener('click', onDelete)

    // select <ul> and append new element
    document.getElementById('items').appendChild(liElement);
    // select input field and clear contents (value)
    input.value = '';
    function onDelete(event) {
        event.target.parentElement.remove();
    } 
}
//function onDelete(event) {
    //event.target.parentElement.remove();
//} 
function addItem() {
    //<input type="text" id="newItemText" />
    const input = document.getElementById('newItemText');
    const liElement = createElement('li', input.value);
    //<ul id="items">

    const deleteBtn = createElement('a', '[Delete]');
    deleteBtn.href = '#';
    deleteBtn.addEventListener('click', (ev) => {
        ev.target.parentNode.remove();
    });
    liElement.appendChild(deleteBtn);

    document.getElementById('items').appendChild(liElement);
    input.value = '';
        
    function createElement(type, context) {
        const element = document.createElement(type);
        element.textContent = context;
        return element;
    }
}
/*function addItem() {
    let inputElement = document.getElementById('newItemText');
    let ulElement = document.getElementById('items');
    let liElement = document.createElement('li');
    liElement.textContent = inputElement.value;
    let deleteLnk = document.createElement('a');
    deleteLnk.textContent = '[Delete]';
    deleteLnk.href = '#';
    liElement.appendChild(deleteLnk);
    ulElement.appendChild(liElement);
    inputElement.value = '';
    deleteLnk.addEventListener('click', onClick);

    function onClick(event){
        event.target.parentNode.remove();
    }

}
*/

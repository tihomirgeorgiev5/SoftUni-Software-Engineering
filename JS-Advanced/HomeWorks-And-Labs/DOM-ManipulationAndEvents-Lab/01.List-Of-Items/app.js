function addItem() {
    //<input type="text" id="newItemText" />
    //<ul id="items">

    const text = document.getElementById('newItemText').value;

    const liElement = document.createElement('li');
    liElement.textContent = text;
    const list = document.getElementById('items');
    list.appendChild(liElement);

}
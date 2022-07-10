const list = document.getElementById('list');
const input = document.getElementById('product');
document.getElementById('createBtn').addEventListener('click', postData);
document.getElementById('refreshBtn').addEventListener('click', getData);
const url = 'http://localhost:3030/jsonstore/demo';

async function getData() {

    const res = await fetch(url);
    const data = await res.json();

    list.replaceChildren(...Object.values(data).map(createListItem));

}

async function postData() {
    const product = input.value;

    const data = {
        name: product
    };

    const res = await fetch(url, {
        method: 'post',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    });

    const resData = await res.json();

    list.appendChild(createListItem(resData));


}
async function deleteData(id, element) {
    const res = await fetch('http://localhost:3030/jsonstore/demo/' + id, {
        method: 'delete'
    });

    console.log(res);

    element.remove();

}

function createListItem(record) {
    const element = document.createElement('li');
    element.textContent = record.name;

    const deleteBtn = document.createElement('button');
    deleteBtn.textContent = 'Delete';
    deleteBtn.addEventListener('click', () => deleteData(record._id, element));

    element.appendChild(deleteBtn);
    return element;

}
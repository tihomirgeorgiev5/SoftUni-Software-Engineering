const url = 'http://localhost:3030/jsonstore/messenger';
const messages = document.getElementById('messages');
function attachEvents() {

    document.getElementById('submit').addEventListener('click', onSubmit);
    document.getElementById('refresh').addEventListener('click', onRefresh);

}

async function onSubmit() {
    const [author, content] = [document.querySelector('[name="author"]'),
    document.querySelector('[name="content"]')];

    if (author.value != '' || content.value != '') {
        await request(url, {
            author: author.value,
            content: content.value
        });
        author.value = '';
        content.value = '';
        
    }

}

async function onRefresh() {
    const res = await fetch(url);
    const data = await res.json();
    messages.value = Object.values(data).map(({ author, content }) => `${author}: ${content}`).join('\n');
}

async function request(url, option) {

    if (option) {
        option = {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(option)
        };
    }
    const response = await fetch(url, option);

    return response.json();

}

attachEvents();
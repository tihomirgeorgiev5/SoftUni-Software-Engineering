import { showDetails } from './details.js';

const section = document.getElementById('homeView');
section.querySelector('div.topic-title').addEventListener('click', showDetails);

const form = section.querySelector('form');
form.addEventListener('submit', onSubmit);

section.querySelector('[name="cancel"]').addEventListener('click', clearForm);

section.remove();

export async function showHome(ev) {
    ev?.preventDefault();

    document.getElementById('main').replaceChildren('Loading...');

    const res = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts');
    const posts = await res.json();
    console.log(posts);
    document.getElementById('main').replaceChildren(section);
}

async function onSubmit(ev) {
    ev.preventDefault();
    const formData = new FormData(form);

    console.log(...formData.entries());
    const title = formData.get('topicName');
    const username = formData.get('username');
    const content = formData.get('postText');

    try {
        const res = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                title,
                username,
                content,
                dateCreated: new Date()
            })
        }); 

        if (res.ok == false) {
            const error = await res.json();
            throw new Error(error.message);
        }
        form.reset();
        showHome();
    } catch (error) {
        alert(error.message)
    }
}

function clearForm() {
    form.reset();
}
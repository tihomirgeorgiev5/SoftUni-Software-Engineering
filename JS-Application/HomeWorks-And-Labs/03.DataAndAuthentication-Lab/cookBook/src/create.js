document.querySelector('form').addEventListener('submit', onSubmit);

async function onSubmit(ev) {
    ev.preventDefault();

    const formData = new FormData(ev.target);

    const name = formData.get('name').trim();
    const img = formData.get('img').trim();
    const ingred = formData.get('ingredients').trim().split('\n');
    const steps = formData.get('steps').trim().split('\n'); 

    const recipe = {
        name,
        img,
        ingred,
        steps
    };

    const token = sessionStorage.getItem('accessToken');
    if (token == null) {
        alert('Please login!');
        window.location = '/login.html';
        return;
    }

    try {
        const response = await fetch('http://localhost:3030/data/recipes', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json',
                'X-Authorization': token
            },
            body: JSON.stringify(recipe)
        });

        if (response.ok == false ) {
            const error = await response.json();
            throw new Error(error.message);
        }

        window.location = '/';
        
    } catch (error) {
        alert(error.message);
    }


}
document.querySelector('form').addEventListener('submit', onSubmit);

async function onSubmit(ev) {
    ev.preventDefault();

    const formData = new FormData(ev.target);

    const email = formData.get('email');
    const password = formData.get('password');
    const repass =  formData.get('rePass');

    try {
        if (email == '' || password == '') {
            throw new Error('All fields are required!');
        }
        if (password != repass) {
            throw new Error('Password don\'t match!');
        }

        const response = await fetch('http://localhost:3030/users/register', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                email,
                password
            })
        });

        if (response.ok == false) {
            const error = await response.json();
            throw Error(error.message);
        }

        const data = await response.json();

        sessionStorage.setItem('accessToken', data.accessToken);

        window.location = '/';

    } catch (error) {
        alert(error.message);
    }

}
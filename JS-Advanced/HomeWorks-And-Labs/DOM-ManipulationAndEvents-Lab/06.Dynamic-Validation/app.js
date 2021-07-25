function validate() {
    const regex = /[a-z]+@[a-z]+\.[a-z]+/;
    const input = document.getElementById('email');
    input.addEventListener('change', onChange);

    function onChange(ev) {
        if (!ev.target.value.match(regex)) {
            ev.target.className = 'error';
        } else {
            ev.target.className = '';
        }
    }
}
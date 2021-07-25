function focused() {
    const inputElements = document.querySelectorAll('input[type="text"]');
    for (const input of inputElements) {
        input.addEventListener('focus', onFocus);
        input.addEventListener('blur', onBlur);
    }
        
    

    function onFocus(ev) {
        ev.target.parentNode.className = 'focused';
    }

    function onBlur(ev) {
        ev.target.parentNode.className = '';
    }
}
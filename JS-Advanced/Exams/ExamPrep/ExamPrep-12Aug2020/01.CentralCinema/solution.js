function solve() {
    const container = document.getElementById('container');
    const [name, hall, ticketPrice] = Array.from(container.querySelectorAll('input'));
    const onScreenBtn = container.querySelector('button');
    onScreenBtn.addEventListener('click', onScreen);
    const movies = document.querySelector('section>ul');
    const archive = document.querySelector('#archive>ul');

    function onScreen(e) {
        e.preventDefault();
        let [nameValue, hallValue, tickPriceValue] =
            [name, hall, ticketPrice].map((el) => el.value);

        if (!isValid(nameValue, hallValue, tickPriceValue)) {
            return;
        }

        const liElement = createElement('li');
        const span = createElement('span', nameValue);
        const strongHall = createElement('strong', `Hall: ${hallValue}`);
        const div = createElement('div');
        const strongDiv = createElement('strong', Number(ticketPrice).toFixed(2));
        const inputHolder = createElement('input', undefined, 'Tickets Sold');
        const archiveBtn = createElement('button', 'Archive');

        archiveBtn.addEventListener('click', onArchive);

        [strongDiv, inputHolder, archiveBtn].forEach(el => div.appendChild(el));
        [span, strongHall, div].forEach(el => liElement.appendChild(el));
        movies.appendChild(liElement);
        [name, hall, ticketPrice].map((el) => el.value = '');



        function onArchive(e) {
            const soldTickets = inputHolder.value;
            if (typeof Number(soldTickets) != 'number' || Number(inputHolder.value) <= 0) {
                return;
            };
            const totalAmount = Number(soldTickets) * tickPriceValue;

            div.remove();

            const deleteBtn = createElement('button', 'Delete');
            deleteBtn.addEventListener('click', onDelete);

            function onDelete(e) {
                e.target.parentNode.remove();

            }

            const clearBtn = document.querySelector('#archive > button');
            clearBtn.addEventListener('click', onClear);

            function onClear(e) {
                const ul = e.target.parentNode.querySelector('ul');
                while (ul.firstChild) {
                    ul.removeChild(ul.firstChild);
                }
                console.log(ul);
            }

        }


    }

    function isValid(name, hall, ticketPrice) {
        if (name == '' || hall == '' || ticketPrice == '' || isNaN(ticketPrice)) {
            return false;
        }
        return true;
    }

    function createElement(type, text, atribute) {
        const el = document.createElement(type);
        if (text) {
            el.textContent = text;
        }
        if (atribute) {
            el.setAttribute('placeholder', 'Tickets Sold');
        }
        return el;

    }
}
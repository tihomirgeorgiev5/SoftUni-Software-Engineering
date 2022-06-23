function solution() {
    // Each product has name.
    //  When you click the [Add gift] button,
    //   a new list item should be added to the List of gifts.
    //    To each list item you should put a class “gift”. 
    //    Upon clicking the [Add gift] button
    //     you should sort the gifts in alphabetical order
    //      and you should clear the input field.

    [addSection, listSection, sendSection, discardedSection] = Array.from(document.querySelectorAll('section'));


    // Add gifts 

    const addNameField = addSection.querySelector('input');
    const addGiftBtn = addSection.querySelector('button');
    addGiftBtn.addEventListener('click', onAdd);

    function onAdd(e) {
        e.preventDefault();

        const sendBtn = createElement('button', 'Send', undefined, 'sendButton');
        sendBtn.addEventListener('click', onSend);
        const discardBtn = createElement('button', 'Discard', undefined, 'discardButton');
        discardBtn.addEventListener('click', onDiscard);

        const li = createElement('li', addNameField.value, 'gift');
        li.appendChild(sendBtn);
        li.appendChild(discardBtn);
        ulLists.appendChild(li);

        Array.from(ulLists.querySelectorAll('li'))
            .sort((a, b) => a.textContent.localeCompare(b.textContent))
            .forEach((el) => ulLists.appendChild('li'));

        addNameField.value = '';


    };

    const ulLists = listSection.querySelector('ul')
    // const liLists = listSection.querySelectorAll('li')

    //Sent gifts 
    const ulSends = sendSection.querySelector('ul');

    //discarded gifts
    const ulDiscarded = discardedSection.querySelector('ul');



    function onSend(e) {
        const li = e.target.parentNode
        li.removeChild(li.childNodes[1])
        li.removeChild(li.childNodes[1])
        ulSends.appendChild(li);
    }

    function onDiscard(e) {
        const li = e.target.parentNode
        li.removeChild(li.childNodes[1])
        li.removeChild(li.childNodes[1])
        ulDiscarded.appendChild(li);
    }

    

    function createElement(type, text, atribute, id) {
        const el = document.createElement('type');
        if (text) {
            el.textContent = text;
        }
        if (atribute) {
            el.className = atribute;
        }
        if (id) {
            el.id = id;
        }
        return el;
    }
}

// List of gifts







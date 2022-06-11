function solve() {
    // When the [Add] button is clicked,
    //first you need to validate the inputs.
    // If any of the input fields are empty, 
    // the function doesn’t make anything. 

    const [section1, section2, section3, section4] = document.querySelectorAll('section');
    const taskField = document.getElementById('task');
    const descriptionField =
        document.getElementById('description');
    const dueDateField = document.getElementById('date');


    const buttonAdd = section1.children[1].querySelector('button');
    buttonAdd.addEventListener('click', onAdd)

    function onAdd(ev) {
        ev.preventDefault();

        if (taskField.value == '' || descriptionField.value == '' || dueDateField.value == '') {
            return;
        }

        const article = createElement('article', null, null);
        const headElement = createElement('h3', taskField.value, null);
        const pDescription = createElement('p', `Description: ${descriptionField.value}`);
        const pDueDate = createElement('p', `Due Date: ${dueDateField.value}`, null );
        const buttonsDiv = createElement('buttonsDiv', null, 'flex');
        const buttonStart = createElement('button', 'Start', 'green');
        const buttonFinish = createElement('button', 'Finish', 'orange');
        const buttonDelete = createElement('button', 'Delete', 'red');

        // When the [Start] button is clicked, you need to move the Task in the section "In Progress"
        buttonStart.addEventListener('click', () => {
            section3.children[1].appendChild(article);
            buttonStart.remove();
            buttonsDiv.appendChild(buttonFinish);
        });

        //  After clicking the [Finish] button, the Task will be completed,
        //  and you should move the article to the section "Complete".
        //   The buttons with their parent div-element should be removed.

        buttonFinish.addEventListener('click', ()=> {
            section4.lastElementChild.appendChild(article);
            buttonsDiv.remove();
        });

        // When the [Delete] button is clicked,
        //  the Task (whole article) should be removed from the HTML.
        
        buttonDelete.addEventListener('click', () => {
            article.remove();
        });

        // The article should have two buttons "Start" and "Delete".
        //  Be careful to set the classes for the buttons and the parent-div.

        [headElement, pDescription, pDueDate, buttonsDiv].forEach((el) => {
            article.appendChild(el);
        });

        [buttonStart, buttonDelete].forEach((el) => {
            buttonsDiv.appendChild(el);
        });

        // After validating the input fields, 
        // you need to add the new task (article) in the "Open" section. 

        section2.children[1].appendChild(article);
        
        // cleared AddTask
        [taskField, descriptionField, dueDateField].forEach((el) =>
        el.value = '');   
    }
    function createElement(type, content, className) {
        const el = document.createElement(type);
        if (content) {
            el.textContent = content;
        } if (className) {
            el.className = className;
        }
        return el;
    }


}
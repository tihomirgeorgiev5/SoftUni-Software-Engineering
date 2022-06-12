window.addEventListener("load", solve);

function solve() {
  // All fields (title, category, and content) are filled with the correct input

  // ⦁	Getting the information from the form


  const input = {
    title: document.getElementById('post-title'),
    category: document.getElementById('post-category'),
    content: document.getElementById('post-content'),
  }

  const review = document.getElementById('review-list');
  const publish = document.getElementById('published-list');

  const btnPublish = document.getElementById('publish-btn');
  const btnClear = document.getElementById('clear-btn');

  btnPublish.addEventListener('click', onPublish);
  btnClear.addEventListener('click', onClear);

  // When you click the ["Publish"] button, 

  function onPublish(ev) {
    // ⦁	Title, category, and content are non-empty strings.
    //  If any of them are empty, 
    //  the program should not do anything.

    if (input.title.value != '' && input.content.value != '' && input.category.value != '') {
      // const article = createElement('article', null, null);
      // const headElement = createElement('h3', taskField.value, null);
      // const pDescription = createElement('p', `Description: ${descriptionField.value}`);
      // const pDueDate = createElement('p', `Due Date: ${dueDateField.value}`, null );
      // const buttonsDiv = createElement('buttonsDiv', null, 'flex');
      // const buttonStart = createElement('button', 'Start', 'green');
      // const buttonFinish = createElement('button', 'Finish', 'orange');
      // const buttonDelete = createElement('button', 'Delete', 'red');

      const li = createElement('li', null, 'rpost');
      const article = createElement('article', null, null);
      const headEl = createElement('h4', input.title.value, null);
      const pCategory = createElement('p', input.category.value, null);
      const pContent = createElement('p', input.content.value, null);
      const editBtn = createElement('button', 'Edit', 'action-btn edit');
      const approveBtn = createElement('button', 'Approve', 'action-btn approve');

      // the information from the input fields
      //  must be added to the review

      review.appendChild(li);
      li.appendChild(article);
      li.appendChild(editBtn);
      li.appendChild(approveBtn);
      article.appendChild(headEl);
      article.appendChild(pCategory);
      article.appendChild(pContent);

      editBtn.addEventListener('click', onEdit);
      approveBtn.addEventListener('click', onApprove);

      //  and then clear input fields.
      input.category.value = '';
      input.content.value = '';
      input.title.value = '';

    }
  }

  // When the ["Edit"] button is clicked,
  //  the information from the post 
  //  must be sent to the input’s fields 
  //  and the record should be deleted
  //   from the ul "review-list". 

  function onEdit(e) {
    const currentArticle = e.target.previousSibling;
    input.title.value = currentArticle.querySelector('h4').textContent;
    input.category.value = currentArticle.querySelectorAll('p')[0].textContent;
    input.content.value = currentArticle.querySelectorAll('p')[1].textContent;

    currentArticle.parentNode.remove();
  }

  function onApprove(e) {
    // When you click the ["Approve"] button,
    //  the record must be deleted
    //   from the ul with id "review-list"
    //   and appended to the
    //    ul with the id "published-list"

    //     ​
    // childNodes: NodeList(3) [
    //   article,
    //    button.action-btn.edit,
    //     button.action-btn.approve ]

    const currentArticle = e.target.parentNode;

    const article = currentArticle.querySelector('article');
    const buttonEdit = currentArticle.querySelectorAll('button')[0];
    const buttonApprove = currentArticle.querySelectorAll('button')[1];


    // The buttons [“Edit”] and [“Approve”] 
    // should be removed from the li element.

    buttonEdit.remove();
    buttonApprove.remove();

    publish.appendChild(currentArticle);

  }

  function createElement(type, content, className) {
    const el = document.createElement(type);
    if (content) {
      el.textContent = content;
    }
    if (className) {
      el.className = className;
    }
    return el;
  }

  function onClear() {
    publish.innerText = '';

  }

}
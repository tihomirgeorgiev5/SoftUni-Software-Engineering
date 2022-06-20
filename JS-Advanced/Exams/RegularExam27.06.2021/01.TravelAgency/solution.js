window.addEventListener('load', solution);

// function solution() {
//   let fullNameInputElement = document.getElementById('fname');
//   let emailInputElement = document.getElementById('email');
//   let phoneNumberInputElement = document.getElementById('phone');
//   let addressInputElement = document.getElementById('address');
//   let postalCodeInputElement = document.getElementById('code');

//   let submitButtonElement = document.getElementById('submitBTN');

//   submitButtonElement.addEventListener('click', (e) => {
//     e.preventDefault();

//     if (!fullNameInputElement.value || !emailInputElement.value) {
//       return;
//     }
//     submitButtonElement.disabled = true;

//     let editButtonElement = document.getElementById('editBTN');
//     editButtonElement.disabled = false;
//     let continueButtonElement = document.getElementById('continueBTN');
//     continueButtonElement.disabled = false;

//     let ulElelement = document.getElementById('infoPreview');

//     let nameLi = document.createElement('li');
//     nameLi.textContent = `Full Name: ${fullNameInputElement.value}`;

//     let emailLi = document.createElement('li');
//     emailLi.textContent = `Email: ${emailInputElement.value}`;

//     let phoneLi = document.createElement('li');
//     phoneLi.textContent = `Phone Number: ${phoneNumberInputElement.value}`;

//     let addressLi = document.createElement('li');
//     addressLi.textContent = `Address: ${addressInputElement.value}`;

//     let postalLi = document.createElement('li');
//     postalLi.textContent = `Postal Code: ${postalCodeInputElement.value}`;

//     ulElelement.appendChild(nameLi);
//     ulElelement.appendChild(emailLi);
//     ulElelement.appendChild(phoneLi);
//     ulElelement.appendChild(addressLi);
//     ulElelement.appendChild(postalLi);

//     fullNameInputElement.value = '';
//     emailInputElement.value = '';
//     phoneNumberInputElement.value = '';
//     addressInputElement.value = '';
//     postalCodeInputElement.value = '';


//     editButtonElement.addEventListener('click', (e) => {
//       e.preventDefault();

//       while (ulElelement.firstChild) {
//         ulElelement.removeChild(ulElelement.firstChild);
//       }

//       fullNameInputElement.value = nameLi.textContent;
//       emailInputElement.value = emailLi.textContent;
//       phoneNumberInputElement.value = Number(phoneLi.textContent);
//       addressInputElement.value = addressLi.textContent;
//       postalCodeInputElement.value = Number(postalLi.textContent);

//       submitButtonElement.disabled = false;
//       editButtonElement.disabled = true;
//       continueButtonElement.disabled = true;
//     });

//     continueButtonElement.addEventListener('click', (e) => {
//       e.preventDefault();

//       let mailDivElement = document.getElementById('block');

//       while (mailDivElement.firstChild) {
//         mailDivElement.removeChild(mailDivElement.firstChild);
//       }

//       let finalHeader = document.createElement('h3');
//       finalHeader.textContent = 'Thank you for your reservation!';
//       mailDivElement.appendChild(finalHeader);
//     })
//   });
// }

function solution() {
  // first get buttons

  let submitBtn = document.getElementById('submitBTN');
  let fullNameField = document.getElementById('fname');
  let emailfield = document.getElementById('email');
  let phoneNumberField = document.getElementById('phone');
  let addressField = document.getElementById('address');
  let postCodeField = document.getElementById('code');



  submitBtn.addEventListener('click', onSubmit);


  function onSubmit(e) {
    e.preventDefault();


    let fullName = fullNameField.value;
    let email = emailfield.value;
    let phoneNum = phoneNumberField.value;
    let address = addressField.value;
    let postalCode = postCodeField.value;

    if (!fullName || !email) {
      return;
    }

    let editBtn = document.getElementById('editBTN');
    let contBtn = document.getElementById('continueBTN');

    submitBtn.disabled = true;
    editBtn.disabled = false;
    contBtn.disabled = false;



    // let classPreview = document.querySelector('.preview');
    let infoPreview = document.getElementById('infoPreview');
    let fullNameLi = document.createElement('li');
    let emailLi = document.createElement('li');
    let phoneNumLi = document.createElement('li');
    let addressLi = document.createElement('li');
    let postalCodeLi = document.createElement('li');

    fullNameLi.textContent = `Full Name: ${fullName}`;
    emailLi.textContent = `Email: ${email}`;
    phoneNumLi.textContent = `Phone Number: ${phoneNum}`;
    addressLi.textContent = `Address: ${address}`;
    postalCodeLi.textContent = `Postal Code: ${postalCode}`;

    infoPreview.appendChild(fullNameLi);
    infoPreview.appendChild(emailLi);
    infoPreview.appendChild(phoneNumLi);
    infoPreview.appendChild(addressLi);
    infoPreview.appendChild(postalCodeLi);

    // classPreview.appendChild(infoPreview);

    fullName = '';
    email = '';
    phoneNum = '';
    address = '';
    postalCode = '';


    editBtn.addEventListener('click', onEdit);

    function onEdit(e) {
      e.preventDefault();

      while (infoPreview.firstChild) {
        infoPreview.removeChild(infoPreview.firstChild);
      }

      fullName = fullNameLi.textContent;
      email = emailLi.textContent;
      phoneNum = Number(phoneNumLi.textContent);
      address = addressLi.textContent;
      postalCode = Number(postalCodeLi.textContent);

      submitBtn.disabled = false;
      editBtn.disabled = true;
      contBtn.disabled = true;

    };
    contBtn.addEventListener('click', onContinue);
    function onContinue(e) {
      e.preventDefault();

      let blockDiv = document.getElementById('block');

      while (blockDiv.firstChild) {
        blockDiv.removeChild(blockDiv.firstChild);
      }
      let h3Element = document.createElement('h3');
      h3Element.textContent = 'Thank you for your reservation!';

      blockDiv.appendChild(h3Element);

    };


  };

}

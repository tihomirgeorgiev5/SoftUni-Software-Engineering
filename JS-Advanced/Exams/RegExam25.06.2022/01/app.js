window.addEventListener("load", solve);

function solve() {
  const publishBtn = document.getElementById('publish');
  const makeField = document.getElementById('make');
  const modelField = document.getElementById('model');
  const prodYearField = document.getElementById('year');
  const fuelTypeField = document.getElementById('fuel');
  const origCostField = document.getElementById('original-cost');
  const sellingPrice = document.getElementById('selling-price');
  const tableBody = document.getElementById('table-body');

  publishBtn.addEventListener('click', onPublish);

  function onPublish(e) {
    e.preventDefault;

    // All fields 
    // (make, model, year, fuel,
    //    original-cost and selling-price)
    //     are filled with the correct input

    let make = makeField.value;
    let model = modelField.value;
    let year = prodYearField.value;
    let fuel = fuelTypeField.value;
    let origCost = origCostField.value;
    let sellPrice = sellingPrice.value;

    if (make == '' || model == '' || year == '' || fuel == '' || origCost == '' || sellPrice == '') {
      return;
    }
    if (Number(sellPrice) < Number(origCost)) {
      return;

    }
    let rowElement = document.createElement('tr');
    let makeElement = document.createElement('td');
    let modelElement = document.createElement('td');
    let yearElement = document.createElement('td');
    let fuelElement = document.createElement('td');
    let origCostElement = document.createElement('td');
    let sellPriceElement = document.createElement('td');
    let tdBtn = document.createElement('td');
    let editBtn = document.createElement('button');
    let sellBtn = document.createElement('button');

    makeElement.textContent = make;
    modelElement.textContent = model;
    yearElement.textContent = year;
    fuelElement.textContent = fuel;
    origCostElement.textContent = origCost;
    sellPriceElement.textContent = sellPrice;
    editBtn.textContent = 'Edit';
    sellBtn.textContent = 'Sell';

    editBtn.addEventListener('click', onEdit)

    tdBtn.appendChild(editBtn),
    tdBtn.appendChild(sellBtn);
    rowElement.appendChild(tdBtn);
    rowElement.appendChild(sellPriceElement);
    rowElement.appendChild(origCostElement);
    rowElement.appendChild(fuelElement);
    rowElement.appendChild(yearElement);
    rowElement.appendChild(modelElement);
    rowElement.appendChild(makeElement);

    tableBody.appendChild(rowElement);

    [makeField, modelField, prodYearField, fuelTypeField, origCostField, sellingPrice].map((el) => el.value = '');

  }

  function onEdit(e) {
    e.preventDefault();





  }

}

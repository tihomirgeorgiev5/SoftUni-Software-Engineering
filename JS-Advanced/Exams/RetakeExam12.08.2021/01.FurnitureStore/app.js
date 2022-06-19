window.addEventListener('load', solve);

function solve() {
    const addBtn = document.getElementById('add');
    addBtn.addEventListener('click', onAddClick);

    const modelField = document.getElementById('model');
    const yearField = document.getElementById('year');
    const descriptionField = document.getElementById('description');
    const priceField = document.getElementById('price');
    const furnitureList = document.getElementById('furniture-list');

    function onAddClick(ev) {
        ev.preventDefault();

        let model = modelField.value;
        let description = descriptionField.value;
        let year = Number(yearField.value);
        let price = Number(priceField.value);

        if (!model || !description) {
            return;
        }

        if (year <= 0 || price <= 0) {
            return;
        }

        let rowElement = document.createElement('tr');
        let hideRowElement = document.createElement('tr');
        let modelElement = document.createElement('td');     
        let priceOfFurniture = document.createElement('td');
        let actionsElement = document.createElement('td');
        let yearContentElement = document.createElement('td')
        let descriptionContextElement = document.createElement('td')
        let moreBtn = document.createElement('button');
        let buyBtn = document.createElement('button');
        let totalPriceElement = document.querySelector('.total-price');

        
        hideRowElement.classList.add('hide');
        hideRowElement.style.display = 'none';
        priceOfFurniture.textContent = price.toFixed(2);
        modelElement.textContent = model;
        moreBtn.textContent = 'More Info';
        moreBtn.addEventListener('click' , (e)=> {
            if (e.currentTarget.textContent == 'More Info') {
                e.currentTarget.textContent = 'Less Info';
                hideRowElement.style.display = 'contents';
            } else {
                e.currentTarget.textContent = 'More Info';
                hideRowElement.style.display = 'none';
            }
        });
        buyBtn.textContent = 'Buy it';
        moreBtn.classList.add('moreBtn');
        buyBtn.classList.add('buyBtn');
        yearContentElement.textContent = `Year: ${year}`;
        descriptionContextElement.setAttribute('colspan',3); 
        descriptionContextElement.textContent = `Description: ${description}`;
        buyBtn.addEventListener('click', (e) => {
            let currentTotalPrice = Number(totalPriceElement.textContent);
            let totalPrice = currentTotalPrice + price;
            totalPriceElement.textContent = totalPrice.toFixed(2);
            rowElement.remove(),
            hideRowElement.remove();
        })


        rowElement.appendChild(modelElement);
        rowElement.appendChild(priceOfFurniture);
        rowElement.appendChild(actionsElement);
        actionsElement.appendChild(moreBtn);
        actionsElement.appendChild(buyBtn);
        rowElement.classList.add('info');
        hideRowElement.appendChild(yearContentElement);
        hideRowElement.appendChild(descriptionContextElement);
 
        furnitureList.appendChild(rowElement);
        furnitureList.appendChild(hideRowElement);

    };

}

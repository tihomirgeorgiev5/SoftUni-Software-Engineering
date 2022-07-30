async function students() {
    const url = 'http://localhost:3030/jsonstore/collections/students';
    const table = document.querySelector('#results tbody');
    const response = await fetch(url);
    const data = await response.json();

    Object.values(data).forEach(s => {
        const firstName = s.firstName;
        const lastName = s.lastName;
        const facultyNumber = s.facultyNumber;
        const grade = s.grade;

        const tr = document.createElement('tr');

        const firstNameCell = tr.insertCell(0);
        firstNameCell.innerText = firstName;

        const lastNameCell = tr.insertCell(1);
        lastNameCell.innerText = lastName;

        const facultyNumCell = tr.insertCell(2);
        facultyNumCell.innerText = facultyNumber;

        const gradeCell = tr.insertCell(3);
        gradeCell.innerText = grade;


        table.appendChild(tr);

    });

    const submitBtn = document.getElementById('submit');
    submitBtn.addEventListener('click', onSubmit);

    async function onSubmit(ev) {
        ev.preventDefault();

        const firstNameInput = document.querySelector('[name="firstName"]');
        const lastNameInput = document.querySelector('[name="lastName"]');
        const facultyNumInput = document.querySelector('[name="facultyNumber"]');
        const gradeInput = document.querySelector('[name="grade"]');

        if (isNaN(facultyNumInput.value) || isNaN(gradeInput.value)) {
            return alert('Wrong input data!');
        }

        if (firstNameInput.value !== '' &&
            lastNameInput.value !== '' &&
            facultyNumInput.value !== '' &&
            gradeInput.value !== '') {
            const res = await fetch(url, {
                method: 'post',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    firstName: firstNameInput.value,
                    lastName: lastNameInput.value,
                    facultyNumber: facultyNumInput.value,
                    grade: gradeInput.value
                })

            });

            const tr = document.createElement('tr');
            const firstNameCell = tr.insertCell(0);
            firstNameCell.innerText = firstNameInput.value;

            const lastNameCell = tr.insertCell(1);
            lastNameCell.innerText = lastNameInput.value;

            const facultyNumCell = tr.insertCell(2);
            facultyNumCell.innerText = facultyNumInput.value;

            const gradeCell = tr.insertCell(3);
            gradeCell.innerText = gradeInput.value;
            table.appendChild(tr);
        }

        firstNameInput.value = '';
        lastNameInput.value = '';
        facultyNumInput.value = '';
        gradeInput.value = '';

    }

}

students();
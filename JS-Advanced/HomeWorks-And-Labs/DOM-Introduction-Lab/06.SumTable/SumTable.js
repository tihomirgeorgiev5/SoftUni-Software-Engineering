function sumTable() {
    const rows = document.querySelectorAll('table tr');

    let sum = 0;

    for (let i = 1; i < rows.length - 1; i++) {
        const cols = rows[i].children;
        sum += Number(cols[cols.length - 1].textContent);
        
    }

    document.getElementById('sum').textContent = sum;

}
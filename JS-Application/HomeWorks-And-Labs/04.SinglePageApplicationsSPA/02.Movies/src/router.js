const routes = {

};

function hideAll() {
    document.querySelectorAll('.view-section').forEach(v => v.style.display = 'none');

}

function showView(section) {
    hideAll();

    section.style.display = 'block';
}
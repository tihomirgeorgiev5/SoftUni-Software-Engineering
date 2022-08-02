// [x] improve HTML structure
// [ ] create app.js module
// [ ] create router.js containing hide and display of view
// [ ] placeholders for all views

// implement views
// - create request logic
// - DOM manipulation logic
// [ ] catalog
// [ ] login
// [ ] register
// [ ] create
// [ ] details
// [ ] like
// [ ] edit
// [ ] delete

// showView('#home-page');

document.querySelector('nav').addEventListener('click', (event) => {
    if (event.target.tagName == 'A' && event.target.href) {
        event.preventDefault();
        //const url = new URL(event.target.href);
        console.log(url.pathname);
    }

});





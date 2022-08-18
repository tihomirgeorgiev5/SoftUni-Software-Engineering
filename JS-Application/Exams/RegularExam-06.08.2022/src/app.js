import { page, render } from './lib.js';

page('/', () => console.log('home'));
page('/dashboard', () => console.log('catalog'));
page('/dashboard/:id', () => console.log('details'));
page('/edit/:id', () => console.log('edit'));
page('/login', () => console.log('login'));
page('/register', () => console.log('register'));
page('/create', () => console.log('create'));



// Start application
page.start();
import { logout } from './api/users.js';
import { page, render } from './lib.js';
import { getUserData } from './util.js';
import { addView } from './views/create.js';
import { dashboardView } from './views/dashboard.js';
import { homeView } from './views/home.js';
import { loginView } from './views/login.js';
import { registerView } from './views/register.js';

const main = document.querySelector('main');
document.getElementById('logoutBtn').addEventListener('click', onLogout)

page(decorateContext);
page('/', homeView);
page('/dashboard', dashboardView);
page('/dashboard/:id', () => console.log('details'));
page('/edit/:id', () => console.log('edit'));
page('/login', loginView);
page('/register', registerView );
page('/add', addView);
page('/search', () => console.log('search'));

//Start App
updateNav();
page.start();

function decorateContext(ctx, next) {
    ctx.render = renderMain;
    ctx.updateNav = updateNav;

    next();
}

function renderMain(templateResult) {
    render(templateResult, main);
}

//  <div class="user">
//             <a href="/add">Add Pair</a>
//             <a id="logoutBtn" href="javascript:void(0)">Logout</a>
//           </div>

//           <!--Guest users-- >
//     <div class="guest">
//         <a href="/login">Login</a>
//         <a href="/register">Register</a>
//     </div>

function updateNav() {
    const userData = getUserData();
    if (userData) {
        document.querySelector('.user').style.display = 'block';
        document.querySelector('.guest').style.display = 'none';
        
    } else {
        document.querySelector('.user').style.display = 'none';
        document.querySelector('.guest').style.display = 'block';
    }
}

function onLogout() {
    logout();
    updateNav();
    page.redirect('/');
}
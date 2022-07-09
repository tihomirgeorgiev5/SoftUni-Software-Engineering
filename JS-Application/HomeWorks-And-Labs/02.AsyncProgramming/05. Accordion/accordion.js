async function solution() {

    const main = document.getElementById('main');
    const url = 'http://localhost:3030/jsonstore/advanced/articles/list';
    const res = await fetch(url);
    const data = await res.json();

    data.forEach(e => {
        let divAccordion = createElement('div','',['class','accordion']);
        let divHead = createElement('div','',['class','head']);
        let span = createElement('span',e.title);
        let button = createElement('button','More',['class','button','id',e._id])
        let divExtra = createElement('div','',['class','extra']);
        let p = createElement('p');
        

        button.addEventListener('click', toggle);


        divHead.appendChild(button);
        divAccordion.appendChild(divHead);
        main.appendChild(divAccordion);
        divHead.appendChild(span);
        divAccordion.appendChild(divExtra);
        divExtra.appendChild(p);
        
        
    })

    async function toggle(ev){
        const accordion = ev.target.parentNode.parentNode;

        const p = ev.target.parentNode.parentNode.children[1].children[0];
        const extra = ev.target.parentNode.parentNode.children[1];
        //console.log(extra);
        

        const id = ev.target.id;
        const url = `http://localhost:3030/jsonstore/advanced/articles/details/${id}`;
        const res = await fetch(url);
        const data = await res.json();

        p.textContent = data.content;

        const hidden = ev.target.textContent == 'More';

        extra.style.display = hidden ? 'block' : 'none';
        ev.target.textContent = hidden ? 'Less' : 'More';
        
    }

    function createElement(type, content, attributes = []){
        const el = document.createElement(type);

        if (content) {
            el.textContent = content;
        }
        if (attributes.length > 0) {
            for (let i = 0; i < attributes.length; i+=2) {
                el.setAttribute(attributes[i],attributes[i+1])
                
            }
        }
        return el;
    }
    
}
solution();
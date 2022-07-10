const input = {
    "body": 'Quisquam beatae rerum repudiandae distinctio nesciunt nemo dolorem facilis aspernatur, totam, laudantium sunt amet non, itaque voluptate quae cumque tempore autem similique. Quisquam nemo cupiditate, facere obcaecati iure eveniet illo recusandae! Pariatur magnam commodi, doloremque, beatae unde facilis soluta blanditiis ex debitis quisquam, nostrum voluptates.', 
    'title': 'Second Title'
};

async function solve() {
    const url = 'http://localhost:3030/jsonstore/blog/posts';
    const res = await fetch(url);
    const data = await res.json();

    console.log(data);
}
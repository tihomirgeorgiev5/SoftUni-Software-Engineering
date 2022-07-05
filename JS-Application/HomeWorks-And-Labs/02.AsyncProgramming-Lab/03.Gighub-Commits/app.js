async function loadCommits() {
    //    read input fields

    const username = document.getElementById('username'). value;
    const repo = document.getElementById('repo').value;
    const list = document.getElementById('commits')

    try {
        //    send request
        const res = await fetch(`https://api.github.com/repos/${username}/${repo}/commits`);

        //    check for errors
        if (res.ok == false) {
            throw new Error(`${res.status} ${res.status.text}`);
        }

        //    display result
        const data = await res.json();
        list.innerHTML = '';

        for (const { commit} of data) {
            list.innerHTML += `<li>${commit.author.name}: ${commit.message}</li>` ;
        }
        
       


        

    } catch (err) {
        //    handle errors
        list.innerHTML = `Error: ${err.message}`;

    }




   
}
// function loadRepos() {
// 	const username = document.getElementById('username').value;

// 	const url = `https://api.github.com/users/${username}/repos`;

// 	 fetch(url)
// 	 .then(response => response.json())
// 	 .then(data => {
// 		 const ulElement  = document.getElementById('repos');
// 		 ulElement.innerHTML = '';
// 		 data.forEach(r => {
// 			 const liElement = document.createElement('li');
// 			 liElement.textContent = r.full_name;
// 			 ulElement.appendChild(liElement); 
// 		 });
// 	 });

	/*console.log(requestPromise);

	requestPromise.then(handleResponse);


	function handleResponse(response) {
		console.log(response);
		const dataPromise = response.json();
		dataPromise.then(handleData);
	}

	function handleData(data) {
		console.log(data);
	} */


}
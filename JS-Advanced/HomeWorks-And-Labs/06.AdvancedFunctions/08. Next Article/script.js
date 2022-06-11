function getArticleGenerator(input) {
   const articles = input;

   return ()=> {
    if (articles.length > 0) {
        const container = document.getElementById('content');
        const article = document.createElement('article');
        const currentText = articles.shift();
        article.innerText = currentText;
        container.appendChild(article);
    }
   }
}

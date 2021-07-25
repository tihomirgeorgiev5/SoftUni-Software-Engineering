function attachGradientEvents() {

    
    const result = document.getElementById('result');
    const gradElement = document.getElementById('gradient');
    gradElement.addEventListener('mousemove', onMove);
    gradElement.addEventListener('mouseout', onOut);
    

    function onMove(event) {
        const offsetX = event.offsetX;
       

        const percentage = Math.trunc((offsetX / (event.target.clientWidth - 1) * 100));
        result.textContent = `${percentage}%`;
    }

    function onOut(event){
        result.textContent = '';
    }

}
 /*function attachGradientEvents() {
    let gradientElement = document.querySelector('#gradient');
    let output = document.querySelector('#result');

    gradientElement.addEventListener('mousemove', onMove);
    gradientElement.addEventListener('mouseout', onOut);

    function onMove(event){
        let position = event.offsetX / (event.target.clientWidth - 1);
        position = Math.trunc(position * 100);
        output.textContent = `${position}%`;
    }

    function onOut(event){
        output.textContent = '';
    }
}*/

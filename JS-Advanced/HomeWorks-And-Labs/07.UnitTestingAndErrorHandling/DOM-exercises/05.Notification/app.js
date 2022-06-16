function notify(message) {
  const notification = document.getElementById('notification');
  notification.innerText = message;
  notification.style.display = 'block';

  notification.addEventListener('click', onClick);

  function onClick(ev) {
    ev.target.style.display = 'none';
  }
}
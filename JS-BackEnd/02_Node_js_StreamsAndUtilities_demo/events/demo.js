const EventEmitter = require('events');

const eventEmitter = new EventEmitter();

eventEmitter.on('sing', (songTitle) => {
    console.log(`${songTitle} - shalalala`);
});

eventEmitter.emit('sing', 'We going to Ibiza!');

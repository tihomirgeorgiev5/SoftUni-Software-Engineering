const eventBus = require('./eventBus');

eventBus.subscribe('say-hello', (name, secondName) => console.log('event say-hello executed - ' + name + ' ' + secondName));
eventBus.subscribe('say-hello', (name, secondName) => console.log('event say-hello executed second time - ' + name + ' ' + secondName));
eventBus.subscribe('say-bye', (name) => console.log('event say-bye executed - ' + name));

eventBus.publish('say-hello', 'Pesho');
eventBus.publish('say-hello', 'Gosho', 'Ivan');
eventBus.publish('say-bye', 'Pesho');
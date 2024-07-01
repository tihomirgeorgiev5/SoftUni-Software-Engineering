const eventBus = require('./eventBus');

eventBus.subscribe('say-hello', () => console.log('event say-hello executed'));
eventBus.subscribe('say-hello', () => console.log('event say-hello executed second time'));
eventBus.subscribe('say-bye', () => console.log('event say-bye executed'));

eventBus.publish('say-bye');
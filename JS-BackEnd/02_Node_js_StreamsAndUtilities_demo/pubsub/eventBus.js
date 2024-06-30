const subscribers = {};

exports.subscribe = (eventType, callback) => {
    console.log('subscribe');
};

exports.publish = (eventType) => {
    console.log('publish');
}
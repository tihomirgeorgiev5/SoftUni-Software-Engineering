function argInfo() {
    const data = {};

    Array.from(arguments).forEach(arg => {
        const type = typeof arg;
        console.log(`${type}: ${arg}`);

        if (!data[type]) {
            data[type] = 0;
        }
        data[type]++;   
    });

    Object.keys(data)
    .sort((a,b) => data[b] - data[a])
    .forEach(k => console.log(`${k} = ${data[k]}`));
}
argInfo('cat', 42, function () { console.log('Hello world!'); });
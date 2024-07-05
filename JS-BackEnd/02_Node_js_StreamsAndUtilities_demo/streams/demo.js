const fs = require('fs');

const readStream = fs.createReadStream('./streams/largeFile.txt', { encoding: 'utf-8'});
const writeStream = fs.createWriteStream('./streams/copyFile.txt', { encoding: 'utf-8'});

readStream.on('data', (chunk) => {
    console.log(chunk);
});

readStream.on('end', () => {
    console.log('Finished');
})

writeStream.write('Hello World');
writeStream.write('\n');
writeStream.write('Hello World 2');

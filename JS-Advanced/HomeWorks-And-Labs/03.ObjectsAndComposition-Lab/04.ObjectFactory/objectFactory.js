function factory(lib, ord) {
    //for every order in ord
    // create object
    // copy template props
    // for every element in parts
    // compose function from library into object
    // store object

    let result = [];

    for (const order of ord) {
        const object = {};
        const template = order.template;

        for (const prop in order.template) {
            object[prop] = template[prop]; // copy from each template
        }

        const parts =  order.parts;

        for (const part of parts) {
            object[part] = lib[part];
           // console.log(lib[part]); // watch what is in library behind this key
        }

        result.push(object);
    }


    // return result
    return result;
}

const library = {
    print: function () {
        console.log(`${this.name} is printing a page`);
    },
    scan: function () {
        console.log(`${this.name} is scanning a document`);
    },
    play: function (artist, track) {
        console.log(`${this.name} is playing '${track}' by ${artist}`);
    },
};

const orders = [
    {
        template: { name: 'ACME Printer' },
        parts: ['print']
    },
    {
        template: { name: 'Initech Scanner' },
        parts: ['scan']
    },
    {
        template: { name: 'ComTron Copier' },
        parts: ['scan', 'print']
    },
    {
        template: { name: 'BoomBox Stereo' },
        parts: ['play']
    }
];

const products = factory(library, orders);
console.log(products);

products[3].play('Metallica', 'Nothing Else Matters');

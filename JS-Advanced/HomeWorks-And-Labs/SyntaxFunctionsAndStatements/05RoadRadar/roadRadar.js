function solve(speed, string) {
    let currSpeed = Number(speed);
    let area = string;
    let motorwayLimit = 130;
    let interstateLimit = 90;
    let cityLimit = 50;
    let residentialLimit = 20;

    switch (area) {
        case 'motorway':
            if (speed <= motorwayLimit) {
                return `Driving ${speed} km/h in a ${motorwayLimit} zone`
            } else if (speed > motorwayLimit && speed <= (motorwayLimit + 20)) {
                return `The speed is ${speed - motorwayLimit} km/h faster than the allowed speed of ${motorwayLimit} - ${'speeding'}`;
            } else if ((speed > 20 && speed <= (motorwayLimit + 40))) {
                return `The speed is ${speed - motorwayLimit} km/h faster than the allowed speed of ${motorwayLimit} - ${'excessive speeding'}`;
            } else {
                return `The speed is ${speed - motorwayLimit} km/h faster than the allowed speed of ${motorwayLimit} - ${'reckless driving'}`;
            };

        case 'interstate':
            if (speed <= interstateLimit) {
                return `Driving ${speed} km/h in a ${interstateLimit} zone`
            } else if (speed > interstateLimit && speed <= (interstateLimit + 20)) {
                return `The speed is ${speed - interstateLimit} km/h faster than the allowed speed of ${interstateLimit} - ${'speeding'}`;
            } else if ((speed > 20 && speed <= (interstateLimit + 40))) {
                return `The speed is ${speed - interstateLimit} km/h faster than the allowed speed of ${interstateLimit} - ${'excessive speeding'}`;
            } else {
                return `The speed is ${speed - interstateLimit} km/h faster than the allowed speed of ${interstateLimit} - ${'reckless driving'}`;
            };

        case 'city':
            if (speed <= cityLimit) {
                return `Driving ${speed} km/h in a ${cityLimit} zone`
            } else if (speed > cityLimit && speed <= (cityLimit + 20)) {
                return `The speed is ${speed - cityLimit} km/h faster than the allowed speed of ${cityLimit} - ${'speeding'}`;
            } else if ((speed > 20 && speed <= (cityLimit + 40))) {
                return `The speed is ${speed - cityLimit} km/h faster than the allowed speed of ${cityLimit} - ${'excessive speeding'}`;
            } else {
                return `The speed is ${speed - cityLimit} km/h faster than the allowed speed of ${cityLimit} - ${'reckless driving'}`;
            };

        case 'residential':
            if (speed <= residentialLimit) {
                return `Driving ${speed} km/h in a ${residentialLimit} zone`
            } else if (speed > residentialLimit && speed <= (residentialLimit + 20)) {
                return `The speed is ${speed - residentialLimit} km/h faster than the allowed speed of ${residentialLimit} - ${'speeding'}`;
            } else if ((speed > 20 && speed <= (residentialLimit + 40))) {
                return `The speed is ${speed - residentialLimit} km/h faster than the allowed speed of ${residentialLimit} - ${'excessive speeding'}`;
            } else {
                return `The speed is ${speed - residentialLimit} km/h faster than the allowed speed of ${residentialLimit} - ${'reckless driving'}`;
            };
        default:
            break;
    }


}
console.log(solve(100, 'motorway'));

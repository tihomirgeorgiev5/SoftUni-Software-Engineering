/*function size(stars) {
    if (stars === '') {
        stars === 5;

    } else {
        for (i = 0; i < stars; i++)
            console.log('* '.repeat(stars));

    }


}
size(5)*/

function squareOfstars(numOfStars) {
    if (numOfStars === undefined) {
        for (i = 0; i < 5; i++)
            console.log('* '.repeat('5'));

    } else {

        for (i = 0; i < numOfStars; i++)
            console.log('* '.repeat(numOfStars));

    }

}
squareOfstars()
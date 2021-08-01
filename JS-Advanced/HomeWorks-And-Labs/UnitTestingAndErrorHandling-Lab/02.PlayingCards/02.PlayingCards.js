function factoryCard(face, suit) {
    const validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    const suitToSymbol = {
        'S': '\u2660',
        'H': '\u2665',
        'D': '\u2666',
        'C': '\u2663'
    };

    if (validFaces.includes(face) == false ||
    Object.keys(suitToSymbol).includes(suit) == false) {
        throw new Error('Error')
    }

    return {
        face,
        suit,
        toString() {
            return `${face}${suitToSymbol[suit]}`;
        }
    };
}

console.log(factoryCard('1', 'C'));
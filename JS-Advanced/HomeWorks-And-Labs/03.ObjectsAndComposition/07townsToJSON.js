function townsToJSON(inputArr) {

    const result = [];

    const [town, latitude, longitude] = splitWay(inputArr.shift());

    for (const townWay of inputArr) {
        const[townName, townLatitude, townLongitude] = splitWay(townWay);

        result.push({
            [town]: townName,
            [latitude]: Number(Number(townLatitude).toFixed(2)),
            [longitude]: Number(Number(townLongitude).toFixed(2)),
        });

    };

    return JSON.stringify(result);

    function splitWay(input) {
        return input
        .split('|')
        .slice(1)
        .map(x => x.trim());
    }
}
console.log(townsToJSON(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']));
console.log('-----');
console.log(townsToJSON(['| Town | Latitude | Longitude |',
'| Veliko Turnovo | 43.0757 | 25.6172 |',
'| Monatevideo | 34.50 | 56.11 |']));
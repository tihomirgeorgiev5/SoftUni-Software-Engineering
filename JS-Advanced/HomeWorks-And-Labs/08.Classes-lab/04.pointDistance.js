class Point {
    constructor(x,y) {
        this.x = x;
        this.y = y;
    }

    static distance(a,b) {
        return Math.sqrt((a.x - b.x) ** 2 + (a.y - b.y) ** 2);

    }
}

const point1 = new Point(1,1);
const point2 = new Point(4,5);

console.log(point1, point2);
console.log(Point.distance(point1, point2));
'use strict';

class Rectangle {

    constructor () {
        let _a, _b;

        switch(arguments.length) {
        case 2:
            [_a, _b] = [arguments[0], arguments[1]];
            break;
        case 1:
            _a = _b = arguments[0].a < arguments[0].b ? arguments[0].a : arguments[0].b;
            break;
        default:
            [_a, _b] = [2, 4];
        }
        
        Rectangle.list.push(this);
        this._setA = (value) => _a = value;
        this._setB = (value) => _b = value;
        this._getA = () => _a;
        this._getB = () => _b;
    }
    
    set a (value) {this._setA(value);}
    set b (value) {this._setB(value);}
    get a () {return this._getA();}
    get b () {return this._getB();}

    get square() {
        return this._getA() * this._getB();
    }

}

Rectangle.list = [];

let rect1 = new Rectangle(3, 7);
console.log(rect1.a, rect1.b);

let rect2 = new Rectangle(rect1);
console.log(rect2.a, rect2.b);

let rect3 = new Rectangle(8, 1);
console.log(rect3.a, rect3.b);

let rect4 = new Rectangle(rect3);
console.log(rect4.a, rect4.b);

console.log('\n');
Rectangle.list.forEach(rect => {
    console.log(rect.square);
});
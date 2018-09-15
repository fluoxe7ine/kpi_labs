'use strict';

// +++ 10. Определить класс «Прямоугольник» с закрытым элементами a и b – стороны прямоугольника.
// +++ Определить методы класса, обеспечивающие доступ к этим переменным. 
// +++ Создать метод, определяющий площадь прямоугольника. Задать такие конструкторы для класса:
// +++ конструктор инициализации с инициализацией данных при помощи передачи параметров (по умолчанию задавать прямоугольник со сторонами 2 и 4);
// +++ конструктор копирования, принимающий в качестве параметра ссылку на объект класса «Прямоугольник», и создающий прямоугольник со сторонами, равными меньшей стороне копируемого объекта.
// +++ Создать инициализированный статический массив указателей на прямоугольники и вывести площадь каждого прямоугольника на экран.

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
        this.setA = (value) => _a = value;
        this.setB = (value) => _b = value;
        this.getA = () => _a;
        this.getB = () => _b;
    }
    
    set a (value) {this.setA(value);}
    set b (value) {this.setB(value);}
    get a () {return this.getA();}
    get b () {return this.getB();}

    get square() {
        return this.getA() * this.getB();
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
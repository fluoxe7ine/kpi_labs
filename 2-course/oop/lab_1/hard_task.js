/** 
* TODO: Класс должен содержать методы для шифровки и расшифровки текста по трем алгоритмам или более.
* TODO: Сравнить время, затраченное на подбор ключей для разных методов.
* TODO: Определить деструктор класса
*/

const rl = require('readline-sync');

class Crypto {
    constructor() {
        let _t = rl.question('Type your message (or press Enter to default): ') || 'Lorem ipsum dolor sit!';
        this.getT = () => _t;
        this.setT = (value) => _t = value;
    }

    get t() {
        return this.getT();
    }


}

let c1 = new Crypto();
console.log(c1.t);
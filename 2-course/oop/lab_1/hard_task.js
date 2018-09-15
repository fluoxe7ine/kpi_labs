/** 
* TODO: Класс должен содержать методы для шифровки и расшифровки текста по трем алгоритмам или более.
* TODO: Сравнить время, затраченное на подбор ключей для разных методов.
* TODO: Определить деструктор класса
*/

const rl = require('readline-sync');

class Crypto {
    constructor() {
        let _t = rl.question('Type your message (or press Enter to default): ') || 'Lorem ipsum dolor sit';
        this._getT = () => _t;
        this._setT = (value) => _t = value;
    }

    get t() {
        return this._getT();
    }

    encryptCaeser(n){
        let alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
        let text = this._getT().toLowerCase().split(' ');
        let encryptedText = text.map(word => word.split('').map(letter => alphabet[(alphabet.indexOf(letter) + n) % alphabet.length]).join('')).join(' ');
        this._setT(encryptedText);
    }

}

let c1 = new Crypto();
console.log(c1.t);
c1.encryptCaeser(6);
console.log(c1.t);
/** 
* TODO: Класс должен содержать методы для шифровки и расшифровки текста по трем алгоритмам или более.
* TODO: Сравнить время, затраченное на подбор ключей для разных методов.
* TODO: Определить деструктор класса
*/

const rl = require('readline-sync');

class Crypto {
    constructor() {
        let _t = rl.question('Type your message (or press Enter to default): ') || 'lorem ipsum dolor sit';
        let alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];

        this.encryptCaesar = (n) => {
            let text = _t.toLowerCase().split(' ');
            let encryptedText = text
                .map(word => word.split('')
                    .map(letter => alphabet[(alphabet.indexOf(letter) + n) % alphabet.length])
                    .join(''))
                .join(' ');
            return encryptedText;
        };

        this.decryptCaesar = (encrMsg) => {
            let n = 0;
            while (encrMsg != _t) {
                encrMsg = encrMsg.split(' ')
                    .map(word => word.split('')
                        .map(letter => alphabet.indexOf(letter) - 1 >= 0 ? alphabet[alphabet.indexOf(letter) - 1] : alphabet[alphabet.length + alphabet.indexOf(letter) -1]
                        ).join('')
                    ).join(' ');
                ++n;
            }
            return {encrMsg, n};
        };
    }
}

let c1 = new Crypto();
let test = c1.encryptCaesar(4);
console.log(test);
console.log(c1.decryptCaesar(test));
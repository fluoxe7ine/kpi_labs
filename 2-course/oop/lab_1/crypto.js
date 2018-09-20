'use strict';

const rl = require('readline-sync');
const { PerformanceObserver, performance } = require('perf_hooks');

class Crypto {
    constructor() {
        let _t = rl.question('Type your message (or press Enter to default): ') || 'lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit lorem ipsum dolor sit';
        let alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '1', '2', '3', '4', '5' ,'6', '7', '8', '9', '0', '!', '@', '#', '$', ';', ':', '"', '^', '&', '*', '(', ')'];

        this.encryptRot1 = () => this.encryptCaesar(1);

        this.decryptRot1 = (encrMsg) => {
            return encrMsg.split(' ')
                .map(word => word.split('')
                    .map(letter => alphabet.indexOf(letter) - 1 >= 0 ? alphabet[alphabet.indexOf(letter) - 1] : alphabet[alphabet.length + alphabet.indexOf(letter) -1]
                    ).join('')
                ).join(' ');
        };

        this.encryptCaesar = (n = Math.floor(Math.random() * 26)) => {
            let text = _t.split(' ');
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

        this.encryptAtbash = () => {
            let reverseAlphabet = alphabet.join('').split('').reverse();
            let text = _t.split(' ');
            let encryptedText = text
                .map(word => word.split('')
                    .map(letter => reverseAlphabet[alphabet.indexOf(letter)])
                    .join(''))
                .join(' ');
            return encryptedText;
        };

        this.decryptAtbash =(encrMsg) => {
            let reverseAlphabet = alphabet.join('').split('').reverse();
            encrMsg = encrMsg.split(' ')
                .map(word => word.split('')
                    .map(letter => alphabet[reverseAlphabet.indexOf(letter)])
                    .join(''))
                .join(' ');
            return encrMsg;
        };
    }

    benchmarkFn(fnEnc, fnDec) {
        let start = performance.now();
        let enc = fnEnc();
        for (let i = 0; i < 10000; i++) {
            fnDec(enc);
        }
        let finish = performance.now();
        console.log(`Average ${fnDec.name} speed is ${((finish - start) / 1000).toFixed(3)} ms`);
    }

    benchmark() {
        console.log('BENCHMARKING...');
        this.benchmarkFn(this.encryptRot1, this.decryptRot1);
        this.benchmarkFn(this.encryptAtbash, this.decryptAtbash);
        this.benchmarkFn(this.encryptCaesar, this.decryptCaesar);
        console.log('BENCHMARK FINISHED');
    }
}

let crypto = new Crypto();
// console.log(`Encoded: ${crypto.encryptCaesar()}`);
// console.log(`Key: ${crypto.decryptCaesar(crypto.encryptCaesar()).n} 
// Decoded: ${crypto.decryptCaesar(crypto.encryptCaesar()).encrMsg}`);
crypto.benchmark();

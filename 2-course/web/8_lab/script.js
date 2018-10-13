// task 1

function getTriangleSquare() {
    // alert('hue');
    let x1 = document.getElementById('x1').value;
    let x2 = document.getElementById('x2').value;
    let x3 = document.getElementById('x3').value;
    let y1 = document.getElementById('y1').value;
    let y2 = document.getElementById('y2').value;
    let y3 = document.getElementById('y3').value;

    let a = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));
    let b = Math.sqrt(Math.pow(x3 - x1, 2) + Math.pow(y3 - y1, 2));
    let c = Math.sqrt(Math.pow(x3 - x2, 2) + Math.pow(y3 - y2, 2));
    let p = (a + b + c) / 2;

    let square = Math.sqrt(p * (p - a) * (p - b) * (p - c));
    let result = document.getElementById('result-1');
    result.value = square;
}

//task 2

function swapFields() {
    let firstWord = document.getElementById('t2-input-1');
    let secondWord = document.getElementById('t2-input-2');
    let temp = firstWord.value;
    firstWord.value = secondWord.value;
    secondWord.value = temp;
}

//task 3

function calculateMaxCount() {
    let arr = document.getElementById('t3-input').value.split(',');
    let max = Math.max(...arr);
    let count = 0;
    arr.forEach(element => element == max ? count++ : 1);
    let result = document.getElementById('t3-result');
    result.innerHTML = count;
}

//task 4

function checkTriangle() {
    let a = +document.getElementById('t4-input-1').value;
    let b = +document.getElementById('t4-input-2').value;
    let c = +document.getElementById('t4-input-3').value;
    let result = document.getElementById('t4-result');
    if (a + b > c && a + c > b && b + c > a) result.innerHTML = 'true';
    else result.innerHTML = 'false';
}

//task 5

function scaleImage() {
    let img = document.getElementById('t5');
    img.style.width  = '400px';
    img.style.height = '500px';
}

function goToDefault() {
    let img = document.getElementById('t5');
    img.style.width  = '300px';
    img.style.height = '400px';
}

//task 6

let makeMove = (function move() {
    let hr = document.getElementById('wrap-6');
    let left_right = 0,
        top_bot = 0,
        width = 100;
    hr.style.width = `${width}px`;
    return function(direction) {
        switch(direction){
        case 'left':
            left_right -= 10;
            hr.style.left = `${left_right}px`; 
            break;
        case 'right':
            left_right += 10;
            hr.style.left = `${left_right}px`; 
            break;
        case 'bot':
            top_bot += 10;
            hr.style.top = `${top_bot}px`; 
            break;
        case 'top':
            top_bot -= 10;
            hr.style.top = `${top_bot}px`; 
            break;
        case 'width+':
            width += 10;
            hr.style.width = `${width}px`;
            break;
        case 'width-':
            width -= 10;
            hr.style.width = `${width}px`;
            break;
        }
    }; 
})();

//task 7
//TODO:

//task 8
//TODO:

//task 9
//TODO:

//task 10

let reverse = () => {
    let value = document.getElementById("t10").value;
    value = value.split('').reverse().join('');
    let result = document.getElementById('t10-result');
    result.innerHTML = value;
};

//task 11

function dividersCount() {
    let value = document.getElementById('t11').value;
    let res = [];
    for (let i = 0; i <= value; i++) {
        (value % i == 0) ? res.push(i) : 1;
    }
    let result = document.getElementById('t11-result');
    result.innerHTML = res.join(' ');
}

//task 12
// TODO:

//task 13
// TODO:


//task 14
function wordCounter() {
    let text = document.getElementById('t14').value;
    let res = document.getElementById('t14-result');

    if (text != '') res.innerHTML = text.replace(/  +/g, ' ').split(' ').length;
    else res.innerHTML = '0';
}

//task 15

(function rotateAnimation() {
    let images = document.querySelectorAll('.wrap-15');
    images.forEach((elem, index) => {
        index % 2 == 0 ? elem.classList.add('rotate') : elem.classList.add('backrotate');
    });
})();

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
function calculateCourse() {
    
    let courses = {
        math: 1000,
        javascript: 1500,
        cplusplus: 8000
    };

    let durations = {
        half: 1,
        hour: 1.25,
        two: 1.45
    };

    let languages = {
        en: 1,
        ukr: 1.15,
        ru: 1.15
    };

    let course = document.getElementById('t7-course').value;
    let duration = document.getElementById('t7-duration').value;
    let language = document.getElementById('t7-language').value;
    let result = document.getElementById('res-7');
    result.innerHTML = courses[course] * durations[duration] * languages[language];
}

//task 8
function changeTdBg(id) {
    let td = document.querySelector('#t8').childNodes[1].querySelectorAll('td');
    let color = prompt('Input color', '');
    td[id].style.background = color;
}

function changeTableBg() {
    let table = document.querySelector('#t8');
    let color = prompt('Input color', '');
    table.style.background = color;
}

//task 9

function calculatePrice() {
    
    let prices = {
        milk: 10,
        wine: 13,
        beer: 8
    };

    let first = document.getElementById('t9-1').value,
        second = document.getElementById('t9-2').value,
        third = document.getElementById('t9-3').value;

    let first_count = document.getElementById('t9-count-1').value,
        second_count = document.getElementById('t9-count-2').value,
        third_count = document.getElementById('t9-count-3').value;

    let result = document.getElementById('res-9');
    
    // console.
    result.innerHTML = 
                        first_count * prices[first] + 
                        second_count * prices[second] + 
                        third_count * prices[third];

}

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
let sum = function(num){ // функция для получения суммы цифр
    let arr = num.toString().split(''),
        s = 0;
    arr.forEach((value) => s += parseInt(value));
    return s;
};

let luckyTickets = (function(len){
    let lenMiddle = len / 2,
        maxSize = Math.pow(10, lenMiddle),
        result = 0;

    for (let i = 0; i < maxSize; i++)
        for (let j = 0; j < maxSize; j++)
            if (sum(i) == sum(j)) result++;
    
    let res = document.getElementById('t12');
    res.innerHTML = result;
})(6);


//task 13

function calculateWeek(){
    let date = new Date(document.getElementById('t13').value);
    let diff = date - new Date(date.getFullYear(), 0, 0);
    let oneDay = 1000 * 60 * 60 * 24;
    let day = Math.floor(diff / oneDay);
    let week = Math.floor(((day - 1) / 7) + 1);
    let res = document.getElementById('res-13');
    res.innerHTML = week;
}

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

//task 16

function validateEmail() {
    let email = document.getElementById('t16').value;
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    let res = document.getElementById('res-16');
    res.innerHTML = re.test(String(email).toLowerCase());
}
let ajax = new XMLHttpRequest();
let ajax2 = new XMLHttpRequest();
let method  = 'GET';
let url = 'data.php';

ajax.open(method, url, true);
ajax.send();

ajax.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        let main_page_data = JSON.parse(this.responseText);
        let main_title = document.getElementById('main-title');
        let main_footer = document.getElementById('main-footer');
        let more_button = document.getElementsByClassName('det_but');
        main_title.innerHTML = main_page_data[0].title;
        main_footer.innerHTML = main_page_data[0].footer;
        for (let i = 0; i < more_button.length; i++) {
            more_button[i].innerHTML = main_page_data[0].more;
        }
        let menu = '';
        for (let i = 0; i < main_page_data.length; i++) {
            menu += `<li><a href='#'>${main_page_data[i].menu_title}</a></li>`;
        }
        let menu_selector = document.getElementById('menu');
        menu_selector.innerHTML = menu;
    }
};

ajax2.open('GET', 'articles.php', true);
ajax2.send();

ajax2.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
        let articles_data = JSON.parse(this.responseText).reverse();
        console.log(articles_data);
        let article_title = document.getElementsByClassName('article_title');
        let article_desc = document.getElementsByClassName('article_desc');
        let article_date = document.getElementsByClassName('article_date');
        let article_section = document.getElementsByClassName('article_section');
        for (let i = 0; i < 4; i++) {
            article_title[i].innerHTML = articles_data[i].title;
            article_desc[i].innerHTML = articles_data[i].tdesc;            
        }
        console.log(articles_data[0].tdate);
        article_date[0].innerHTML = articles_data[0].tdate;
        article_section[0].innerHTML = articles_data[0].tsection;
    }
};


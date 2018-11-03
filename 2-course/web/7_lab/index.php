<html>

<head>
  <meta http-equiv="content-type" content="text/html;charset=utf-8" />
  <link rel="stylesheet" href="css/main.css" type="text/css" />
  <script src="script.js"></script>
  <title>Зразок оформлення веб-сторінки</title>
</head>

<body>

<?php 
    //  Connecting to database
        $con = mysqli_connect("localhost", "fluoxe7ine", "123456qwerty", "lab7");
        if (!$con) {
            echo "Error: " . mysqli_connect_error();
            exit();
        }

        // title
        if ($_POST['title'] != "") {
          $sql = "UPDATE main_data SET title = '" . $_POST['title'] . "'";
          if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        }

        // footer
        if ($_POST['footer'] != "") {
          $sql = "UPDATE main_data SET footer = '" . $_POST['footer'] . "'";
          if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        }

        // more

        if ($_POST['more'] != "") {
          $sql = "UPDATE main_data SET more = '" . $_POST['more'] . "'";
          if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        }

        //menu

        if ($_POST['newMenuElem'] != "") {
          $sql = "INSERT INTO menu(menu_title) VALUES('{$_POST['newMenuElem']}')";
          if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        }

        if ($_POST['removeMenuElem'] != "") {
          $sql = "DELETE FROM menu WHERE menu_title = '{$_POST['removeMenuElem']}'";
          if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        }

        if ($_POST['article-title'] != "" && $_POST['article-desc'] != "" && $_POST['article-date'] != "" && $_POST['article-section'] != "") {
          $sql = "INSERT INTO articles(title, tdesc, tdate, tsection) VALUES ('{$_POST['article-title']}', '{$_POST['article-desc']}', '{$_POST['article-date']}', '{$_POST['article-section']}')";
          if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        }
?>

  <div id="content">
    <div class="menu">
      <h1 id="main-title">Title</h1>
      <ul id="menu">
    
      </ul>
    </div>
    <div class="post">
      <div class="details">
        <h2><a class="article_title" href="#">Тут щось <br> незрозуміле</a></h2>
        <p class="info">опубліковано <span class="article_date"></span> у секції <a class="article_section" href="#">загальне</a></p>
      </div>
      <div class="body">
        <p class="article_desc">Тут щось незрозуміле написано, треба розбиратись. Отаке тут щось незрозуміле написано, а часу розбиратись немає. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim
          ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. </p>
      </div>
      <div class="x"></div>
    </div>
    <div class="cols">
      <div class="col">
        <h3><a class="article_title" href="#">І тут не ясно</a></h3>
        <p class="article_desc">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. </p>
        <p class="det">&not; <a class="det_but" href="#">детальніше</a></p>
      </div>
      <div class="col">
        <h3><a class="article_title" href="#">А тут взагалі абзац</a></h3>
        <p class="article_desc">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. </p>
        <p class="det">&not; <a class="det_but" href="#">детальніше</a></p>
      </div>
      <div class="col last">
        <h3><a class="article_title" href="#">Може я піду?</a></h3>
        <p class="article_desc">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. </p>
        <p class="det">&not; <a class="det_but" href="#">детальніше</a></p>
      </div>
    </div>
    <div id="footer">
      <p id="main-footer">Copyright &copy; 2018 <em>Козирєв О.А. &laquo;Основи клієнтської розробки&raquo;</em> &middot; Design: ІП-71, <a href="http://asu.kpi.ua/" title="ACOI KПI">ACОIУ KПI</a></p>
    </div>
  </div>
</body>

</html>
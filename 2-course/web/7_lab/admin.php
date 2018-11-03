<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Admin-panel</title>
</head>
<body>

    <form action="index.php" method="post">
        Title: <input type="text" name="title">
        <br>
        Footer: <input type="text" name="footer">
        <br>
        More: <input type="text" name="more">
        <br>
        Menu: Add element: <input type="text" name="newMenuElem"><br>
        Remove element: <input type="text" name="removeMenuElem"><br>

        Add article: <br>
        Title: <input type="text" name="article-title"><br>
        Description: <input type="text" name="article-desc"><br>
        Date: <input type="date" name="article-date"><br>
        Section: <input type="text" name="article-section"><br>

        <input type="submit" value="Submit">
    </form>

</body>
</html>
<html> 
    <head>
        <title>6_Lab</title>
    </head> 
<body> 
    <style>
        h2 {
            text-align: center;
        }
        table {
            margin: auto;
        }
        td {
            width: 100px;
            height: 30px;
        }
        #table-4 tr:not(:first-child){
            height: 30px;
        }
    </style>
    <form action="6_lab.php" method="post"> 
        <input type="text" name="width" placeholder="Введіть ширину таблиці">
        <input type="text" name="height" placeholder="Введіть висоту таблиці">
        <input type="submit" value="Створити таблицю">
    </form>

    <?php 
        $con = mysqli_connect("localhost", "fluoxe7ine", "123456qwerty", "lab6");
        if (!$con) {
            echo "Error: " . mysqli_connect_error();
            exit();
        }
        echo 'Connected to MySQL<br/>';

        $cols = ( $_POST['width'] == '' ) ? 6 : $_POST['width'];
        $rows = ( $_POST['height'] == '' ) ? 6 : $_POST['height'];
       
        function makeCell() {
            $counter = 0;
            return function($td_true, $td_false) use (&$counter) {
                $counter++;
                if ($counter % 4 == 0) {
                    return $td_true;
                } else return $td_false;
            };
        };

        $first_table = makeCell();
        $second_table = makeCell();
        $third_table = makeCell();
        $fourth_table = makeCell();

        if ($rows != $cols || $rows <= 0 || $cols <= 0 || (int)$cols == 0 || (int)$rows == 0) {
            echo "invalid data for table 1<br/>";
            $sql = "INSERT INTO invalid_data(table_number, width, height) VALUES(1, \"{$cols}\",\"{$rows}\")";
            if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        } else {
            //first table
            $sql = "INSERT INTO valid_data(table_number, width, height) VALUES(1, \"{$cols}\",\"{$rows}\")";
            if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;

            echo '<h2>Table 1</h2>';
            echo '<table border="1">';
            $first_cell_counter++;
            echo '<tr><td colspan="'.$cols.'"></td></tr>';
            for ($tr=1; $tr<$rows; $tr++){ 
                $buff = $rows-$tr;
                echo '<tr>';
                echo $first_table("<td rowspan=\"{$buff}\">4</td>", "<td rowspan=\"{$buff}\"></td>");
                echo $first_table("<td colspan=\"{$buff}\">4</td>", "<td colspan=\"{$buff}\"></td>");               
                echo '</tr>';
            }
            echo '</table>';
        }

        if ($rows != $cols || $rows <= 0 || $cols <= 0 || (int)$cols == 0 || (int)$rows == 0) {
            echo "invalid data for table 2<br/>";
            $sql = "INSERT INTO invalid_data(table_number, width, height) VALUES(2, \"{$cols}\",\"{$rows}\")";
            if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        } else {
            $sql = "INSERT INTO valid_data(table_number, width, height) VALUES(1, \"{$cols}\",\"{$rows}\")";
            if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;

            echo '<h2>Table 2</h2>';
            echo '<table border="1">';   
            for ($tr = 0; $tr < $rows-1; $tr++) {
                $rowspan = ($rows - $tr) < 0 ? 0 : ($rows - $tr); 
                $colspan = ($rows - $tr - 1) < 0 ? 0 : ($rows - $tr -1);
                echo '<tr>';
                echo $second_table("<td rowspan=\"{$rowspan}\">4</td>", "<td rowspan=\"{$rowspan}\"></td>");
                echo $second_table("<td colspan=\"{$colspan}\">4</td>", "<td colspan=\"{$colspan}\"></td>");
                echo '</tr>';
            }
            $second_cell_counter++;
            echo $second_table('<tr><td>4</td></tr>', '<tr><td></td></tr>');
            echo '</table>';
        }

        if ($rows != $cols || $rows <= 0 || $cols <= 0 || (int)$cols == 0 || (int)$rows == 0) {
            echo "invalid data for table 3<br/>";
            $sql = "INSERT INTO invalid_data(table_number, width, height) VALUES(3, \"{$cols}\",\"{$rows}\")";
            if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        } else {
            $sql = "INSERT INTO valid_data(table_number, width, height) VALUES(1, \"{$cols}\",\"{$rows}\")";
            if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;

            echo "<h2> Table 3 </h2>";
            echo "<table border=\"1\" style=\"table-layout:fixed; width: 60%;\">";
            for ($tr = 0; $tr < $rows; $tr++) {
                if ($tr % 2 == 0) {
                    echo "<tr>";
                    echo $third_table("<td colspan=\"2\">4</td>", "<td colspan=\"2\"></td>");
                    echo $third_table("<td colspan=\"2\">4</td>", "<td colspan=\"2\"></td>");
                    echo $third_table("<td colspan=\"2\">4</td>", "<td colspan=\"2\"></td>");
                    echo $third_table("<td>4</td>", "<td></td>");
                    echo "</tr>";
                } else {
                    echo "<tr>";
                    echo $third_table("<td>4</td>", "<td></td>");
                    echo $third_table("<td colspan=\"2\">4</td>", "<td colspan=\"2\"></td>");
                    echo $third_table("<td colspan=\"2\">4</td>", "<td colspan=\"2\"></td>");
                    echo $third_table("<td colspan=\"2\">4</td>", "<td colspan=\"2\"></td>");
                    echo "</tr>";
                }
            } 
            echo "</table>";
        }

        if ($cols % 3 != 0 || $rows < 5 || $rows <= 0 || $cols <= 0 || (int)$cols == 0 || (int)$rows == 0) {
            echo "invalid data for table 4<br/>";
            $sql = "INSERT INTO invalid_data(table_number, width, height) VALUES(4, \"{$cols}\",\"{$rows}\")";
            if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;
        } else {
            $sql = "INSERT INTO valid_data(table_number, width, height) VALUES(1, \"{$cols}\",\"{$rows}\")";
            if (!$con->query($sql)) echo "Error: " . $sql . "<br>" . $con->error;

            echo "<h2> Table 4 </h2>";
            echo "<table id=\"table-4\" border=\"1\" style=\"table-layout:fixed; width: 60%;\">";
            echo "<tr>";
                for ($td = 0; $td < $cols; $td++) {
                    switch($td % 3) {
                        case 0:
                            echo $fourth_table("<td rowspan=\"3\">4</td>", "<td rowspan=\"3\"></td>");
                            break;
                        case 1:
                            echo $fourth_table("<td rowspan=\"1\">4</td>", "<td rowspan=\"1\"></td>");
                            break;
                        case 2:
                            echo $fourth_table("<td rowspan=\"2\">4</td>", "<td rowspan=\"2\"></td>");
                            break;
                    }
                }
            echo "</tr>";
    
            for ($tr = 0; $tr < $rows - 5; $tr++) {
                echo "<tr>";
                for ($td = 0; $td < $cols / 3; $td++) {
                    echo $fourth_table("<td rowspan=\"3\">4</td>","<td rowspan=\"3\"></td>");
                }
                echo "</tr>";
            }
    
            echo "<tr>";
            for ($td = 0; $td < $cols / 3; $td++) {
                echo $fourth_table("<td rowspan=\"3\">4</td>","<td rowspan=\"3\"></td>");
            }
            echo "</tr>";
            echo "<tr>";
            for ($td = 0; $td < $cols / 3; $td++) {
                echo $fourth_table("<td rowspan=\"2\">4</td>","<td rowspan=\"2\"></td>");
            }
            echo "</tr>";
            echo "<tr>";
            for ($td = 0; $td < $cols / 3; $td++) {
                echo $fourth_table("<td>4</td>","<td></td>");
            }
            echo "</tr>";
            echo "</table>";
        }
    ?> 
</body> 
</html>
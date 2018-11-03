<?php 
    $conn = mysqli_connect("localhost", "fluoxe7ine", "123456qwerty", "lab7");
    $result = mysqli_query($conn, "SELECT * FROM articles");
    
    $data = array();

    while ($row = mysqli_fetch_assoc($result)) {
        $data[] = $row;
    }
    echo json_encode($data);
?>

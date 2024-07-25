<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>site teste php</title>
</head>
<body>
  <h1>Hello World</h1> 
   <?php
    $nome = "Isabely";
    echo "<p>Bem vinde $nome</p>"; 
    $a = 10;
    $b = 20;
    $soma = $a + $b;
    echo "A soma de $a + $b é igual a $soma";
    echo "<br>";

    $status = true;

    if($status == true){
        echo "ESTÁ ATIVO";
    } 
    else {
        echo "ESTÁ DESLIGADO";
    }

    echo "<hr>";

    for($i = 1;$i<=1000;$i++){
        if($i%2 == 0)
        echo "$i <br>";
    }


    ?>
</body>
</html>
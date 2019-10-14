<?php
  include __DIR__ . './src/functions.php';
  
  
  $id_prova = (int) $_GET['id_prova'];
$test = array( );
$dataPoints = array(
	 
);
$Resultado = getResults($id_prova);
  
 $Pessimo = 0;
 $Ruim = 0;
 $Bom = 0;
 $Regular = 0;
 $Otimo = 0;
 $NaoSei = 0;
		foreach($questoes = getQuestoesByProvaId($id_prova) as $questao)
  {
	  
	  if($sResultado = getQuestoesProva($id_prova,$questao->id))
	  {
		  $Pessimo += $sResultado->Pessimo;
		   $Ruim += $sResultado->Ruim;
		    $Bom += $sResultado->Bom;
			 $Regular += $sResultado->Regular;
			  $Otimo += $sResultado->Otimo;
			  $NaoSei += $sResultado->NaoSei;
	  }
	  
	  
 
  }
		
	  $dataPoints[] = array("label"=> "1.Péssimo","y"=> $Pessimo );
	  $dataPoints[] = array("label"=> "2.Ruim","y"=> $Ruim );
	  $dataPoints[] = array("label"=> "3.Bom","y"=> $Bom );
	  $dataPoints[] = array("label"=> "4.Regular","y"=> $Regular );
	  $dataPoints[] = array("label"=> "5.Ótimo","y"=> $Otimo );
	  $dataPoints[] = array("label"=> "6.Nao Sei","y"=> $NaoSei );
	  $titulo = "".$Resultado->letivo."-".$Resultado->titulo." ".$Resultado->nome."";

 
?>
<!DOCTYPE HTML>
<html>
<head>
  <script type="text/javascript">
  window.onload = function () {
    var chart = new CanvasJS.Chart("chartContainer",
    {
      title:{
        text: "<?php echo utf8_decode($titulo); ?>",
      },subtitles: [{
		text: "FESSULPA"
	}],axisY: {
		title: "Questoes",
		includeZero: false
	},
      data: [

      {
        dataPoints: <?php echo json_encode($dataPoints, JSON_NUMERIC_CHECK); ?>
      }
      ]
    });

    chart.render();
  }
  </script>
</head>
<body>
<div id="chartContainer" style="height: 370px; width: 25%;"></div>
<script src="https://canvasjs.com/assets/script/canvasjs.min.js"></script>
</body>
</html>    










 
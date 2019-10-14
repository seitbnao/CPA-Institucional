<?php

if (isset($_GET['id_prova']) && is_numeric($_GET['id_prova'])) {
    
    /**
     * Inclui o arquivo de funções
     */
    include __DIR__ . './src/functions.php';

    if (! isset($_GET['id_prova'])) {
        responseError('ID da prova não foi passado.');
    }
 
    /**
     * ID da prova
     * @var integer
     */
    $id_prova = (int) $_GET['id_prova'];
$test = array( );

$conteudo = '';
    if($Resultado = getResults($id_prova))
	{
		 $conteudo = '<table style="height: 50px; margin-left: auto; margin-right: auto; width: 585px;">
<tbody>
<tr>
<td style="width: 171.5px;"><strong>&nbsp;Prova</strong></td>
<td style="width: 399.5px;">'.$Resultado->titulo.' : '.$Resultado->nome.' <a target="new" href="./grafico.php?id_prova='.$id_prova.'">Ver Gráfico</a></td>
</tr>
<tr>
<td style="width: 171.5px;"><strong>&nbsp;Per&iacute;odo Letivo</strong></td>
<td style="width: 399.5px;">'.$Resultado->letivo.'</td>
</tr>
</tbody>
</table>
 
<p style="text-align: center;"><strong>Quest&otilde;es</strong></p>
<p style="text-align: center;"><strong><span style="color: #ff0000;">1-P&eacute;ssimo</span>&nbsp; <span style="color: #ff6600;">2-Ruim</span>&nbsp; <span style="color: #ffcc00;">3-Regular</span>&nbsp; <span style="color: #0000ff;">4-Bom</span>&nbsp; <span style="color: #00ff00;">5-&Oacute;timo</span>&nbsp; &nbsp;<span style="color: #000000;">6-NOS (N&atilde;o sei Opinar)</span></strong></p>
<table style="width: 572px; margin-left: auto; margin-right: auto; height: 67px;">
<tbody>
<tr>
<td style="width: 330px; text-align: center;"><strong>Pergunta</strong></td>
<td style="width: 228px; text-align: center;"><strong>Resposta (QTD)</strong></td>
</tr>';


 
	  
  foreach($questoes = getQuestoesByProvaId($id_prova) as $questao)
  {
	  
	  $sResultado = getQuestoesProva($id_prova,$questao->id);
	 
		  
	  $conteudo .= '
<tr>
<td style="width: 330px;">'.$sResultado->questao.'</td>
<td style="width: 228px;">&nbsp;<strong>1(</strong>'.$sResultado->Pessimo.'<strong>) 2(</strong>'.$sResultado->Ruim.'<strong>) 3(</strong>'.$sResultado->Regular.'<strong>) 4(</strong>'.$sResultado->Bom.'<strong>) 5(</strong>'.$sResultado->Otimo.'<strong>) 6(</strong>'.$sResultado->NaoSei.'<strong>)</strong></td>
</tr>';
	  
  }

$test[] = array("label"=> $sResultado->questao, "y"=> 51);



$conteudo .= '
</tbody>
</table>';
	}
    
	
	
	
	
 
	
	
	
	
    $retorno = [
        'conteudo' => $conteudo,
		'empty' => empty($conteudo),
    ];

    
    responeSuccess($retorno);
}
?>



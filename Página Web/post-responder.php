<?php
session_start();
include __DIR__ . './src/functions.php';
if($_SERVER['REQUEST_METHOD'] == 'POST') {

    /**
     * Inclui o arquivo de funções
     */
   

    try {
        
		
        $historico_id = saveHistorico(LastAluno( ), (int) $_POST['id_prova']);
 
        foreach ($_POST['respostas'] as $questao_id => $resposta) {

            if (!empty($resposta)) {
                saveResposta($historico_id, $questao_id, $resposta);
            }
        }

        responeSuccess();

    } catch (\Exception $e) {
        responseError($e->getMessage());
    }
}
else
  responseError('Favor enviar a resposta via post.');
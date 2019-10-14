<?php
 
include __DIR__ . './src/functions.php';
if($_SERVER['REQUEST_METHOD'] == 'POST') {

    /**
     * Inclui o arquivo de funções
     */


    try {
        
		if(empty($_POST['valuno']))
		{
			responseError('Não deixe o campo sem preencher.');
			return true;
		}
		
        $return = saveAluno($_POST['valuno']);
         if($return)
		 {
			 
	 
		   responeSuccess();
		 }
		else
			responseError('INVALID REQUEST');

    } catch (\Exception $e) {
        responseError($e->getMessage());
    }
}
else
responseError('Favor enviar a resposta via post.');
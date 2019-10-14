<?php
 
/**
 * @return \PDO
 */
function pdo($params = [])
{
    $p = (object) array_merge([
        'driver' => 'mysql',
        'host' => 'localhost',
        'dbname' => 'provas',
        'username' => 'fessulpa_cpa',
        'password' => 'fessulpa2019'
    ], $params);

    $pdo = new PDO(
        // 'mysql:host=localhost;dbname=provas'
        sprintf('%s:host=%s;dbname=%s', $p->driver, $p->host, $p->dbname), 
        $p->username, 
        $p->password
    );

    $pdo->exec('set names utf8');
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    return $pdo;
}

/**
 * Insere no historico do aluno
 * 
 * @param $id_aluno
 * @param $id_prova
 * @return integer ID do historico salvo no banco
 */
 
 

 function LastAluno( )
{
    $pdo = pdo();
 
    $row = $pdo->query(' SELECT id FROM alunos ORDER BY id DESC LIMIT 1;');
 

    return $row->rowCount();
}
 
function saveHistorico($id_aluno, $id_prova)
{
    $pdo = pdo();
    
    $row = $pdo->prepare('INSERT INTO `historico` SET `alunos_id` = ?, `provas_id` = ?');
    $row->execute([$id_aluno, $id_prova]);

    return $pdo->lastInsertId();
}

/**
 * Insere no historico do aluno
 * 
 * @param $id_aluno
 * @param $id_prova
 * @return integer ID do historico salvo no banco
 */
 
 function saveAluno($value)
{    $pdo = pdo();
    $row = $pdo->prepare('INSERT INTO  `alunos` (`id`, `nome`) VALUES (NULL, ?);
    ');

    $row->execute([$value]);
	 if ($row->rowCount() == 0) {
        return false;
    }
	else
	{
		$_SESSION['ALUNO'] = $pdo->lastInsertId();
		return $pdo->lastInsertId();
	}
      
    
 
}

function saveResposta($id_historico, $id_questao, $resposta)
{   
    $row = pdo()->prepare('INSERT INTO `respostas` SET 
        `historico_id` = ?,
        `questoes_id` = ?, 
        `resposta` = ?
    ');

    $row->execute([$id_historico, $id_questao, $resposta]);
	 if ($row->rowCount() == 0) {
        return false;
    }
	else
		session_unset();
}

/**
 * Retorna do banco de dados o registro da prova
 * 
 * @param $id_prova integer
 * @return null      Prova não localizada
 * @return \stdClass Prova
 */ 
function getProvaById($id_prova)
{
    $row = pdo()->prepare('SELECT * FROM `tipo_avalia`,`provas` WHERE `provas`.`id` = ? and `tipo_avalia`.`id` = `provas`.`tipo_avalia_id`;');
    $row->execute([$id_prova]);

    if ($row->rowCount() == 0) {
        return null;
    }

    return $row->fetchObject();
}




function getQuestoesProva($id_prova,$id_questao)
{
    $row = pdo()->prepare("  
 SELECT 
    questoes.id,
    questoes.questao,
    (SELECT DISTINCT
            COUNT(*)
        FROM
            provas,
            questoes,
            respostas,
            historico,
            opcoes,
            tipo_avalia
        WHERE
            historico.provas_id = provas.id
                AND opcoes.id = respostas.resposta
                AND provas.id = questoes.provas_id
                AND respostas.questoes_id = questoes.id
                AND historico.id = respostas.historico_id
                AND tipo_avalia.id = provas.tipo_avalia_id
                AND questoes.provas_id = ?
                AND opcoes.opcao = '1.Péssimo'
                AND questoes.id = ?) AS Pessimo,
    (SELECT DISTINCT
            COUNT(*)
        FROM
            provas,
            questoes,
            respostas,
            historico,
            opcoes,
            tipo_avalia
        WHERE
            historico.provas_id = provas.id
                AND opcoes.id = respostas.resposta
                AND provas.id = questoes.provas_id
                AND respostas.questoes_id = questoes.id
                AND historico.id = respostas.historico_id
                AND tipo_avalia.id = provas.tipo_avalia_id
                AND questoes.provas_id = ?
                AND opcoes.opcao = '2.Ruim'
                AND questoes.id = ?) AS Ruim,
    (SELECT DISTINCT
            COUNT(*)
        FROM
            provas,
            questoes,
            respostas,
            historico,
            opcoes,
            tipo_avalia
        WHERE
            historico.provas_id = provas.id
                AND opcoes.id = respostas.resposta
                AND provas.id = questoes.provas_id
                AND respostas.questoes_id = questoes.id
                AND historico.id = respostas.historico_id
                AND tipo_avalia.id = provas.tipo_avalia_id
                AND questoes.provas_id = ?
                AND opcoes.opcao = '3.Regular'
                AND questoes.id = ?) AS Regular,
    (SELECT DISTINCT
            COUNT(*)
        FROM
            provas,
            questoes,
            respostas,
            historico,
            opcoes,
            tipo_avalia
        WHERE
            historico.provas_id = provas.id
                AND opcoes.id = respostas.resposta
                AND provas.id = questoes.provas_id
                AND respostas.questoes_id = questoes.id
                AND historico.id = respostas.historico_id
                AND tipo_avalia.id = provas.tipo_avalia_id
                AND questoes.provas_id = ?
                AND opcoes.opcao = '4.Bom'
                AND questoes.id = ?) AS Bom,
    (SELECT DISTINCT
            COUNT(*)
        FROM
            provas,
            questoes,
            respostas,
            historico,
            opcoes,
            tipo_avalia
        WHERE
            historico.provas_id = provas.id
                AND opcoes.id = respostas.resposta
                AND provas.id = questoes.provas_id
                AND respostas.questoes_id = questoes.id
                AND historico.id = respostas.historico_id
                AND tipo_avalia.id = provas.tipo_avalia_id
                AND questoes.provas_id = ?
                AND opcoes.opcao = '5.Ótimo'
                AND questoes.id = ?) AS Otimo,
    (SELECT DISTINCT
            COUNT(*)
        FROM
            provas,
            questoes,
            respostas,
            historico,
            opcoes,
            tipo_avalia
        WHERE
            historico.provas_id = provas.id
                AND opcoes.id = respostas.resposta
                AND provas.id = questoes.provas_id
                AND respostas.questoes_id = questoes.id
                AND historico.id = respostas.historico_id
                AND tipo_avalia.id = provas.tipo_avalia_id
                AND questoes.provas_id = ?
                AND opcoes.opcao = '6.NOS (Não sei Opinar)'
                AND questoes.id = ?) AS NaoSei
FROM
    questoes,
    provas
WHERE
    questoes.provas_id = ?
        AND questoes.id = ?");
    $row->execute([$id_prova,$id_questao,$id_prova,$id_questao,$id_prova,$id_questao,$id_prova,$id_questao,$id_prova,$id_questao,$id_prova,$id_questao,$id_prova,$id_questao]);

    if ($row->rowCount() == 0) {
        return null;
    }

    return $row->fetchObject();
}




function getResults($id_prova)
{
    $row = pdo()->prepare(" SELECT    
    provas.id AS prova,
    questoes.questao,
    opcoes.id as IDOpcao,
    opcoes.opcao,
    provas.titulo,
    provas.letivo,
    tipo_avalia.nome,
    
    (SELECT DISTINCT
            COUNT(*)
        FROM
    provas,
    questoes,
    respostas,
    historico,
    opcoes,
    tipo_avalia
        WHERE
                historico.provas_id = provas.id
        AND opcoes.id = respostas.resposta
        AND provas.id = questoes.provas_id
        AND respostas.questoes_id = questoes.id
        AND historico.id = respostas.historico_id
        AND tipo_avalia.id = provas.tipo_avalia_id
        AND questoes.provas_id = ?  and opcoes.opcao = '5.Ótimo') AS Otimo,
        
        (SELECT DISTINCT
            COUNT(*)
        FROM
    provas,
    questoes,
    respostas,
    historico,
    opcoes,
    tipo_avalia
        WHERE
                historico.provas_id = provas.id
        AND opcoes.id = respostas.resposta
        AND provas.id = questoes.provas_id
        AND respostas.questoes_id = questoes.id
        AND historico.id = respostas.historico_id
        AND tipo_avalia.id = provas.tipo_avalia_id
        AND questoes.provas_id = ?  and opcoes.opcao = '2.Ruim') AS Ruim,
        
         (SELECT DISTINCT
            COUNT(*)
        FROM
    provas,
    questoes,
    respostas,
    historico,
    opcoes,
    tipo_avalia
        WHERE
                historico.provas_id = provas.id
        AND opcoes.id = respostas.resposta
        AND provas.id = questoes.provas_id
        AND respostas.questoes_id = questoes.id
        AND historico.id = respostas.historico_id
        AND tipo_avalia.id = provas.tipo_avalia_id
        AND questoes.provas_id = ?  and opcoes.opcao = '1.Péssimo') AS Pessimo,
        
        
         (SELECT DISTINCT
            COUNT(*)
        FROM
    provas,
    questoes,
    respostas,
    historico,
    opcoes,
    tipo_avalia
        WHERE
                historico.provas_id = provas.id
        AND opcoes.id = respostas.resposta
        AND provas.id = questoes.provas_id
        AND respostas.questoes_id = questoes.id
        AND historico.id = respostas.historico_id
        AND tipo_avalia.id = provas.tipo_avalia_id
        AND questoes.provas_id = ?  and opcoes.opcao = '4.Bom') AS Bom,
        
        
         (SELECT DISTINCT
            COUNT(*)
        FROM
    provas,
    questoes,
    respostas,
    historico,
    opcoes,
    tipo_avalia
        WHERE
                historico.provas_id = provas.id
        AND opcoes.id = respostas.resposta
        AND provas.id = questoes.provas_id
        AND respostas.questoes_id = questoes.id
        AND historico.id = respostas.historico_id
        AND tipo_avalia.id = provas.tipo_avalia_id
        AND questoes.provas_id = ?  and opcoes.opcao = '3.Regular') AS Regular,
        
        
         (SELECT DISTINCT
            COUNT(*)
        FROM
    provas,
    questoes,
    respostas,
    historico,
    opcoes,
    tipo_avalia
        WHERE
                historico.provas_id = provas.id
        AND opcoes.id = respostas.resposta
        AND provas.id = questoes.provas_id
        AND respostas.questoes_id = questoes.id
        AND historico.id = respostas.historico_id
        AND tipo_avalia.id = provas.tipo_avalia_id
        AND questoes.provas_id = ?  and opcoes.opcao = '6.NOS (Não sei Opinar)') AS NaoSei
        
        
FROM
    provas,
    questoes,
    respostas,
    historico,
    opcoes,
    tipo_avalia
WHERE
    historico.provas_id = provas.id
        AND opcoes.id = respostas.resposta
        AND provas.id = questoes.provas_id
        AND respostas.questoes_id = questoes.id
        AND historico.id = respostas.historico_id
        AND tipo_avalia.id = provas.tipo_avalia_id
        AND questoes.provas_id = ? ");
    $row->execute([$id_prova,$id_prova,$id_prova,$id_prova,$id_prova,$id_prova,$id_prova]);

    if ($row->rowCount() == 0) {
        return null;
    }

    return $row->fetchObject();
}










function AplicDefaultQuestions($prova_id)
{$row = pdo()->prepare("INSERT INTO `opcoes` (  `opcao`, `questoes_id`) VALUES
( '1.Péssimo', ?),
( '2.Ruim', ?),
( '3.Regular', ?),
( '4.Bom', ?),
( '5.Ótimo   ', ?),
( '6.NOS (Não sei Opinar)', ?);");
    $row->execute([$id_prova,$id_prova,$id_prova,$id_prova,$id_prova,$id_prova]);

    if ($row->rowCount() == 0) {
        return null;
    }

    return $row->fetchObject();
	
}
/**
 * Retorna todas as provas do banco de dados
 * @return array
 */
function getProvas()
{
    $rows = pdo()->query('SELECT * FROM `provas` WHERE `status` = 1 ORDER BY `id` DESC');
    return $rows->fetchAll(\PDO::FETCH_OBJ);
}

/**
 * Retorna todas as provas do banco de dados
 * @return array
 */
 
 
function getProvasParaResultados()
{
 
	    $rows = pdo()->query('  SELECT 
    (SELECT 
            COUNT(*)
        FROM
            historico,
            tipo_avalia
        WHERE
            provas_id = provas.id AND alunos_id is not null
                AND tipo_avalia.id = tipo_avalia_id) AS tentativas,
    `provas`.*,`tipo_avalia`.`nome`
FROM
    `provas`,`tipo_avalia`
WHERE
    `provas`.`status` is not null and `provas`.`tipo_avalia_id` = `tipo_avalia`.`id`');
	
	 
    return $rows->fetchAll(\PDO::FETCH_OBJ);
}
 
function getProvasNaoRespondidasByAlunoId($id_aluno)
{
    $rows = pdo()->prepare('
      SELECT 
    (SELECT 
            COUNT(*)
        FROM
            historico,
            tipo_avalia
        WHERE
            provas_id = provas.id AND alunos_id is not null
                AND tipo_avalia.id = tipo_avalia_id) AS tentativas,
    `provas`.*,`tipo_avalia`.`nome`
FROM
    `provas`,`tipo_avalia`
WHERE
    `provas`.`status` = ? and `provas`.`tipo_avalia_id` = `tipo_avalia`.`id`
ORDER BY `provas`.`id` DESC
    ');
    $id_aluno = 1;
    $rows->execute([$id_aluno]);

    return array_filter($rows->fetchAll(\PDO::FETCH_OBJ), function ($row) {
        return $row->tentativas >= 0;
    });
}

/**
 * Retorna do banco de dados todas as questões da prova
 * 
 * @param $id_prova integer
 * @return array
 */
function getQuestoesByProvaId($id_prova)
{
    $rows = pdo()->prepare('SELECT * FROM `questoes` WHERE `provas_id` = ?');
    $rows->execute([$id_prova]);

    return $rows->fetchAll(\PDO::FETCH_OBJ);
}

/**
 * Retorna do banco de dados todas as opções da questão
 * 
 * @param $id_questao integer
 * @return array
 */
function getOpcoesByquestaoId($id_questao)
{
    $rows = pdo()->prepare("SELECT * FROM `opcoes` WHERE `questoes_id` = ?");
    $rows->execute([$id_questao]);

    return $rows->fetchAll(\PDO::FETCH_OBJ);
}

/**
 * Responde com JSON
 * 
 * @param $body array
 * @return JSON
 */
function responseJson($body)
{
    header('Content-Type: application/json');
    die(json_encode($body));
}

/**
 * @param $message Mensagem detalhando o erro ao usuário
 * @return JSON
 */
function responseError($message = null)
{
    return responseJson([
        'status' => 'no', 
        'message' => $message
    ]);
}

/**
 * @param $data array
 * @return JSON
 */
function responeSuccess($data = [])
{
    $response = [
        'status' => 'ok'
    ];

    return responseJson(array_merge($response, $data));
}
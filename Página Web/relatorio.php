<?php include __DIR__ . './src/functions.php' ?>

<!DOCTYPE HTML>
<html lang="pt-BR">
    <head>
        <meta charset=UTF-8>
        <title>Provas</title>
        <link href="css/style.css" rel="stylesheet" type="text/css"/>
		
    </head>

    <body>
        <section id="wrap-geral">
            <ul id="prova-lista">
            
		 
                <?php foreach ($provas = getProvasParaResultados( ) as $prova):;  ?>

                <li class="open-prova prova<?php echo $prova->id ?>" data-id="<?php echo $prova->id ?>">
                    <a href><?php echo $prova->letivo.'-'.$prova->titulo.' - Diagnostico com: '.$prova->nome ?></a>
                </li>

                <?php endforeach ?>

                <?php if (! $prova) : ?>
                <li>Não há provas para responder</li>
                <?php endif ?>
            </ul>

            <section id="wrap-prova">
                <div class="begin">
                    <button id="mostrarrelatorio" class="button azul">Ver Relatório</button>
                </div>

                <div class="sucesso">
                    <p>A prova foi submetida para avaliação!</p>
                </div>

                <h1></h1>


                <div class="resultados" id="resultados_fnais"></div>
 
            </section>

            <div style="clear:both;"></div>
             
        </section>
        


    </body>
</html>
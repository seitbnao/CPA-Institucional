-- phpMyAdmin SQL Dump
-- version 4.1.6
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 24-Set-2019 às 00:22
-- Versão do servidor: 5.6.16
-- PHP Version: 5.5.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `provas`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `alunos`
--

CREATE TABLE IF NOT EXISTS `alunos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(40) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `eixos`
--

CREATE TABLE IF NOT EXISTS `eixos` (
  `id` int(4) NOT NULL,
  `nome` varchar(96) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `eixos`
--

INSERT INTO `eixos` (`id`, `nome`) VALUES
(1, '1 - QUANTO AO ENSINO'),
(2, '2 - QUANTO A COMUNICAÇÃO E INFORMAÇÃO'),
(3, '3 - QUANTO A EXTENSÃO '),
(4, '4 - QUANTO A PESQUISA'),
(5, '5 - QUANTO AO AMBIENTE E CONDIÇÕES DE TRABALHO '),
(6, '6 - QUANTO A ORGANIZAÇÃO E OBJETIVOS INSTITUCIONAIS');

-- --------------------------------------------------------

--
-- Estrutura da tabela `historico`
--

CREATE TABLE IF NOT EXISTS `historico` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `alunos_id` int(11) NOT NULL,
  `provas_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `opcoes`
--

CREATE TABLE IF NOT EXISTS `opcoes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `opcao` varchar(200) NOT NULL,
  `questoes_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_opcoes_questoes1_idx` (`questoes_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=25 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `provas`
--

CREATE TABLE IF NOT EXISTS `provas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(200) NOT NULL,
  `tempo` int(11) NOT NULL DEFAULT '80',
  `status` int(11) NOT NULL DEFAULT '1',
  `tipo_avalia_id` int(11) NOT NULL,
  `letivo` varchar(8) NOT NULL DEFAULT '2019/2',
  PRIMARY KEY (`id`,`tipo_avalia_id`),
  KEY `fk_provas_tipo_avalia1_idx` (`tipo_avalia_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `questoes`
--

CREATE TABLE IF NOT EXISTS `questoes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `questao` varchar(200) NOT NULL,
  `tipo` int(11) NOT NULL,
  `provas_id` int(11) NOT NULL,
  `eixo` int(4) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_questoes_provas_idx` (`provas_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=71 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `respostas`
--

CREATE TABLE IF NOT EXISTS `respostas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `resposta` varchar(255) NOT NULL,
  `questoes_id` int(11) NOT NULL,
  `historico_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_respostas_questoes1_idx` (`questoes_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=112 ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipo_avalia`
--

CREATE TABLE IF NOT EXISTS `tipo_avalia` (
  `id` int(11) NOT NULL,
  `nome` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tipo_avalia`
--

INSERT INTO `tipo_avalia` (`id`, `nome`) VALUES
(1, 'Técnico Administrativo'),
(2, 'Corpo Docente'),
(3, 'Corpo Discente'),
(4, 'Comunidade');

-- --------------------------------------------------------

--
-- Estrutura da tabela `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `login` varchar(16) NOT NULL,
  `pass` varchar(16) NOT NULL,
  `type` int(2) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `user`
--

INSERT INTO `user` (`id`, `login`, `pass`, `type`) VALUES
(1, 'djunio', 'filho', 0),
(2, 'admin', 'admin', 0);

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `opcoes`
--
ALTER TABLE `opcoes`
  ADD CONSTRAINT `fk_opcoes_questoes1` FOREIGN KEY (`questoes_id`) REFERENCES `questoes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `provas`
--
ALTER TABLE `provas`
  ADD CONSTRAINT `fk_provas_tipo_avalia1` FOREIGN KEY (`tipo_avalia_id`) REFERENCES `tipo_avalia` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `questoes`
--
ALTER TABLE `questoes`
  ADD CONSTRAINT `fk_questoes_provas` FOREIGN KEY (`provas_id`) REFERENCES `provas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `respostas`
--
ALTER TABLE `respostas`
  ADD CONSTRAINT `fk_respostas_questoes1` FOREIGN KEY (`questoes_id`) REFERENCES `questoes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 16-Set-2020 às 02:47
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cadastro`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cursos`
--

CREATE TABLE `cursos` (
  `id_curso` int(11) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `descricao` text DEFAULT NULL,
  `carga` int(10) UNSIGNED DEFAULT NULL,
  `total_aulas` int(10) UNSIGNED DEFAULT NULL,
  `ano` year(4) DEFAULT 2016
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cursos`
--

INSERT INTO `cursos` (`id_curso`, `nome`, `descricao`, `carga`, `total_aulas`, `ano`) VALUES
(1, 'HTML5', 'CURSO DE HTML5', 40, 37, 2014),
(2, 'Algoritmos', 'Logica de Programacao', 20, 15, 2014),
(3, 'PHOTOSHOP', 'Dicas de Photoshop CC', 10, 8, 2014),
(4, 'PHP', 'Curso de PHP para iniciantes', 40, 20, 2015),
(5, 'Java', 'Introducao a linguagem Java', 40, 29, 2015),
(6, 'MySQL', 'Bancos de Dados MySQL', 30, 15, 2016),
(7, 'Word', 'Curso Completo de Word', 40, 30, 2016);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoas`
--

CREATE TABLE `pessoas` (
  `id` int(11) NOT NULL,
  `nome` varchar(30) NOT NULL,
  `nascimento` date NOT NULL,
  `sexo` enum('M','F') DEFAULT NULL,
  `peso` decimal(5,2) DEFAULT NULL,
  `altura` decimal(3,2) DEFAULT NULL,
  `nacionalidade` varchar(15) DEFAULT 'Brasil'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `pessoas`
--

INSERT INTO `pessoas` (`id`, `nome`, `nascimento`, `sexo`, `peso`, `altura`, `nacionalidade`) VALUES
(1, 'Lucas', '2001-07-03', 'M', '49.00', '1.65', 'Brasil'),
(2, 'Casey', '2002-07-03', 'F', '67.00', '1.75', 'EUA'),
(3, 'Josh', '2001-03-28', 'M', '52.00', '1.62', 'Alemanha'),
(4, 'Jacob', '1999-08-22', 'M', '46.00', '1.58', 'Brasil'),
(5, 'Clhoe', '2003-08-23', 'F', '45.00', '1.55', 'Brasil'),
(6, 'Joey', '2000-03-21', 'M', '73.00', '1.81', 'Mexico');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cursos`
--
ALTER TABLE `cursos`
  ADD PRIMARY KEY (`id_curso`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `pessoas`
--
ALTER TABLE `pessoas`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cursos`
--
ALTER TABLE `cursos`
  MODIFY `id_curso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `pessoas`
--
ALTER TABLE `pessoas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19-Ago-2020 às 06:17
-- Versão do servidor: 10.4.13-MariaDB
-- versão do PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `corretoradeseguros`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `segurado`
--

CREATE TABLE `segurado` (
  `idSegurado` int(11) NOT NULL,
  `idVeiculoSegurado` int(11) NOT NULL,
  `idSeguradoSegurado` int(11) NOT NULL,
  `nomeSegurado` varchar(50) NOT NULL,
  `generoSegurado` varchar(1) NOT NULL,
  `cidadeSegurado` varchar(30) NOT NULL,
  `anoNascimentoSegurado` varchar(4) NOT NULL,
  `ativoSegurado` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `segurado`
--

INSERT INTO `segurado` (`idSegurado`, `idVeiculoSegurado`, `idSeguradoSegurado`, `nomeSegurado`, `generoSegurado`, `cidadeSegurado`, `anoNascimentoSegurado`, `ativoSegurado`) VALUES
(1, 1, 1, 'João da Silva', 'M', 'Florianópolis', '1990', 0),
(2, 2, 2, 'Carlos Alberto de Souza', 'M', 'Palhoça', '1969', 0),
(3, 3, 3, 'Luiz Henrique Camargo', 'M', 'São José', '1982', 0),
(4, 4, 4, 'Maria Luíza de Matos', 'F', 'Biguaçu', '2001', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `seguradora`
--

CREATE TABLE `seguradora` (
  `idSeguradora` int(11) NOT NULL,
  `nomeSeguradora` varchar(20) NOT NULL,
  `cobertura` varchar(20) NOT NULL,
  `ativoSeguradora` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `seguradora`
--

INSERT INTO `seguradora` (`idSeguradora`, `nomeSeguradora`, `cobertura`, `ativoSeguradora`) VALUES
(1, 'Porto Seguro', 'Seguro Total', 0),
(2, 'Liberty', 'Seguro Total', 0),
(3, 'Hdi', 'Seguro Total', 0),
(4, 'Allianz', 'Contra Terceiros', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculo`
--

CREATE TABLE `veiculo` (
  `idVeiculo` int(11) NOT NULL,
  `marcaVeiculo` varchar(15) NOT NULL,
  `modeloVeiculo` varchar(15) NOT NULL,
  `anoVeiculo` varchar(4) NOT NULL,
  `ativoVeiculo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `veiculo`
--

INSERT INTO `veiculo` (`idVeiculo`, `marcaVeiculo`, `modeloVeiculo`, `anoVeiculo`, `ativoVeiculo`) VALUES
(1, 'Fiat', 'Palio', '1999', 0),
(2, 'Chevrolet', 'Onix', '2019', 0),
(3, 'Renault', 'Clio', '2005', 0),
(5, 'Ford', 'Fiesta', '2015', 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `segurado`
--
ALTER TABLE `segurado`
  ADD PRIMARY KEY (`idSegurado`);

--
-- Índices para tabela `seguradora`
--
ALTER TABLE `seguradora`
  ADD PRIMARY KEY (`idSeguradora`);

--
-- Índices para tabela `veiculo`
--
ALTER TABLE `veiculo`
  ADD PRIMARY KEY (`idVeiculo`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `segurado`
--
ALTER TABLE `segurado`
  MODIFY `idSegurado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `seguradora`
--
ALTER TABLE `seguradora`
  MODIFY `idSeguradora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `veiculo`
--
ALTER TABLE `veiculo`
  MODIFY `idVeiculo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

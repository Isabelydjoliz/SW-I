-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26-Set-2024 às 16:46
-- Versão do servidor: 10.4.27-MariaDB
-- versão do PHP: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cadastro_cliente`
--
CREATE DATABASE IF NOT EXISTS `cadastro_cliente` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `cadastro_cliente`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `id_cliente` int(11) NOT NULL,
  `nome_cliente` varchar(255) NOT NULL,
  `email_cliente` varchar(255) NOT NULL,
  `telefone` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`id_cliente`, `nome_cliente`, `email_cliente`, `telefone`) VALUES
(1, 'Etec MCM', 'etecmcm@etec.sp.gov.br', '(11)98765-0000'),
(2, 'Café Central', 'contato@cafecentral.com.br', '(11)99999-0022'),
(3, 'Sorveteria Gelato', 'contato@gelato.com', '(11)98888-2345'),
(4, 'Pet Shop Amigo Fiel', 'info@amigofielpet.com', '(11)97777-3456'),
(5, 'Mercado Tudo Fresco', 'contato@tudofresco.com', '(11)96666-4567'),
(6, 'Hamburgueria Gourmet Grill', 'reservas@gourmetgrill.com', '(11)95555-5678'),
(7, 'Livraria Ponto de Leitura', 'atendimento@pontodeleitura.com', '(11)94444-6789'),
(8, 'Oficina AutoMaster', 'contato@automaster.com', '(11)93333-7890'),
(9, 'Lava Rápido Express', 'contato@lavaexpress.com', '(11)92222-8901'),
(10, 'Clínica Estética Bella Vida', 'contato@bellavida.com', '(11)91111-9012'),
(11, 'Doceria Encanto', 'info@doceriaencanto.com', '(11)90000-0123'),
(12, 'Estúdio Fotográfico Imagem & Arte', 'contato@imagemearte.com', '(11)89999-1234');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `senha` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `email`, `senha`) VALUES
(1, 'Isabely Djoliz Santos Rodrigues', 'isabelydjoliz@gmail.com', '81dc9bdb52d04dc20036dbd8313ed055');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

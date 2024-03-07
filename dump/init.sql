START TRANSACTION;

CREATE DATABASE IF NOT EXISTS empresaltda;

USE empresaltda;
START TRANSACTION;
CREATE TABLE IF NOT EXISTS `Empregados` (
    `Id` char(36) NOT NULL,
    `Nome` longtext NOT NULL,
    `Departamento` longtext NOT NULL,
    `Cargo` longtext NOT NULL,
    `Excluido` bit NOT NULL,
    PRIMARY KEY (`Id`)
);

CREATE TABLE IF NOT EXISTS `Empresa` (
    `Id` char(36) NOT NULL,
    `Nome` longtext NOT NULL,
    `Endereco` longtext NOT NULL,
    `Telefone` longtext NOT NULL,
    PRIMARY KEY (`Id`)
);

INSERT INTO `Empresa` (`Id`, `Endereco`, `Nome`, `Telefone`)
VALUES ('a3cb1222-7305-4aaa-b26b-5cc62214db5c', 'Endereço da Empresa', 'Nome da Empresa', '+55 (41) 99999-9999');


COMMIT;

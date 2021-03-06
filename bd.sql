-- MySQL Script generated by MySQL Workbench
-- Mon Jun 25 13:45:38 2018
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema ateliecostura
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ateliecostura
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ateliecostura` DEFAULT CHARACTER SET utf8 ;
USE `ateliecostura` ;

-- -----------------------------------------------------
-- Table `ateliecostura`.`table_cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_cliente` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `CPF` CHAR(11) NOT NULL,
  `cel_num` VARCHAR(15) NOT NULL,
  `data_cadastro` DATE NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `CPF_UNIQUE` (`CPF` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_endereco` (
  `Id` INT NOT NULL,
  `logradouro` VARCHAR(45) NOT NULL,
  `bairro` VARCHAR(45) NOT NULL,
  `CEP` VARCHAR(9) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `id_endereco_UNIQUE` (`Id` ASC),
  UNIQUE INDEX `CEP_UNIQUE` (`CEP` ASC),
  UNIQUE INDEX `bairro_UNIQUE` (`bairro` ASC),
  UNIQUE INDEX `logradouro_UNIQUE` (`logradouro` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_encomenda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_encomenda` (
  `Id` INT NOT NULL,
  `clientecod` INT NOT NULL,
  `preco` DECIMAL(10,2) NOT NULL,
  `anotacao` TINYTEXT NULL,
  `data_pagamento` DATE NULL,
  `data_entrega_prevista` DATE NULL,
  `data_entrega_efetiva` DATE NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `id_encomenda_UNIQUE` (`Id` ASC),
  INDEX `FK_idcliente_idx` (`clientecod` ASC),
  CONSTRAINT `FK_idcliente`
    FOREIGN KEY (`clientecod`)
    REFERENCES `ateliecostura`.`table_cliente` (`id`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_prova`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_prova` (
  `Id` INT NOT NULL,
  `encomendacod` INT NOT NULL,
  `dia` DATE NOT NULL,
  `anotacao` TINYTEXT NULL,
  `horario` TIME NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `id_prova_UNIQUE` (`Id` ASC),
  INDEX `FK_encomenda_idx` (`encomendacod` ASC),
  CONSTRAINT `FK_encomenda`
    FOREIGN KEY (`encomendacod`)
    REFERENCES `ateliecostura`.`table_encomenda` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_material`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_material` (
  `Id` INT NOT NULL,
  `encomendacod` INT NOT NULL,
  `descricao` TINYTEXT NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `uni_medida` VARCHAR(10) CHARACTER SET 'big5' COLLATE 'big5_bin' NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `id_material_UNIQUE` (`Id` ASC),
  INDEX `FK_encomenda_idx` (`encomendacod` ASC),
  CONSTRAINT `FK_encomenda`
    FOREIGN KEY (`encomendacod`)
    REFERENCES `ateliecostura`.`table_encomenda` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_clienteenderco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_clienteenderco` (
  `clientecod` INT NOT NULL,
  `enderecocod` INT NOT NULL,
  `numero` INT NOT NULL,
  `complemento` VARCHAR(45) NULL,
  PRIMARY KEY (`clientecod`, `enderecocod`),
  UNIQUE INDEX `Id_UNIQUE` (`clientecod` ASC),
  INDEX `FK_enderecocod_idx` (`enderecocod` ASC),
  CONSTRAINT `FK_enderecocod`
    FOREIGN KEY (`enderecocod`)
    REFERENCES `ateliecostura`.`table_endereco` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_cliente`
    FOREIGN KEY (`clientecod`)
    REFERENCES `ateliecostura`.`table_cliente` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_medida`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_medida` (
  `Id` INT NOT NULL,
  `clientecod` INT NOT NULL,
  `medida` DECIMAL(10,2) NOT NULL,
  `tipo` INT NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `id_medida_UNIQUE` (`Id` ASC),
  CONSTRAINT `FK_clienteid`
    FOREIGN KEY (`clientecod`)
    REFERENCES `ateliecostura`.`table_cliente` (`id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

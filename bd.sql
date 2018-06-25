-- MySQL Script generated by MySQL Workbench
-- Sun Jun 24 16:27:52 2018
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
-- Table `ateliecostura`.`table_endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_endereco` (
  `id_endereco` INT NOT NULL,
  `logradouro` VARCHAR(45) NOT NULL,
  `bairro` VARCHAR(45) NOT NULL,
  `CEP` VARCHAR(9) NOT NULL,
  `data_criacao` DATE NOT NULL,
  `data_alteracao` DATE NULL,
  `situacao` INT NOT NULL,
  PRIMARY KEY (`id_endereco`),
  UNIQUE INDEX `id_endereco_UNIQUE` (`id_endereco` ASC),
  UNIQUE INDEX `CEP_UNIQUE` (`CEP` ASC),
  UNIQUE INDEX `bairro_UNIQUE` (`bairro` ASC),
  UNIQUE INDEX `logradouro_UNIQUE` (`logradouro` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_clienteenderco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_clienteenderco` (
  `clienteend_cod` INT NOT NULL,
  `enderecod` INT NOT NULL,
  `numero` INT NOT NULL,
  `complemento` VARCHAR(45) NULL,
  `data_criacao` DATE NOT NULL,
  `data_alteracao` DATE NULL,
  `situacao` INT NOT NULL,
  INDEX `FK_enderecocod_idx` (`enderecod` ASC),
  PRIMARY KEY (`clienteend_cod`),
  CONSTRAINT `FK_enderecocod`
    FOREIGN KEY (`enderecod`)
    REFERENCES `ateliecostura`.`table_endereco` (`id_endereco`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_cliente` (
  `id` INT NOT NULL,
  `nome` VARCHAR(45) NOT NULL,
  `CPF` CHAR(11) NOT NULL,
  `cel_num` VARCHAR(15) NOT NULL,
  `data_cadastro` DATE NOT NULL,
  `enderco_cod` INT NOT NULL,
  `data_criacao` DATE NOT NULL,
  `data_alteracao` DATE NULL,
  `situacao` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `FK_clienteend_idx` (`enderco_cod` ASC),
  UNIQUE INDEX `CPF_UNIQUE` (`CPF` ASC),
  CONSTRAINT `FK_clienteend`
    FOREIGN KEY (`enderco_cod`)
    REFERENCES `ateliecostura`.`table_clienteenderco` (`clienteend_cod`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_encomenda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_encomenda` (
  `id_encomenda` INT NOT NULL,
  `clientecod` INT NOT NULL,
  `preco` DECIMAL(10,2) NOT NULL,
  `anotacao` TINYTEXT NULL,
  `data_pagamento` DATE NULL,
  `data_entrega_prevista` DATE NULL,
  `data_entrega_efetiva` DATE NULL,
  `data_criacao` DATE NOT NULL,
  `data_alteracao` DATE NULL,
  `situacao` INT NOT NULL,
  PRIMARY KEY (`id_encomenda`),
  UNIQUE INDEX `id_encomenda_UNIQUE` (`id_encomenda` ASC),
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
  `id_prova` INT NOT NULL,
  `encomendacod` INT NOT NULL,
  `dia` DATE NOT NULL,
  `horario` TIME NOT NULL,
  `anotacao` TINYTEXT NULL,
  `data_criacao` DATE NOT NULL,
  `data_alteracao` DATE NULL,
  `situacao` INT NOT NULL,
  PRIMARY KEY (`id_prova`),
  UNIQUE INDEX `id_prova_UNIQUE` (`id_prova` ASC),
  INDEX `FK_encomenda_idx` (`encomendacod` ASC),
  CONSTRAINT `FK_encomenda`
    FOREIGN KEY (`encomendacod`)
    REFERENCES `ateliecostura`.`table_encomenda` (`id_encomenda`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_material`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_material` (
  `id_material` INT NOT NULL,
  `encomendacod` INT NOT NULL,
  `descricao` TINYTEXT NOT NULL,
  `quantidade` DECIMAL(10,2) NOT NULL,
  `uni_medida` VARCHAR(10) CHARACTER SET 'big5' COLLATE 'big5_bin' NOT NULL,
  `data_criacao` DATE NOT NULL,
  `data_alteracao` DATE NULL,
  `situacao` INT NOT NULL,
  PRIMARY KEY (`id_material`),
  UNIQUE INDEX `id_material_UNIQUE` (`id_material` ASC),
  INDEX `FK_encomenda_idx` (`encomendacod` ASC),
  CONSTRAINT `FK_encomenda`
    FOREIGN KEY (`encomendacod`)
    REFERENCES `ateliecostura`.`table_encomenda` (`id_encomenda`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ateliecostura`.`table_medida`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ateliecostura`.`table_medida` (
  `id_medida` INT NOT NULL,
  `clientecod` INT NOT NULL,
  `medida` DECIMAL(10,2) NOT NULL,
  `tipo` INT NOT NULL,
  `data_criacao` DATE NOT NULL,
  `data_alteracao` DATE NULL,
  `situacao` INT NOT NULL,
  PRIMARY KEY (`id_medida`),
  UNIQUE INDEX `id_medida_UNIQUE` (`id_medida` ASC),
  CONSTRAINT `FK_clienteid`
    FOREIGN KEY (`clientecod`)
    REFERENCES `ateliecostura`.`table_cliente` (`id`)
    ON DELETE SET NULL
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
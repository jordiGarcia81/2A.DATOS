-- MySQL Script generated by MySQL Workbench
-- Wed Sep 23 10:54:05 2020
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering


-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Eventos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Eventos` (
  `id_evento` INT NOT NULL AUTO_INCREMENT,
  `visitante` VARCHAR(45) NOT NULL,
  `fecha` DATETIME NOT NULL,
  `local` VARCHAR(45) NULL,
  PRIMARY KEY (`id_evento`));


-- -----------------------------------------------------
-- Table `mydb`.`Mercados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Mercados` (
  `couta_over` DOUBLE NOT NULL,
  `cuota_under` DOUBLE NOT NULL,
  `dinero_over` DOUBLE NOT NULL,
  `dinero_under` DOUBLE NOT NULL,
  `over_under` DOUBLE NOT NULL,
  `Eventos_id_evento` INT NOT NULL,
  `id_mercado` INT NOT NULL AUTO_INCREMENT,
 
  PRIMARY KEY (`id_mercado`),
  CONSTRAINT `fk_Mercados_Eventos1`
    FOREIGN KEY (`Eventos_id_evento`)
    REFERENCES `mydb`.`Eventos` (`id_evento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Usuarios` (
  `email_usuarios` VARCHAR(25) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `apellidos` VARCHAR(45) NOT NULL,
  `edad` INT NOT NULL,
  PRIMARY KEY (`email_usuarios`));


-- -----------------------------------------------------
-- Table `mydb`.`Apuesta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Apuesta` (
  `tipo_apuesta` VARCHAR(45) NOT NULL,
  `cuota` DOUBLE NOT NULL,
  `dinero` DOUBLE NOT NULL,
  `fecha` DATETIME NOT NULL,
  `Usuarios_email_usuarios` VARCHAR(25) NULL,
  `id_apuesta` INT NOT NULL AUTO_INCREMENT,
  `Mercados_id_mercado` INT NOT NULL,
 
  PRIMARY KEY (`id_apuesta`),
  
  CONSTRAINT `Usuarios_email_usuarios`
    FOREIGN KEY (`Usuarios_email_usuarios`)
    REFERENCES `mydb`.`Usuarios` (`email_usuarios`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Mercados_id_mercado`
    FOREIGN KEY (`Mercados_id_mercado`)
    REFERENCES `mydb`.`Mercados` (`id_mercado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `mydb`.`Cuenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Cuenta` (
  `numero_tarjeta` BIGINT(16) NOT NULL,
  `numero_banco` INT NOT NULL,
  `saldo` DOUBLE NOT NULL,
  `Usuarios_email_usuarios` VARCHAR(25) NOT NULL,
  

  CONSTRAINT `fk_Cuota_Usuarios1`
    FOREIGN KEY (`Usuarios_email_usuarios`)
    REFERENCES `mydb`.`Usuarios` (`email_usuarios`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

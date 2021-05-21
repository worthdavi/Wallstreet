-- MySQL Script generated by MySQL Workbench
-- Fri May 21 12:38:28 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema wallstreet
-- -----------------------------------------------------
-- Banco de dados do software para consultas simuladas na bolsa de valores.

-- -----------------------------------------------------
-- Schema wallstreet
--
-- Banco de dados do software para consultas simuladas na bolsa de valores.
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `wallstreet` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin ;
USE `wallstreet` ;

-- -----------------------------------------------------
-- Table `wallstreet`.`user`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `wallstreet`.`user` ;

CREATE TABLE IF NOT EXISTS `wallstreet`.`user` (
  `id` INT NOT NULL,
  `username` VARCHAR(16) NOT NULL,
  `email` VARCHAR(255) NULL,
  `password` VARCHAR(32) NOT NULL,
  `type` TINYINT(6) NULL DEFAULT 1,
  `balance` DECIMAL(10) NULL,
  PRIMARY KEY (`id`));


-- -----------------------------------------------------
-- Table `wallstreet`.`actives`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `wallstreet`.`actives` ;

CREATE TABLE IF NOT EXISTS `wallstreet`.`actives` (
  `ticker` VARCHAR(6) NOT NULL,
  `share_amount` INT NOT NULL,
  `share_price` INT NOT NULL,
  `description` VARCHAR(45) NULL,
  PRIMARY KEY (`ticker`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wallstreet`.`users_actives`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `wallstreet`.`users_actives` ;

CREATE TABLE IF NOT EXISTS `wallstreet`.`users_actives` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NOT NULL,
  `actives_ticker` VARCHAR(6) NOT NULL,
  `share_amount` INT NULL,
  INDEX `fk_users_actives_users_idx` (`user_id` ASC) VISIBLE,
  PRIMARY KEY (`id`),
  INDEX `fk_users_actives_actives1_idx` (`actives_ticker` ASC) VISIBLE,
  CONSTRAINT `fk_users_actives_users`
    FOREIGN KEY (`user_id`)
    REFERENCES `wallstreet`.`user` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_users_actives_actives1`
    FOREIGN KEY (`actives_ticker`)
    REFERENCES `wallstreet`.`actives` (`ticker`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wallstreet`.`advertising`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `wallstreet`.`advertising` ;

CREATE TABLE IF NOT EXISTS `wallstreet`.`advertising` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_id` INT NOT NULL,
  `share_amount` INT NOT NULL,
  `share_price` INT NOT NULL,
  `type` TINYINT(6) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_user_selling_user1_idx` (`user_id` ASC) VISIBLE,
  CONSTRAINT `fk_user_selling_user1`
    FOREIGN KEY (`user_id`)
    REFERENCES `wallstreet`.`user` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wallstreet`.`advertising_historic`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `wallstreet`.`advertising_historic` ;

CREATE TABLE IF NOT EXISTS `wallstreet`.`advertising_historic` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `share_amount` INT NOT NULL,
  `share_price` INT NOT NULL,
  `type` TINYINT(6) NOT NULL,
  `date` TIMESTAMP(16) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

create schema if not exists library;
use library;
-- MySQL Script generated by MySQL Workbench
-- Sat May  8 01:57:13 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Table `mydb`.`Users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Users` (
  `idUsers` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(15) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `role` SET('admin', 'librarian', 'reader', 'landlord') NOT NULL,
  PRIMARY KEY (`idUsers`),
  UNIQUE INDEX `idUsers_UNIQUE` (`idUsers` ASC),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Authors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Authors` (
  `idAuthors` INT NOT NULL AUTO_INCREMENT,
  `first_name` VARCHAR(45) NOT NULL,
  `last_name` VARCHAR(45) NOT NULL,
  `birth_year` YEAR(4) NOT NULL,
  PRIMARY KEY (`idAuthors`),
  UNIQUE INDEX `idAuthors_UNIQUE` (`idAuthors` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Books`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Books` (
  `idBooks` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(45) NOT NULL,
  `pages` SMALLINT NULL,
  `Authors_idAuthors` INT NULL,
  PRIMARY KEY (`idBooks`),
  UNIQUE INDEX `idBooks_UNIQUE` (`idBooks` ASC),
  INDEX `fk_Books_Authors1_idx` (`Authors_idAuthors` ASC),
  CONSTRAINT `fk_Books_Authors1`
    FOREIGN KEY (`Authors_idAuthors`)
    REFERENCES `mydb`.`Authors` (`idAuthors`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Genres`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Genres` (
  `idGenres` INT NOT NULL AUTO_INCREMENT,
  `genre_name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idGenres`),
  UNIQUE INDEX `idGenres_UNIQUE` (`idGenres` ASC),
  UNIQUE INDEX `genre_name_UNIQUE` (`genre_name` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Blacklist`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Blacklist` (
  `idBlacklist` INT NOT NULL AUTO_INCREMENT,
  `reason` VARCHAR(45) NULL,
  `Users_idUsers` INT NOT NULL,
  PRIMARY KEY (`idBlacklist`),
  UNIQUE INDEX `idBlacklist_UNIQUE` (`idBlacklist` ASC),
  INDEX `fk_Blacklist_Users1_idx` (`Users_idUsers` ASC),
  CONSTRAINT `fk_Blacklist_Users1`
    FOREIGN KEY (`Users_idUsers`)
    REFERENCES `mydb`.`Users` (`idUsers`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Book_adding_requests`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Book_adding_requests` (
  `idRequest` INT NOT NULL AUTO_INCREMENT,
  `status` SET('cheсking', 'approved', 'rejected') NOT NULL DEFAULT 'cheсking',
  `new_title` VARCHAR(45) NOT NULL,
  `file` VARCHAR(45) NOT NULL,
  `Authors_idAuthors` INT NULL,
  `Users_idUsers` INT NOT NULL,
  `new_author_first_name` VARCHAR(45) NULL,
  `new_author_last_name` VARCHAR(45) NULL,
  PRIMARY KEY (`idRequest`),
  UNIQUE INDEX `idRequest_UNIQUE` (`idRequest` ASC),
  INDEX `fk_Book_adding_requests_Authors1_idx` (`Authors_idAuthors` ASC),
  INDEX `fk_Book_adding_requests_Users1_idx` (`Users_idUsers` ASC),
  CONSTRAINT `fk_Book_adding_requests_Authors1`
    FOREIGN KEY (`Authors_idAuthors`)
    REFERENCES `mydb`.`Authors` (`idAuthors`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Book_adding_requests_Users1`
    FOREIGN KEY (`Users_idUsers`)
    REFERENCES `mydb`.`Users` (`idUsers`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`User_Information`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `User_Information` (
  `idUser_Information` INT NOT NULL AUTO_INCREMENT,
  `user_first_name` VARCHAR(45) NULL,
  `user_last_name` VARCHAR(45) NULL,
  `Users_idUsers` INT NOT NULL,
  PRIMARY KEY (`idUser_Information`),
  INDEX `fk_User_Information_Users1_idx` (`Users_idUsers` ASC),
  CONSTRAINT `fk_User_Information_Users1`
    FOREIGN KEY (`Users_idUsers`)
    REFERENCES `mydb`.`Users` (`idUsers`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`User_Address`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `User_Address` (
  `idUser_Address` INT NOT NULL,
  `address` VARCHAR(45) NOT NULL,
  `User_Information_idUser_Information` INT NOT NULL,
  PRIMARY KEY (`idUser_Address`),
  INDEX `fk_User_Address_User_Information1_idx` (`User_Information_idUser_Information` ASC),
  CONSTRAINT `fk_User_Address_User_Information1`
    FOREIGN KEY (`User_Information_idUser_Information`)
    REFERENCES `mydb`.`User_Information` (`idUser_Information`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`User_Payment`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `User_Payment` (
  `idUser_Payment` INT NOT NULL,
  `card_num` VARCHAR(16) NOT NULL,
  `card_month` TINYINT(2) NOT NULL,
  `card_year` TINYINT(2) NOT NULL,
  `card_pin` TINYINT(4) NOT NULL,
  `User_Information_idUser_Information` INT NOT NULL,
  PRIMARY KEY (`idUser_Payment`),
  INDEX `fk_User_Payment_User_Information1_idx` (`User_Information_idUser_Information` ASC),
  CONSTRAINT `fk_User_Payment_User_Information1`
    FOREIGN KEY (`User_Information_idUser_Information`)
    REFERENCES `mydb`.`User_Information` (`idUser_Information`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Books_has_Genres`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Books_has_Genres` (
  `Books_idBooks` INT NOT NULL,
  `Genres_idGenres` INT NOT NULL,
  PRIMARY KEY (`Books_idBooks`, `Genres_idGenres`),
  INDEX `fk_Books_has_Genres_Genres1_idx` (`Genres_idGenres` ASC),
  INDEX `fk_Books_has_Genres_Books1_idx` (`Books_idBooks` ASC),
  CONSTRAINT `fk_Books_has_Genres_Books1`
    FOREIGN KEY (`Books_idBooks`)
    REFERENCES `mydb`.`Books` (`idBooks`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Books_has_Genres_Genres1`
    FOREIGN KEY (`Genres_idGenres`)
    REFERENCES `mydb`.`Genres` (`idGenres`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
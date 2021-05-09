-- MySQL Script generated by MySQL Workbench
-- Sun May  9 11:04:45 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema library
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema library
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `library` DEFAULT CHARACTER SET utf8 ;
USE `library` ;

-- -----------------------------------------------------
-- Table `library`.`Users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`Users` (
  `idUsers` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(15) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `role` SET('admin', 'librarian', 'reader', 'landlord') NOT NULL,
  PRIMARY KEY (`idUsers`),
  UNIQUE INDEX `idUsers_UNIQUE` (`idUsers` ASC),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `library`.`Authors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`Authors` (
  `idAuthors` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(90) NOT NULL,
  `birth_year` YEAR(4) NOT NULL,
  PRIMARY KEY (`idAuthors`),
  UNIQUE INDEX `idAuthors_UNIQUE` (`idAuthors` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `library`.`Books`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`Books` (
  `idBooks` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(45) NOT NULL,
  `pages` SMALLINT NULL,
  `Authors_idAuthors` INT NULL,
  `write_year` YEAR(4) NULL,
  PRIMARY KEY (`idBooks`),
  UNIQUE INDEX `idBooks_UNIQUE` (`idBooks` ASC),
  INDEX `fk_Books_Authors1_idx` (`Authors_idAuthors` ASC),
  CONSTRAINT `fk_Books_Authors1`
    FOREIGN KEY (`Authors_idAuthors`)
    REFERENCES `library`.`Authors` (`idAuthors`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `library`.`Genres`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`Genres` (
  `idGenres` INT NOT NULL AUTO_INCREMENT,
  `genre_name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idGenres`),
  UNIQUE INDEX `idGenres_UNIQUE` (`idGenres` ASC),
  UNIQUE INDEX `genre_name_UNIQUE` (`genre_name` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `library`.`Blacklist`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`Blacklist` (
  `idBlacklist` INT NOT NULL AUTO_INCREMENT,
  `reason` VARCHAR(45) NULL,
  `Users_idUsers` INT NOT NULL,
  PRIMARY KEY (`idBlacklist`),
  UNIQUE INDEX `idBlacklist_UNIQUE` (`idBlacklist` ASC),
  INDEX `fk_Blacklist_Users1_idx` (`Users_idUsers` ASC),
  CONSTRAINT `fk_Blacklist_Users1`
    FOREIGN KEY (`Users_idUsers`)
    REFERENCES `library`.`Users` (`idUsers`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `library`.`Book_adding_requests`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`Book_adding_requests` (
  `idRequest` INT NOT NULL AUTO_INCREMENT,
  `status` SET('cheсking', 'approved', 'rejected') NOT NULL DEFAULT 'cheсking',
  `new_title` VARCHAR(45) NOT NULL,
  `file` VARCHAR(45) NULL,
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
    REFERENCES `library`.`Authors` (`idAuthors`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Book_adding_requests_Users1`
    FOREIGN KEY (`Users_idUsers`)
    REFERENCES `library`.`Users` (`idUsers`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `library`.`User_Information`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`User_Information` (
  `idUser_Information` INT NOT NULL AUTO_INCREMENT,
  `user_first_name` VARCHAR(45) NULL,
  `user_last_name` VARCHAR(45) NULL,
  `Users_idUsers` INT NOT NULL,
  PRIMARY KEY (`idUser_Information`),
  INDEX `fk_User_Information_Users1_idx` (`Users_idUsers` ASC),
  CONSTRAINT `fk_User_Information_Users1`
    FOREIGN KEY (`Users_idUsers`)
    REFERENCES `library`.`Users` (`idUsers`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `library`.`User_Address`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`User_Address` (
  `idUser_Address` INT NOT NULL,
  `address` VARCHAR(45) NOT NULL,
  `User_Information_idUser_Information` INT NOT NULL,
  PRIMARY KEY (`idUser_Address`),
  INDEX `fk_User_Address_User_Information1_idx` (`User_Information_idUser_Information` ASC),
  CONSTRAINT `fk_User_Address_User_Information1`
    FOREIGN KEY (`User_Information_idUser_Information`)
    REFERENCES `library`.`User_Information` (`idUser_Information`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `library`.`User_Payment`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`User_Payment` (
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
    REFERENCES `library`.`User_Information` (`idUser_Information`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `library`.`Books_has_Genres`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `library`.`Books_has_Genres` (
  `Books_idBooks` INT NOT NULL,
  `Genres_idGenres` INT NOT NULL,
  PRIMARY KEY (`Books_idBooks`, `Genres_idGenres`),
  INDEX `fk_Books_has_Genres_Genres1_idx` (`Genres_idGenres` ASC),
  INDEX `fk_Books_has_Genres_Books1_idx` (`Books_idBooks` ASC),
  CONSTRAINT `fk_Books_has_Genres_Books1`
    FOREIGN KEY (`Books_idBooks`)
    REFERENCES `library`.`Books` (`idBooks`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Books_has_Genres_Genres1`
    FOREIGN KEY (`Genres_idGenres`)
    REFERENCES `library`.`Genres` (`idGenres`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

ALTER TABLE `library`.`books` 
ADD COLUMN `price` INT NULL DEFAULT 0 AFTER `write_year`;

INSERT INTO `library`.`users` (`username`, `password`, `role`) VALUES ('admin', 'admin', 'admin');

ALTER TABLE `library`.`books` 
DROP FOREIGN KEY `fk_Books_Authors1`;
ALTER TABLE `library`.`books` 
CHANGE COLUMN `Authors_idAuthors` `Authors_idAuthors` INT(11) NULL DEFAULT 404 ;
ALTER TABLE `library`.`books` 
ADD CONSTRAINT `fk_Books_Authors1`
  FOREIGN KEY (`Authors_idAuthors`)
  REFERENCES `library`.`authors` (`idAuthors`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

ALTER TABLE `library`.`authors` 
CHANGE COLUMN `birth_year` `birth_year` YEAR(4) NULL ;

ALTER TABLE `library`.`books` 
DROP FOREIGN KEY `fk_Books_Authors1`;
ALTER TABLE `library`.`books` 
ADD CONSTRAINT `fk_Books_Authors1`
  FOREIGN KEY (`Authors_idAuthors`)
  REFERENCES `library`.`authors` (`idAuthors`)
  ON DELETE SET NULL
  ON UPDATE CASCADE;


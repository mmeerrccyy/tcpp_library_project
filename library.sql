-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 08, 2021 at 08:03 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library`
--

-- --------------------------------------------------------

--
-- Table structure for table `authors`
--

CREATE TABLE `authors` (
  `idAuthors` int(11) NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `last_name` varchar(45) NOT NULL,
  `birth_year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `authors`
--

INSERT INTO `authors` (`idAuthors`, `first_name`, `last_name`, `birth_year`) VALUES
(1, 'test1', 'sadasd', 1920),
(2, 'test2', 'asdasdasd', 1999);

-- --------------------------------------------------------

--
-- Table structure for table `blacklist`
--

CREATE TABLE `blacklist` (
  `idBlacklist` int(11) NOT NULL,
  `reason` varchar(45) DEFAULT NULL,
  `Users_idUsers` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `idBooks` int(11) NOT NULL,
  `title` varchar(45) NOT NULL,
  `pages` smallint(6) DEFAULT NULL,
  `Authors_idAuthors` int(11) DEFAULT NULL,
  `price` float DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`idBooks`, `title`, `pages`, `Authors_idAuthors`, `price`) VALUES
(1, 'Test book', 125, NULL, 0),
(2, 'test book2', 100, NULL, 0),
(3, 'Kobzar', 125, NULL, 10.25),
(4, 'asd', 132, NULL, 1111);

-- --------------------------------------------------------

--
-- Table structure for table `books_has_genres`
--

CREATE TABLE `books_has_genres` (
  `Books_idBooks` int(11) NOT NULL,
  `Genres_idGenres` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `book_adding_requests`
--

CREATE TABLE `book_adding_requests` (
  `idRequest` int(11) NOT NULL,
  `status` set('cheсking','approved','rejected') NOT NULL DEFAULT 'cheсking',
  `new_title` varchar(45) NOT NULL,
  `file` varchar(45) NOT NULL,
  `Authors_idAuthors` int(11) DEFAULT NULL,
  `Users_idUsers` int(11) NOT NULL,
  `new_author_first_name` varchar(45) DEFAULT NULL,
  `new_author_last_name` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

CREATE TABLE `genres` (
  `idGenres` int(11) NOT NULL,
  `genre_name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `idUsers` int(11) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `role` set('admin','librarian','reader','landlord') NOT NULL DEFAULT 'reader'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`idUsers`, `username`, `password`, `role`) VALUES
(1, 'asdasdasd', 'qwerty', 'admin'),
(7, 'asdasdasds', 'qweqweqwe', 'reader');

-- --------------------------------------------------------

--
-- Table structure for table `user_address`
--

CREATE TABLE `user_address` (
  `idUser_Address` int(11) NOT NULL,
  `address` varchar(45) NOT NULL,
  `User_Information_idUser_Information` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `user_information`
--

CREATE TABLE `user_information` (
  `idUser_Information` int(11) NOT NULL,
  `user_first_name` varchar(45) DEFAULT NULL,
  `user_last_name` varchar(45) DEFAULT NULL,
  `Users_idUsers` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `user_payment`
--

CREATE TABLE `user_payment` (
  `idUser_Payment` int(11) NOT NULL,
  `card_num` varchar(16) NOT NULL,
  `card_month` tinyint(2) NOT NULL,
  `card_year` tinyint(2) NOT NULL,
  `card_pin` tinyint(4) NOT NULL,
  `User_Information_idUser_Information` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `authors`
--
ALTER TABLE `authors`
  ADD PRIMARY KEY (`idAuthors`),
  ADD UNIQUE KEY `idAuthors_UNIQUE` (`idAuthors`);

--
-- Indexes for table `blacklist`
--
ALTER TABLE `blacklist`
  ADD PRIMARY KEY (`idBlacklist`),
  ADD UNIQUE KEY `idBlacklist_UNIQUE` (`idBlacklist`),
  ADD KEY `fk_Blacklist_Users1_idx` (`Users_idUsers`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`idBooks`),
  ADD UNIQUE KEY `idBooks_UNIQUE` (`idBooks`),
  ADD KEY `fk_Books_Authors1_idx` (`Authors_idAuthors`);

--
-- Indexes for table `books_has_genres`
--
ALTER TABLE `books_has_genres`
  ADD PRIMARY KEY (`Books_idBooks`,`Genres_idGenres`),
  ADD KEY `fk_Books_has_Genres_Genres1_idx` (`Genres_idGenres`),
  ADD KEY `fk_Books_has_Genres_Books1_idx` (`Books_idBooks`);

--
-- Indexes for table `book_adding_requests`
--
ALTER TABLE `book_adding_requests`
  ADD PRIMARY KEY (`idRequest`),
  ADD UNIQUE KEY `idRequest_UNIQUE` (`idRequest`),
  ADD KEY `fk_Book_adding_requests_Authors1_idx` (`Authors_idAuthors`),
  ADD KEY `fk_Book_adding_requests_Users1_idx` (`Users_idUsers`);

--
-- Indexes for table `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`idGenres`),
  ADD UNIQUE KEY `idGenres_UNIQUE` (`idGenres`),
  ADD UNIQUE KEY `genre_name_UNIQUE` (`genre_name`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`idUsers`),
  ADD UNIQUE KEY `idUsers_UNIQUE` (`idUsers`),
  ADD UNIQUE KEY `username_UNIQUE` (`username`);

--
-- Indexes for table `user_address`
--
ALTER TABLE `user_address`
  ADD PRIMARY KEY (`idUser_Address`),
  ADD KEY `fk_User_Address_User_Information1_idx` (`User_Information_idUser_Information`);

--
-- Indexes for table `user_information`
--
ALTER TABLE `user_information`
  ADD PRIMARY KEY (`idUser_Information`),
  ADD KEY `fk_User_Information_Users1_idx` (`Users_idUsers`);

--
-- Indexes for table `user_payment`
--
ALTER TABLE `user_payment`
  ADD PRIMARY KEY (`idUser_Payment`),
  ADD KEY `fk_User_Payment_User_Information1_idx` (`User_Information_idUser_Information`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `authors`
--
ALTER TABLE `authors`
  MODIFY `idAuthors` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `blacklist`
--
ALTER TABLE `blacklist`
  MODIFY `idBlacklist` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `idBooks` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `book_adding_requests`
--
ALTER TABLE `book_adding_requests`
  MODIFY `idRequest` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `genres`
--
ALTER TABLE `genres`
  MODIFY `idGenres` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `idUsers` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `user_information`
--
ALTER TABLE `user_information`
  MODIFY `idUser_Information` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `blacklist`
--
ALTER TABLE `blacklist`
  ADD CONSTRAINT `fk_Blacklist_Users1` FOREIGN KEY (`Users_idUsers`) REFERENCES `mydb`.`users` (`idUsers`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `fk_Books_Authors1` FOREIGN KEY (`Authors_idAuthors`) REFERENCES `mydb`.`authors` (`idAuthors`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `books_has_genres`
--
ALTER TABLE `books_has_genres`
  ADD CONSTRAINT `fk_Books_has_Genres_Books1` FOREIGN KEY (`Books_idBooks`) REFERENCES `mydb`.`books` (`idBooks`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Books_has_Genres_Genres1` FOREIGN KEY (`Genres_idGenres`) REFERENCES `mydb`.`genres` (`idGenres`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `book_adding_requests`
--
ALTER TABLE `book_adding_requests`
  ADD CONSTRAINT `fk_Book_adding_requests_Authors1` FOREIGN KEY (`Authors_idAuthors`) REFERENCES `mydb`.`authors` (`idAuthors`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Book_adding_requests_Users1` FOREIGN KEY (`Users_idUsers`) REFERENCES `mydb`.`users` (`idUsers`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `user_address`
--
ALTER TABLE `user_address`
  ADD CONSTRAINT `fk_User_Address_User_Information1` FOREIGN KEY (`User_Information_idUser_Information`) REFERENCES `mydb`.`user_information` (`idUser_Information`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `user_information`
--
ALTER TABLE `user_information`
  ADD CONSTRAINT `fk_User_Information_Users1` FOREIGN KEY (`Users_idUsers`) REFERENCES `mydb`.`users` (`idUsers`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `user_payment`
--
ALTER TABLE `user_payment`
  ADD CONSTRAINT `fk_User_Payment_User_Information1` FOREIGN KEY (`User_Information_idUser_Information`) REFERENCES `mydb`.`user_information` (`idUser_Information`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

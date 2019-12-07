-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 07, 2019 at 10:02 PM
-- Server version: 5.7.24-log
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `articles_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `articles`
--

CREATE TABLE `articles` (
  `articleid` int(10) NOT NULL,
  `articletitle` varchar(255) NOT NULL,
  `articledate` date NOT NULL,
  `articlecontent` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `articles`
--

INSERT INTO `articles` (`articleid`, `articletitle`, `articledate`, `articlecontent`) VALUES
(17, 'Yoga', '2019-12-07', 'Yoga is a form of physical exercise. It helps to keep your body fit and healthy through out your life.There are many different forms of yoga.Breathing techniques and meditation are also included in it.'),
(18, 'Travelling', '2019-12-07', 'Vacations are must nowadays. Every one is busy in their hectic life. Travelling give them some time to relax and spend some time with their family. It also helps you to increase your work efficiency. '),
(19, 'Nutrition', '2019-12-07', 'All the living creatures on earth need nutrition to live. Proper nutrition is must for healthy life. Food is the main source of nutrition. The main types of nutrition are - carbohydrates, proteins, vitamins, fats and many more. '),
(20, 'Fashion', '2019-12-07', 'FASHION the word that everyone relates themselves to.The art of chnaging simple to elegant is fashion.It focus on dressing, accessories, footwear and more. It depends on more than one factor such as culture, place etc.');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `articles`
--
ALTER TABLE `articles`
  ADD PRIMARY KEY (`articleid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `articles`
--
ALTER TABLE `articles`
  MODIFY `articleid` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

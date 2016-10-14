-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 13, 2016 at 06:11 PM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `votingsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `auditor`
--

CREATE TABLE `auditor` (
  `pID` int(255) NOT NULL,
  `pName` varchar(255) NOT NULL,
  `pParty` varchar(255) NOT NULL,
  `pPosition` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `president`
--

CREATE TABLE `president` (
  `pID` int(255) NOT NULL,
  `pName` varchar(255) NOT NULL,
  `pParty` varchar(255) NOT NULL,
  `pPosition` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pro`
--

CREATE TABLE `pro` (
  `pID` int(255) NOT NULL,
  `pName` varchar(255) NOT NULL,
  `pParty` varchar(255) NOT NULL,
  `pPosition` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `secretary`
--

CREATE TABLE `secretary` (
  `pID` varchar(255) NOT NULL,
  `pName` varchar(255) NOT NULL,
  `pParty` varchar(255) NOT NULL,
  `pPosition` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `treasurer`
--

CREATE TABLE `treasurer` (
  `pID` int(255) NOT NULL,
  `pName` varchar(255) NOT NULL,
  `pParty` varchar(255) NOT NULL,
  `pPosition` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `vicepresident`
--

CREATE TABLE `vicepresident` (
  `pID` int(255) NOT NULL,
  `pName` varchar(255) NOT NULL,
  `pParty` varchar(255) NOT NULL,
  `pPosition` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `voters`
--

CREATE TABLE `voters` (
  `userid` int(32) NOT NULL,
  `uname` varchar(255) NOT NULL,
  `ustudno` varchar(255) NOT NULL,
  `upass` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `auditor`
--
ALTER TABLE `auditor`
  ADD PRIMARY KEY (`pID`);

--
-- Indexes for table `president`
--
ALTER TABLE `president`
  ADD PRIMARY KEY (`pID`);

--
-- Indexes for table `pro`
--
ALTER TABLE `pro`
  ADD PRIMARY KEY (`pID`);

--
-- Indexes for table `treasurer`
--
ALTER TABLE `treasurer`
  ADD PRIMARY KEY (`pID`);

--
-- Indexes for table `vicepresident`
--
ALTER TABLE `vicepresident`
  ADD PRIMARY KEY (`pID`);

--
-- Indexes for table `voters`
--
ALTER TABLE `voters`
  ADD PRIMARY KEY (`userid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `auditor`
--
ALTER TABLE `auditor`
  MODIFY `pID` int(255) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `president`
--
ALTER TABLE `president`
  MODIFY `pID` int(255) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pro`
--
ALTER TABLE `pro`
  MODIFY `pID` int(255) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `treasurer`
--
ALTER TABLE `treasurer`
  MODIFY `pID` int(255) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `vicepresident`
--
ALTER TABLE `vicepresident`
  MODIFY `pID` int(255) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `voters`
--
ALTER TABLE `voters`
  MODIFY `userid` int(32) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

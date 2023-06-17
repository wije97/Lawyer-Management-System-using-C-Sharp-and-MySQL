-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 11, 2020 at 06:40 PM
-- Server version: 10.4.11-MariaDB
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
-- Database: `lawdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `cases`
--

CREATE TABLE `cases` (
  `Case_ID` varchar(20) NOT NULL,
  `Case_No` varchar(20) NOT NULL,
  `Case_Type` text NOT NULL,
  `Case_Des` varchar(500) NOT NULL,
  `Court_Name` varchar(100) NOT NULL,
  `Case_Date` date NOT NULL,
  `Case_Status` text NOT NULL,
  `Case_Evidences` varchar(1000) NOT NULL,
  `Client_ID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cases`
--

INSERT INTO `cases` (`Case_ID`, `Case_No`, `Case_Type`, `Case_Des`, `Court_Name`, `Case_Date`, `Case_Status`, `Case_Evidences`, `Client_ID`) VALUES
('C2658', '28999', 'Call', 'Attack to a police officer', 'Rathmalana - District Court', '2020-05-27', 'Pending', 'Confession\r\nCCTV Footages', '02'),
('C4586', '12563', 'Call', 'Murder', 'High Court - Moratuwa', '2020-05-29', 'Pending', 'CCTV footages', '06'),
('C54896', '326987', 'Trial', 'Theft', 'Rathmalana - District Court', '2020-05-28', 'Pending', 'CCTV footages.', '02'),
('C7896', '14589', 'Call', 'Murder', 'Rathmalana - High Court', '2020-06-25', 'New', 'Knife\r\nConfession', '02');

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `Client_ID` varchar(15) NOT NULL,
  `First_Name` varchar(100) NOT NULL,
  `Last_Name` varchar(200) NOT NULL,
  `NIC` varchar(15) NOT NULL,
  `Age` int(2) NOT NULL,
  `Gender` text NOT NULL,
  `Address` varchar(200) NOT NULL,
  `Phone_No` varchar(10) NOT NULL,
  `Reg_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`Client_ID`, `First_Name`, `Last_Name`, `NIC`, `Age`, `Gender`, `Address`, `Phone_No`, `Reg_Date`) VALUES
('01', 'Sahan', 'Gunawardana', '975846985v', 23, 'Male', 'No 324/9, Nawala Road, Nugegoda', '0712569874', '2020-05-10'),
('02', 'Kusal', 'Shanuka', '754895592v', 45, 'Male', 'No.546/34, Galle Road, Rathmalana', '0725895698', '2020-05-09'),
('06', 'Adam', 'fernando', '975849586v', 23, 'Male', 'xxxxxx', '0715896589', '2020-05-11');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `email_password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `email`, `email_password`) VALUES
('Admin', 'lms123', 'isuruw27@gmail.com', 'isuru1997Ap@4');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cases`
--
ALTER TABLE `cases`
  ADD PRIMARY KEY (`Case_ID`);

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`Client_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

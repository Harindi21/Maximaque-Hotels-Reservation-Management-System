-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 17, 2023 at 04:05 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 7.4.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mnagementsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerID` int(11) NOT NULL,
  `CustomerName` varchar(99) NOT NULL,
  `Category` varchar(99) NOT NULL,
  `Gender` varchar(99) NOT NULL,
  `Phone` int(10) NOT NULL,
  `Mail` varchar(99) NOT NULL,
  `NIC` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerID`, `CustomerName`, `Category`, `Gender`, `Phone`, `Mail`, `NIC`) VALUES
(1, 'Harindi Balasuriya', 'Adult', 'Female', 714579999, 'eranthikah999@gmail.com', '996678654V'),
(2, 'Chamali Wedage', 'Adult', 'Female', 766868699, 'kjgfjgvjh@gmail.com', '996682888V'),
(3, 'Dewni Senevirathne', 'Adult', 'Female', 714567777, 'dewnikjhjkf@gmail.com', '996682999V'),
(4, 'Hiruni Adithya', 'Adult', 'Female', 714444444, 'adithyahgfjhf@gmail.com', '996692999V'),
(5, 'Ishadi Tharushika', 'Adult', 'Female', 714567777, 'qgghekugujgj@mail.com', '996682987V'),
(6, 'Kildi Chamindi', 'Adult', 'Female', 714567777, 'hjklkgjkvf@gmail.com', '996682988V'),
(7, 'Silviya Fernando', 'Elderly', 'Female', 778877887, 'silviya88@gmail.com', '119977786V'),
(8, 'Shanuka', 'Adult', 'Female', 716666666, 'shanukaperera@gmail.com', '998876767V');

-- --------------------------------------------------------

--
-- Table structure for table `hotel`
--

CREATE TABLE `hotel` (
  `HotelID` int(11) NOT NULL,
  `Name` varchar(99) NOT NULL,
  `Phone` int(10) NOT NULL,
  `City` varchar(99) NOT NULL,
  `Address` varchar(99) NOT NULL,
  `Email` varchar(99) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `hotel`
--

INSERT INTO `hotel` (`HotelID`, `Name`, `Phone`, `City`, `Address`, `Email`) VALUES
(1, 'Maximaque Hotels', 719999998, 'Colombo', 'Maximaque Hotels Complex, Lake Isle Boulevard, Colombo 7', 'maximaquehotels9@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `rooms`
--

CREATE TABLE `rooms` (
  `RoomID` int(11) NOT NULL,
  `CustomerId` int(11) DEFAULT NULL,
  `RoomName` varchar(99) NOT NULL,
  `Type` varchar(99) NOT NULL,
  `Description` varchar(99) NOT NULL,
  `Status` varchar(99) NOT NULL,
  `Cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `rooms`
--

INSERT INTO `rooms` (`RoomID`, `CustomerId`, `RoomName`, `Type`, `Description`, `Status`, `Cost`) VALUES
(1, 1, 'One', 'Suite', 'Gained', 'Unavailable', 89),
(2, 1, 'two', 'suite', 'kgj', 'Unavailable', 99),
(3, 2, 'Three', 'Suite', 'lkjb', 'Unavailable', 789),
(4, NULL, 'Four', 'Suite', 'kiyf', 'Available', 98),
(5, 3, 'Four', 'Suite', 'khv', 'Unavailable', 98),
(6, NULL, 'Six', 'iyf', 'kuyf', 'Available', 98);

-- --------------------------------------------------------

--
-- Table structure for table `room_customer`
--

CREATE TABLE `room_customer` (
  `RoomId` int(11) NOT NULL,
  `CustomerId` int(11) NOT NULL,
  `DepartureTime` datetime NOT NULL,
  `ArrivalTime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `room_customer`
--

INSERT INTO `room_customer` (`RoomId`, `CustomerId`, `DepartureTime`, `ArrivalTime`) VALUES
(1, 1, '2001-06-06 12:34:56', '2001-07-06 12:34:56'),
(2, 2, '2023-05-04 12:34:56', '2023-05-04 12:34:56'),
(3, 6, '2023-05-05 11:46:19', '2023-05-05 11:46:19'),
(4, 3, '2023-05-05 11:47:01', '2023-05-05 11:47:01'),
(5, 4, '2023-05-05 11:43:38', '2023-05-05 11:43:38'),
(6, 5, '2023-05-05 11:43:49', '2023-05-05 11:43:49');

-- --------------------------------------------------------

--
-- Table structure for table `user_profile`
--

CREATE TABLE `user_profile` (
  `AssignedRole` varchar(99) NOT NULL,
  `Name` varchar(99) NOT NULL,
  `UserID` int(11) NOT NULL,
  `UName` varchar(16) NOT NULL,
  `Password` varchar(99) NOT NULL,
  `Phone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_profile`
--

INSERT INTO `user_profile` (`AssignedRole`, `Name`, `UserID`, `UName`, `Password`, `Phone`) VALUES
('User', 'ABC', 1, 'ABC', 'abc', 123),
('User', 'DEF', 2, 'DEF', 'def', 456),
('User', 'Mihiduni Wariyapola', 3, 'Mihiduni8', 'mhdn', 714567777),
('User', 'Radika Manasinghe', 4, 'radikaradika', 'rdk77', 714568888),
('User', 'Naduni Perera', 5, 'naduniz', '987986', 778988888),
('User', 'Pramitha Perera', 6, 'prmy54', '987uygyghj', 714561234);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `hotel`
--
ALTER TABLE `hotel`
  ADD PRIMARY KEY (`HotelID`);

--
-- Indexes for table `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`RoomID`),
  ADD KEY `cidfk` (`CustomerId`);

--
-- Indexes for table `room_customer`
--
ALTER TABLE `room_customer`
  ADD PRIMARY KEY (`RoomId`,`CustomerId`),
  ADD UNIQUE KEY `RoomId_2` (`RoomId`),
  ADD UNIQUE KEY `CustomerId` (`CustomerId`),
  ADD KEY `RoomId` (`RoomId`);

--
-- Indexes for table `user_profile`
--
ALTER TABLE `user_profile`
  ADD PRIMARY KEY (`UserID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `rooms`
--
ALTER TABLE `rooms`
  ADD CONSTRAINT `cidfk` FOREIGN KEY (`CustomerId`) REFERENCES `customers` (`CustomerID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `room_customer`
--
ALTER TABLE `room_customer`
  ADD CONSTRAINT `cidfk2` FOREIGN KEY (`CustomerId`) REFERENCES `customers` (`CustomerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `ridfk1` FOREIGN KEY (`RoomId`) REFERENCES `rooms` (`RoomID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

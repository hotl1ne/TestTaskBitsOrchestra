-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Сен 27 2024 г., 07:27
-- Версия сервера: 5.7.24
-- Версия PHP: 8.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `person`
--

-- --------------------------------------------------------

--
-- Структура таблицы `people`
--

CREATE TABLE `people` (
  `Id` int(11) NOT NULL,
  `Name` longtext NOT NULL,
  `DateOfBirth` datetime(6) NOT NULL,
  `Married` tinyint(1) NOT NULL,
  `Phone` longtext NOT NULL,
  `Salary` decimal(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `people`
--

INSERT INTO `people` (`Id`, `Name`, `DateOfBirth`, `Married`, `Phone`, `Salary`) VALUES
(14, 'Misha Kurytsia', '2004-06-19 00:00:00.000000', 0, '+380630789459', '1000.00'),
(15, 'Artem Artemenko', '2005-12-12 00:00:00.000000', 0, '+380954070159', '999.00'),
(16, 'Ivan Ivanenko', '2000-02-18 00:00:00.000000', 1, '+380324564545', '1500.00'),
(17, 'Vasyl Vasylenko', '2001-12-12 00:00:00.000000', 1, '+380660733322', '1700.00');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `people`
--
ALTER TABLE `people`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `people`
--
ALTER TABLE `people`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

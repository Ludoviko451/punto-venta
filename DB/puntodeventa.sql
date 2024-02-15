-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-02-2024 a las 00:13:10
-- Versión del servidor: 10.4.27-MariaDB
-- Versión de PHP: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `puntodeventa`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `billing`
--

CREATE TABLE `billing` (
  `Id` int(11) NOT NULL,
  `bill_code` int(11) NOT NULL,
  `product` varchar(255) NOT NULL,
  `price_byUnit` varchar(255) NOT NULL,
  `quantity` int(11) NOT NULL,
  `total_price` varchar(255) NOT NULL,
  `customer` varchar(255) NOT NULL,
  `customerDiscount` int(11) NOT NULL,
  `total_amount` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `billing`
--

INSERT INTO `billing` (`Id`, `bill_code`, `product`, `price_byUnit`, `quantity`, `total_price`, `customer`, `customerDiscount`, `total_amount`) VALUES
(1, 1, 'Smartphone', '699,99', 2, '1399,98', 'Karla EnriqueSanchez Carvajal', 10, '3049,16'),
(2, 1, 'Smartphone', '699,99', 2, '1399,98', 'Karla EnriqueSanchez Carvajal', 10, '3049,16');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `customers`
--

CREATE TABLE `customers` (
  `id` int(11) NOT NULL,
  `customer_name` varchar(255) NOT NULL,
  `customer_lastName` varchar(255) NOT NULL,
  `customer_phoneNumber` varchar(255) NOT NULL,
  `customer_email` varchar(255) NOT NULL,
  `customerCode` varchar(255) NOT NULL,
  `discount` varchar(255) NOT NULL,
  `purchase_quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `customers`
--

INSERT INTO `customers` (`id`, `customer_name`, `customer_lastName`, `customer_phoneNumber`, `customer_email`, `customerCode`, `discount`, `purchase_quantity`) VALUES
(1, 'Karla Enrique', 'Sanchez Carvajal', '3202165343', 'karla@gmail.com', 'AED1', '10', 20);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventory`
--

CREATE TABLE `inventory` (
  `id` int(11) NOT NULL,
  `product_name` varchar(255) NOT NULL,
  `category` varchar(255) NOT NULL,
  `price` varchar(255) NOT NULL,
  `quantity` varchar(255) NOT NULL,
  `Code` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `inventory`
--

INSERT INTO `inventory` (`id`, `product_name`, `category`, `price`, `quantity`, `Code`) VALUES
(1, 'Smartphone', 'Electronics', '699.99', '15', 'PQR678'),
(2, 'Tablet', 'Electronics', '299.99', '10', 'STU901'),
(3, 'Gaming Console', 'Electronics', '399.99', '8', 'VWX234'),
(4, 'Wireless Mouse', 'Electronics', '29.99', '25', 'YZA567'),
(5, 'Printer', 'Electronics', '199.99', '6', 'BCD890'),
(6, 'Coffee Maker', 'Appliances', '79.99', '12', 'EFG123'),
(7, 'Blender', 'Appliances', '49.99', '18', 'HIJ456'),
(8, 'Toaster', 'Appliances', '39.99', '20', 'KLM789'),
(9, 'Microwave', 'Appliances', '129.99', '7', 'NOP012'),
(10, 'Vacuum Cleaner', 'Appliances', '149.99', '9', 'QRS345'),
(11, 'Dining Table', 'Furniture', '299.99', '4', 'TUV678'),
(12, 'Sofa', 'Furniture', '599.99', '3', 'WXY901'),
(13, 'Bed', 'Furniture', '799.99', '2', 'ZAB234'),
(14, 'Bookshelf', 'Furniture', '149.99', '6', 'CDE567'),
(15, 'Office Desk', 'Furniture', '249.99', '5', 'FGH890'),
(16, 'Pencil', 'Office Supplies', '0.99', '100', 'IJK123'),
(17, 'Ballpoint Pen', 'Office Supplies', '1.49', '80', 'LMN456'),
(18, 'Stapler', 'Office Supplies', '2.99', '40', 'OPQ789'),
(19, 'Notebook', 'Office Supplies', '3.99', '60', 'RST012'),
(20, 'Backpack', 'Office Supplies', '19.99', '20', 'UVW345'),
(21, 'Jeans', 'Apparel', '39.99', '25', 'XYZ678'),
(22, 'Dress Shirt', 'Apparel', '29.99', '35', 'ABC901'),
(23, 'Sneakers', 'Apparel', '59.99', '15', 'DEF234'),
(24, 'Winter Jacket', 'Apparel', '79.99', '10', 'GHI567'),
(25, 'Swimsuit', 'Apparel', '34.99', '20', 'JKL890');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `person`
--

CREATE TABLE `person` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `identity_card` varchar(255) NOT NULL,
  `user` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `phone_number` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `person`
--

INSERT INTO `person` (`id`, `name`, `last_name`, `identity_card`, `user`, `password`, `phone_number`) VALUES
(1, 'Juan', 'Pérez', '12345678A', 'juanperez', 'clave123', '123456789'),
(2, 'María', 'López', '87654321B', 'marialopez', 'password123', '987654321'),
(3, 'Pedro', 'González', '56781234C', 'pedrogonzalez', 'securepass', '456789123'),
(4, 'Ana', 'Martínez', '43218765D', 'anamartinez', 'abc123', '789123456'),
(5, 'Ricardinho', 'Lolazo', '123', 'ricardo', '22', '3323');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `billing`
--
ALTER TABLE `billing`
  ADD PRIMARY KEY (`Id`);

--
-- Indices de la tabla `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `billing`
--
ALTER TABLE `billing`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `customers`
--
ALTER TABLE `customers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `inventory`
--
ALTER TABLE `inventory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT de la tabla `person`
--
ALTER TABLE `person`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

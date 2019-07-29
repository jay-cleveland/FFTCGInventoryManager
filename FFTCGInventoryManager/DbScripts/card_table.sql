CREATE TABLE `card` (
  `card_id` varchar(45) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `power` int(11) DEFAULT NULL,
  `image` varchar(255) DEFAULT NULL,
  `rarity` varchar(45) DEFAULT NULL,
  `job` varchar(45) DEFAULT NULL,
  `cost` int(11) DEFAULT NULL,
  `element` varchar(45) DEFAULT NULL,
  `type` varchar(45) DEFAULT NULL,
  `category` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`card_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

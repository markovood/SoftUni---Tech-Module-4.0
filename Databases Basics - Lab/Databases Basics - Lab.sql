CREATE DATABASE `softuni` /*!40100 COLLATE 'utf8_general_ci' */;

USE `softuni`;

CREATE TABLE `students` (
	`id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	`first_name` VARCHAR(50) NULL,
	`last_name` VARCHAR(50) NULL,
	`age` INT NULL,
	`grade` DOUBLE NULL
)
COLLATE='utf8_general_ci';

INSERT INTO `softuni`.`students` (`first_name`, `last_name`, `age`, `grade`) VALUES ('Guy', 'Gilbert', '15', '4.5');
INSERT INTO `softuni`.`students` (`first_name`, `last_name`, `age`, `grade`) VALUES ('Kevin', 'Brown', '17', '5.4');
INSERT INTO `softuni`.`students` (`first_name`, `last_name`, `age`, `grade`) VALUES ('Roberto', 'Tamburello', '19', '6');
INSERT INTO `softuni`.`students` (`first_name`, `last_name`, `age`, `grade`) VALUES ('Linda', 'Smith', '18', '5');
INSERT INTO `softuni`.`students` (`first_name`, `last_name`, `age`, `grade`) VALUES ('John', 'Stones', '16', '4.25');
INSERT INTO `softuni`.`students` (`first_name`, `last_name`, `age`, `grade`) VALUES ('Nicole', 'Nelson', '17', '5.50');

SELECT * 
FROM `students`;

SELECT last_name, age, grade
FROM `students`;

SELECT * 
FROM `students`
WHERE id <= 5;

SELECT last_name, grade
FROM `students`
WHERE id <= 5;

TRUNCATE TABLE `students`;

DROP TABLE `students`;

DROP DATABASE `softuni`;
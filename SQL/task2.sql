CREATE TABLE `Customers`(`Id` INT AUTO_INCREMENT,
`Name` VARCHAR(100) NOT NULL,
PRIMARY KEY(`Id`)
);
INSERT INTO `Customers`(`Name`) VALUES('Max');
INSERT INTO `Customers`(`Name`) VALUES('Pavel');
INSERT INTO `Customers`(`Name`) VALUES('Ivan');
INSERT INTO `Customers`(`Name`) VALUES('Leonid');
CREATE TABLE `Orders`(`Id` INT AUTO_INCREMENT,
`CustomerId` INT NOT NULL,
PRIMARY KEY(`Id`)
);
INSERT INTO `Orders`(`CustomerId`) VALUES('2');
INSERT INTO `Orders`(`CustomerId`) VALUES('4');

SELECT `Name` as `Customers` FROM `Customers` WHERE (SELECT COUNT(*) FROM `Orders` WHERE `Customers`.`Id`=`CustomerId`)=0;


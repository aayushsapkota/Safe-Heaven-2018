CREATE TABLE `User` (
	`userId` INT(11) NOT NULL,
	`userName` varchar(128) NOT NULL UNIQUE,
	`userEmail` varchar(128) NOT NULL,
	`userPassword` varchar(256) NOT NULL,
	`userFullName` varchar(128) NOT NULL,
	`userRegistrationTime` TIMESTAMP NOT NULL,
	`userAccessId` INT(5) NOT NULL,
	`playerId` INT(11) NOT NULL,
	PRIMARY KEY (`userId`)
);

CREATE TABLE `Page` (
	`pageId` INT NOT NULL AUTO_INCREMENT,
	`pageHeading` varchar(256),
	`pageSubHeading` varchar(256),
	`pageContent1` varchar(1024),
	`pageContent2` varchar(1024),
	`pageContent3` varchar(1024),
	`pageContent4` varchar(1024),
	`pageContent5` varchar(1024),
	`pageHeading1` varchar(256),
	`pageHeading2` varchar(256),
	`pageHeading3` varchar(256),
	`pageHeading4` varchar(256),
	`pageHeading5` varchar(256),
	`pageHeading5` varchar(256),
	PRIMARY KEY (`pageId`)
);

CREATE TABLE `Player` (
	`playerId` INT(11) NOT NULL AUTO_INCREMENT,
	`playerUsername` varchar(128) NOT NULL,
	`playerPlayTime` TIME NOT NULL AUTO_INCREMENT,
	`playerDate` DATETIME NOT NULL,
	PRIMARY KEY (`playerId`)
);

CREATE TABLE `Score` (
	`scoreId` INT(11) NOT NULL AUTO_INCREMENT,
	`scoreValue` INT(8) NOT NULL AUTO_INCREMENT,
	`playerId` INT(11) NOT NULL,
	PRIMARY KEY (`scoreId`)
);

CREATE TABLE `Access` (
	`accessId` INT(5) NOT NULL AUTO_INCREMENT,
	`accessName` varchar(128) NOT NULL,
	`accessDescription` varchar(256) NOT NULL,
	PRIMARY KEY (`accessId`)
);

CREATE TABLE `level` (
	`levelId` INT(4) NOT NULL AUTO_INCREMENT,
	`levelName` varchar(128) NOT NULL,
	`levelDescription` varchar(256) NOT NULL,
	PRIMARY KEY (`levelId`)
);

CREATE TABLE `Log` (
	`logId` INT(14) NOT NULL AUTO_INCREMENT,
	`logtime` TIMESTAMP NOT NULL,
	`logDecsription` varchar(256) NOT NULL,
	`userId` INT(11) NOT NULL,
	PRIMARY KEY (`logId`)
);

CREATE TABLE `MaxScore` (
	`scoreId` INT(11) NOT NULL,
	`playerId` BINARY(11) NOT NULL
);

CREATE TABLE `Progress` (
	`progressId` INT(12) NOT NULL,
	`levelId` INT(4) NOT NULL,
	`userId` INT(11) NOT NULL
);

ALTER TABLE `User` ADD CONSTRAINT `User_fk0` FOREIGN KEY (`userAccessId`) REFERENCES `Access`(`accessId`);

ALTER TABLE `User` ADD CONSTRAINT `User_fk1` FOREIGN KEY (`playerId`) REFERENCES `Player`(`playerId`);

ALTER TABLE `Score` ADD CONSTRAINT `Score_fk0` FOREIGN KEY (`playerId`) REFERENCES `Player`(`playerId`);

ALTER TABLE `Log` ADD CONSTRAINT `Log_fk0` FOREIGN KEY (`userId`) REFERENCES `User`(`userId`);

ALTER TABLE `MaxScore` ADD CONSTRAINT `MaxScore_fk0` FOREIGN KEY (`scoreId`) REFERENCES `Score`(`scoreId`);

ALTER TABLE `MaxScore` ADD CONSTRAINT `MaxScore_fk1` FOREIGN KEY (`playerId`) REFERENCES `Player`(`playerId`);

ALTER TABLE `Progress` ADD CONSTRAINT `Progress_fk0` FOREIGN KEY (`levelId`) REFERENCES `level`(`levelId`);

ALTER TABLE `Progress` ADD CONSTRAINT `Progress_fk1` FOREIGN KEY (`userId`) REFERENCES `User`(`userId`);


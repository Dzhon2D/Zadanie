CREATE DATABASE BD 
ON
(
	NAME = 'BD',				
	FILENAME = 'C:\database\BD.mdf',
	SIZE = 20MB,
	MAXSIZE = 150MB,
	FILEGROWTH = 20MB
)
LOG ON
( 
	NAME = 'Log_BD',
	FILENAME = 'C:\database\BD.ldf',
	SIZE = 20MB,
	MAXSIZE = 150MB,
	FILEGROWTH = 20MB
)               
COLLATE Cyrillic_General_CI_AS
GO

USE BD

GO

DROP TABLE Tyr
DROP TABLE Gorod
DROP TABLE Region
DROP TABLE Strana

CREATE TABLE Strana
(
 Nomer int IDENTITY NOT NULL PRIMARY KEY,
 Name varchar(30) NOT NULL
)
GO

CREATE TABLE Region
(
 Nomer int IDENTITY NOT NULL PRIMARY KEY,
 ID_Strana int not null,
 Name varchar(30) NOT NULL
       FOREIGN KEY(ID_Strana) REFERENCES Strana(Nomer)
)
GO

CREATE TABLE Gorod
(
 Nomer int IDENTITY NOT NULL PRIMARY KEY,
 ID_Strana int not null,
 ID_Region int not null,
 Name varchar(30) NOT NULL
       FOREIGN KEY(ID_Strana) REFERENCES Strana(Nomer),
       FOREIGN KEY(ID_Region) REFERENCES Region(Nomer)
)
GO

CREATE TABLE Tyr
(
 Nomer int IDENTITY NOT NULL PRIMARY KEY,
 ID_Strana int not null,
 ID_Region int not null,
 ID_Gorod int not null,
 Name varchar(30) NOT NULL,
 Price int not null,
 Chislo_tyristov int not null,
       FOREIGN KEY(ID_Strana) REFERENCES Strana(Nomer),
       FOREIGN KEY(ID_Region) REFERENCES Region(Nomer),
	   FOREIGN KEY(ID_Gorod) REFERENCES Gorod(Nomer)
)
GO

INSERT INTO Strana
(Name)
VALUES
('Россия'),
('Турция')
GO

INSERT INTO Region
(ID_Strana, Name)
VALUES
(1,'Астраханская область'),
(1,'Волгоградская область'),
(2,'Анталия')
GO

INSERT INTO Gorod
(ID_Strana, ID_Region, Name)
VALUES
(1,1,'Астрахань'),
(1,2,'Волгоград'),
(2,3,'Анталия'),
(2,3,'Серик')
GO

INSERT INTO Tyr
(ID_Strana, ID_Region, ID_Gorod, Name, Price, Chislo_tyristov)
VALUES
(1,1,1,'123',10000,2),
(1,2,2,'321',20000,4),
(2,3,3,'123',5000,2),
(2,3,4,'321',8500,3)
GO


SELECT * FROM Strana
SELECT * FROM Region
SELECT * FROM Gorod
SELECT * FROM Tyr
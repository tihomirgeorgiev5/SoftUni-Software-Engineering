CREATE TABLE [Manufacturers] (
[ManufacturerID] INT PRIMARY KEY IDENTITY NOT NULL,
[Name] VARCHAR(50) NOT NULL,
[EstablishedOn] DATE NOT NULL)

CREATE TABLE [Models] (
[ModelID] INT PRIMARY KEY IDENTITY(101, 1) NOT NULL,
[Name] VARCHAR(50) NOT NULL,
[ManufacturerID] INT FOREIGN KEY REFERENCES [Manufacturers] ([ManufacturerID]))

INSERT INTO [Manufacturers] ([Name],[EstablishedOn])
VALUES
('BMW','07/03/1916'),
('Tesla','01/01/2003'),
('Lada','01/05/1966')

SELECT * FROM [Manufacturers]

INSERT INTO [Models] ([Name],[ManufacturerID])
VALUES
('X1',1),
('i6',1),
('Model S',2),
('Model X',2),
('Model 3',2),
('Nova',3)
--USE [EntityRelationsDemo]
--
--CREATE TABLE [Students] (
--[StudentID] INT PRIMARY KEY IDENTITY NOT NULL,
--[Name] VARCHAR(10) NOT NULL)
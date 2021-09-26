-- 04. Insert Records in Both Tables

INSERT INTO Towns(Id, [Name]) VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')


INSERT INTO Minions(Id, [Name], Age, TownId) VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', Null, 2)


--08.Create Table Users

CREATE TABLE Users (
Id BIGINT PRIMARY KEY IDENTITY,
Username VARCHAR(30) NOT NULL UNIQUE,
[Password] VARCHAR(26) NOT NULL,
ProfilePicture VARBINARY (MAX),
LastLoginTime DATETIME,
IsDeleted BIT
)

INSERT INTO Users (
Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
VALUES
('Stamat', '123', NULL, CONVERT(datetime, '22-05-2018',103), 0),
('Gosho', '1234545', NULL, CONVERT(datetime, '22-05-2018',103), 0),
('Pesho', '12354354', NULL, CONVERT(datetime, '22-05-2018',103), 0),
('Vankata', '1235345', NULL, CONVERT(datetime, '22-05-2018',103), 0),
('Kircata', '123453', NULL, CONVERT(datetime, '22-05-2018',103), 0)


--20. Basic Select All Fields and Order Them

SELECT * FROM Towns

SELECT * FROM Departments

SELECT * FROM Employees


--21. Basic Select Some Fields

SELECT [Name] FROM Towns
ORDER BY [Name]

SELECT [Name] FROM Departments
ORDER BY [Name]

SELECT FirstName, LastName, JobTitle, Salary FROM Employees
ORDER BY Salary DESC


--22. Increase Employees Salary

UPDATE Employees
SET Salary *= 1.1

SELECT Salary FROM Employees


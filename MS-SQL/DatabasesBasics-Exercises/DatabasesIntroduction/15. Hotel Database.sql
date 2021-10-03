CREATE DATABASE [Hotel]
 USE [Hotel]

 CREATE TABLE [Employees] (
 [Id] INT PRIMARY KEY IDENTITY,
 [FirstName] NVARCHAR(50) NOT NULL,
 [LastName] NVARCHAR(50) NOT NULL,
 [Title] NVARCHAR(50) NOT NULL,
 [Notes] NVARCHAR(100))

 INSERT INTO [Employees] (
 [FirstName], [LastName], [Title]) VALUES
 ('IVAN','IVANOV','JUNIOR'),
 ('PETAR','PETROV','SENIOR'),
 ('STEFAN','IVANOV','DOCTOR')

 CREATE TABLE [Customers] (
 [AccountNumber] INT PRIMARY KEY IDENTITY ,
 [FirstName] NVARCHAR(50) NOT NULL,
 [LastName] NVARCHAR(50) NOT NULL,
 [PhoneNumber] NVARCHAR(20) NOT NULL,
 [EmergencyName] NVARCHAR(50) NOT NULL,
 [EmergencyNumber] NVARCHAR(20) NOT NULL,
 [Notes] NVARCHAR(100)) 

 INSERT INTO [Customers] (
 [FirstName], [LastName], [PhoneNumber],
 [EmergencyName], [EmergencyNumber]) VALUES
 ('IVAN','IVANOV','0768876876','Burns','112'),
 ('PETAR','PETROV','0876567567','Burns','112'),
 ('STEFAN','IVANOV','0886567567','Burns','112')


 CREATE TABLE [RoomStatus] (
 [RoomStatus] NVARCHAR(10) PRIMARY KEY,
 [Notes] NVARCHAR(100))

 INSERT INTO [RoomStatus] ([RoomStatus]) VALUES
 ('RESERVE'),
 ('FREE'),
 ('OCCUPIED')

 CREATE TABLE [RoomTypes] (
 [RoomType]  NVARCHAR(10) PRIMARY KEY,
 [Notes] NVARCHAR(100))

 INSERT INTO [RoomTypes] ([RoomType]) VALUES
 ('SINGLE'),
 ('DOUBLE'),
 ('APPARTMENT')

 CREATE TABLE [BedTypes] (
 [BedType]  NVARCHAR(10) PRIMARY KEY,
 [Notes] NVARCHAR(100))

 INSERT INTO [BedTypes] ([BedType]) VALUES
 ('DOUBLE'),
 ('SINGLE'),
 ('SOFA')

 CREATE TABLE [Rooms] (
 [RoomNumber] INT PRIMARY KEY IDENTITY,
 [RoomType] NVARCHAR(10) FOREIGN KEY REFERENCES [RoomTypes](RoomType), 
 [BedType] NVARCHAR(10) FOREIGN KEY REFERENCES [BedTypes](BedType),
 [Rate] DECIMAL(5,1) NOT NULL, 
 [RoomStatus] NVARCHAR(20) NOT NULL, 
 [Notes] NVARCHAR (100))

 INSERT INTO [Rooms] (
 [RoomType],
 [BedType],
 [Rate],
 [RoomStatus]) VALUES
 ('SINGLE','DOUBLE',33.3,'CLOSE'),
 ('DOUBLE','SINGLE',44.4,'OPEN'),
 ('APPARTMENT','SOFA',55.5,'CLOSE')


 CREATE TABLE [Payments] (
 [Id] INT PRIMARY KEY IDENTITY,
 [EmployeeId] INT FOREIGN KEY REFERENCES [Employees](Id),
 [PaymentDate] DATETIME2 NOT NULL,
 [AccountNumber] INT FOREIGN KEY REFERENCES [Customers](AccountNumber),
 [FirstDateOccupied] DATETIME2 NOT NULL,
 [LastDateOccupied] DATETIME2 NOT NULL,
 [TotalDays] AS DATEDIFF(DAY,FirstDateOccupied,LastDateOccupied),
 [AmountCharged] DECIMAL(6,2) NOT NULL,
 [TaxRate] DECIMAL (5,2) NOT NULL,
 [TaxAmount]AS AmountCharged * TaxRate,
 [PaymentTotal] DECIMAL(6,2) NOT NULL,
 [Notes] NVARCHAR(100))

 INSERT INTO [Payments] (
 [PaymentDate],
 [AccountNumber],
 [FirstDateOccupied],
 [LastDateOccupied], 
 [AmountCharged],
 [TaxRate],
 [PaymentTotal]) VALUES
 ('2020-02-23','1','2020-05-12','2020-05-15',110,12,250),
 ('2020-02-23','2','2020-05-13','2020-05-15',210,12,250),
 ('2020-02-23','3','2020-05-14','2020-05-15',310,12,250)

 CREATE TABLE [Occupancies] (
 [Id] INT PRIMARY KEY IDENTITY,
 [EmployeeId]  INT FOREIGN KEY REFERENCES [Employees](Id),
 [DateOccupied] DATETIME2 NOT NULL,
 [AccountNumber] INT FOREIGN KEY REFERENCES [Customers](AccountNumber),
 [RoomNumber] INT FOREIGN KEY REFERENCES [Rooms](RoomNumber),
 [RateApplied] DECIMAL (5,2),
 [PhoneCharge] DECIMAL (5,2),
 [Notes] NVARCHAR(100))

INSERT INTO [Occupancies] (
[DateOccupied],
 [AccountNumber],
 [RoomNumber],
[RateApplied],
[PhoneCharge]) VALUES
('2020-05-23',1,1,32.2,10),
('2020-05-23',2,2,32.2,10),
('2020-05-23',3,3,32.2,10)


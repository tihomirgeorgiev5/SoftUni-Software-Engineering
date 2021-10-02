
 CREATE TABLE [Categories] (
             [Id] INT IDENTITY PRIMARY KEY,
             [CategoryName] NVARCHAR(50) NOT NULL,
             [DailyRate] DECIMAL(5,2) NOT NULL,
             [WeeklyRate] DECIMAL(5,2) NOT NULL,
             [MonthlyRate] DECIMAL(5,2) NOT NULL,
             [WeekendRate] DECIMAL(5,2) NOT NULL
             )
			 SELECT * FROM [Categories]


 CREATE TABLE [Cars] (
             [Id] INT IDENTITY PRIMARY KEY,
             [PlateNumber] NVARCHAR(50) NOT NULL,
             [Manufacturer] NVARCHAR(50) NOT NULL,
             [Model] NVARCHAR(50) NOT NULL,
             [CarYear] INT NOT NULL,
             [CategoryId] INT FOREIGN KEY REFERENCES [Categories](Id),
             [Doors] INT NOT NULL,
             [Picture] VARBINARY(MAX),
             [Condition] NVARCHAR(50),
             [Available] BIT NOT NULL,
			 )
			 
CREATE TABLE [Employees] (
			 [Id] INT IDENTITY PRIMARY KEY,
			 [FirstName] NVARCHAR(50) NOT NULL,
			 [LastName] NVARCHAR(50) NOT NULL,
			 [Title] NVARCHAR(30) NOT NULL,
			 [Notes] NVARCHAR(MAX)
			 )
		
CREATE TABLE [Customers] (
			 [Id] INT IDENTITY PRIMARY KEY,
			 [DriverLicenceNumber] NVARCHAR(50) NOT NULL,
			 [FullName] NVARCHAR(100) NOT NULL,
			 [Address] NVARCHAR(100),
			 [City] NVARCHAR(20) NOT NULL,
			 [ZIPCode] NVARCHAR(30) NOT NULL,
			 [Notes] NVARCHAR(100)
			 )

CREATE TABLE [RentalOrders] (
			 [Id] INT IDENTITY PRIMARY KEY,
			 [EmployeeId] INT FOREIGN KEY REFERENCES [Employees](Id),
			 [CustomerId] INT FOREIGN KEY REFERENCES [Customers](Id),
			 [CarId] INT FOREIGN KEY REFERENCES [Cars](Id),
			 [TankLevel] INT NOT NULL,
			 [KilometrageStart] INT NOT NULL,
			 [KilometrageEnd] INT NOT NULL,
			 [TotalKilometrage] AS [KilometrageStart] - [KilometrageEnd],
			 [StartDate] DATETIME2 NOT NULL,
			 [EndDate] DATETIME2 NOT NULL,
			 [TotalDays] AS DATEDIFF(Day,[StartDate],[EndDate]),
			 [RateApplied] DECIMAL(5,2),
			 [TaxRate] DECIMAL(7,2),
			 [OrderStatus] NVARCHAR(30) NOT NULL,
			 [Notes] NVARCHAR(100)
		)

		INSERT INTO [Categories] (
			 [CategoryName],
			 [DailyRate],
			 [WeeklyRate],
			 [MonthlyRate],
			 [WeekendRate])
VALUES
			 ('SEDAN',99.99,10.67,23.56,67.23),
			 ('MINIVAN',99.99,23.56,34.56,67.23),
			 ('COUPE',99.99,23.56,34.56,67.23)
			 
		INSERT INTO [Cars](
			 [PlateNumber],
			 [Manufacturer],
			 [Model], 
			 [CarYear],
			 [CategoryId],
			 [Doors],
			 [Picture],
			 [Condition],
			 [Available])
			 VALUES
			 ('B4567KA','TOYOTA','COROLLA',2004,6,5,NULL,'YES',1),
			 ('B2345HK','TOYOTA','COROLLA',2004,6,5,NULL,'YES',0),
			 ('B4569KA','TOYOTA','COROLLA',2004,6,5,NULL,'YES',1)


		INSERT INTO [Employees] (
			 FirstName, LastName, Title)
			 VALUES
			 ('CEKO','IVANOV','JUNIOR'),
			 ('IVAN','PETKOV','SENIOR'),
			 ('STEFAN','DIMITROV','MASTER')
		INSERT INTO [Customers] (
			 [DriverLicenceNumber],
			 [FullName],
			 [Address], 
			 [City],
			 [ZIPCode])
			 VALUES
			 ('32131234','IVAN IVANOV SPASOV','TIMES SQ 2','LONDON','34567'),
			 ('53453455','STEFAN PETKOV PETROV','ST.NEDELIA 5','SOFIA','5678'),
			 ('54435345','FILIP FILIPOV PETROV','BOZHURISHTE','SOFIA','2342')

		INSERT INTO [RentalOrders] (
		[EmployeeId],
		[CustomerId],
		[CarId],
		[TankLevel],
		[KilometrageStart],
		[KilometrageEnd],
		[StartDate],
		[EndDate],
		[RateApplied],
		[TaxRate],
		[OrderStatus])
		VALUES
		(1,1,4,6,500,999,'2021-05-23','2021-05-25',68.00,25.00,'TRUE'),
		(2,2,4,6,500,999,'2021-05-23','2021-05-25',69.00,25.00,'FALSE'),
		(3,3,4,6,500,999,'2021-05-23','2021-05-25',70.00,25.00,'TRUE')










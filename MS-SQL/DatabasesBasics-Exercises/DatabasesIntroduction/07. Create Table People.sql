CREATE TABLE [People] (
[Id] INT PRIMARY KEY IDENTITY NOT NULL ,
[Name] NVARCHAR(200) NOT NULL,
[Picture] VARBINARY(MAX),
CHECK ([Picture] <= 2000000),
[Height] DECIMAL(5,2),
[Weight] DECIMAL(5,2),
[Gender] CHAR(1) NOT NULL,
CHECK ([Gender] = 'm' OR [Gender] = 'f'),
[Birthdate] DATE NOT NULL,
[Biography] NVARCHAR(MAX)
)

INSERT INTO [People]([Name],[Picture],[Height],[Weight],[Gender],[Birthdate],[Biography]) VALUES
('tisho',Null,1.90,74.55,'m','1986-06-19',Null),
('todor',Null,2.15,95.55,'m','1989-11-02',Null),
('stamat',Null,1.55,33.00,'m','2010-04-11','sdfsdfsdfsd'),
('gosho',Null,2.15,55.55,'m','2001-11-11','saasdasdadasasdadasdasdasssd'),
('maria',Null,1.70,54.55,'f','1999-09-09',Null)







CREATE TABLE [Directors] (
[Id] INT IDENTITY PRIMARY KEY,
[DirectorName] NVARCHAR(100) NOT NULL,
[Notes] NVARCHAR(200),
)

CREATE TABLE [Genres] (
[Id] INT IDENTITY PRIMARY KEY,
[GenreName] NVARCHAR(100) NOT NULL,
[Notes] NVARCHAR(200),
)

CREATE TABLE [Categories] (
[Id] INT IDENTITY PRIMARY KEY,
[CategoryName] NVARCHAR(100) NOT NULL,
[Notes] NVARCHAR(200),
)

CREATE TABLE [Movies] (
[Id] INT IDENTITY PRIMARY KEY,
[Title] NVARCHAR(100) NOT NULL,
[DirectorId] INT FOREIGN KEY REFERENCES Directors(Id),
[CopyrightYear] INT NOT NULL,
[Length] TIME NOT NULL,
[GenreId] INT FOREIGN KEY REFERENCES Genres(Id),
[CategoryId] INT FOREIGN KEY REFERENCES Categories(Id),
[Rating] DECIMAL(3,1) NOT NULL,
[Notes] NVARCHAR(200),
)



INSERT INTO [Directors] ([DirectorName],[Notes]) VALUES
('dsadasd',NULL),
('dfadsd',NULL),
('dsdd',NULL),
('dsdsd',NULL),
('dsdd',NULL)


INSERT INTO [Categories] ([CategoryName],[Notes]) VALUES
('artist',NULL),
('pevec',NULL),
('futbolist',NULL),
('ritnitopkovec',NULL),
('muzikant',NULL)

INSERT INTO [Genres] ([GenreName],[Notes]) VALUES
('Pesho',NULL),
('Stamat',NULL),
('Kolio',NULL),
('Stefan',NULL),
('Paco',NULL)

INSERT INTO [Movies] ([Title],[DirectorId],[CopyrightYear], [Length], [GenreId], [CategoryId], [Rating]) VALUES
('nqkoi',1,1834,'1:48:00',1,2,5.6),
('nqkoisi',2,1987,'1:48:00',2,3,5.8),
('nqkoitamsi',3,1986,'1:48:00',3,4,7.2),
('nqkoiverno',4,1999,'1:48:00',4,5,9.2),
('evernonqkoi',5,1965,'1:48:00',5,1,1.8)









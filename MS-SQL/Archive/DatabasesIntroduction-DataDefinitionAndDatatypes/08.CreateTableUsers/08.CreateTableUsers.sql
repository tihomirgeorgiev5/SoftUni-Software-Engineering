CREATE TABLE Users (
Id BIGINT PRIMARY KEY IDENTITY,
Username VARCHAR(30) UNIQUE NOT NULL,
[Password] VARCHAR(25) NOT NULL,
ProfilePicture VARBINARY(MAX),
CHECK(DATALENGTH(ProfilePicture) <= 921600),
LastLoginTime DATETIME2,
IsDeleted BIT NOT NULL
)

INSERT INTO Users
(Username, [Password], ProfilePicture, LastLoginTime, IsDeleted) VALUES
('Pesho', '123', NULL, NULL, 0),
('Stefan', '123', NULL, NULL, 0),
('Gosho', '123', NULL, NULL, 0),
('Sasho', '123', NULL, NULL, 0),
('test', '123', NULL, NULL, 0)

SELECT * FROM Users



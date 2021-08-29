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

SELECT * FROM Users

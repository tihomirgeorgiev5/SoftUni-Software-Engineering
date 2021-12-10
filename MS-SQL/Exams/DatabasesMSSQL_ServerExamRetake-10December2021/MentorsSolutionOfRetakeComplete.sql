--1. DDL

CREATE TABLE Passengers(
Id INT PRIMARY KEY IDENTITY,
FullName VARCHAR(100) UNIQUE NOT NULL,
Email VARCHAR(50) UNIQUE NOT NULL,
)


CREATE TABLE Pilots(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(30) UNIQUE NOT NULL,
LastName  VARCHAR(30) UNIQUE NOT NULL,
Age TINYINT CHECK(Age >= 21 AND Age <= 62) NOT NULL,
Rating FLOAT CHECK(Rating >= 0.0 AND Rating <= 10.1),
)

CREATE TABLE AircraftTypes(
Id INT PRIMARY KEY IDENTITY,
TypeName VARCHAR(30) UNIQUE NOT NULL
)

CREATE TABLE Aircraft(
Id INT PRIMARY KEY IDENTITY,
Manufacturer VARCHAR(25) NOT NULL,
Model VARCHAR(30) NOT NULL,
[Year] INT NOT NULL,
FlightHours INT,
Condition CHAR NOT NULL,
TypeId INT FOREIGN KEY REFERENCES AircraftTypes(Id) NOT NULL
)

CREATE TABLE PilotsAircraft(
AircraftId INT FOREIGN KEY REFERENCES Aircraft(Id) NOT NULL,
PilotId INT FOREIGN KEY REFERENCES Pilots(Id) NOT NULL
PRIMARY KEY(AircraftId, PilotId)
)

CREATE TABLE Airports(
Id INT PRIMARY KEY IDENTITY,
AirportName VARCHAR(70) UNIQUE NOT NULL,
Country VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE FlightDestinations(
Id INT PRIMARY KEY IDENTITY,
AirportId INT FOREIGN KEY REFERENCES Airports(Id) NOT NULL,
[Start] DATETIME NOT NULL,
AircraftId INT FOREIGN KEY REFERENCES Aircraft(Id) NOT NULL,
PassengerId INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL,
TicketPrice DECIMAL(18,2) DEFAULT 15 NOT NULL
)

--2. Insert
INSERT INTO Passengers(FullName, Email)
SELECT  FirstName + ' ' + LastName, FirstName+LastName +'@gmail.com'
FROM Pilots 
WHERE id between 5 and 15

--3. Update
UPDATE Aircraft 
SET 
    Condition = 'A'
WHERE
    Condition IN ('C' , 'B')
        AND (FlightHours <= 100 OR FlightHours IS NULL)
        AND [Year] >= 2013

-- 4. Delete
DELETE FROM Passengers 
WHERE LEN(FullName) <= 10

--5. Aircraft
SELECT Manufacturer,Model,FlightHours,Condition FROM Aircraft
ORDER BY FlightHours DESC

-- 6. Pilots and Aircraft
SELECT p.FirstName,p.LastName,a.Manufacturer,a.Model,a.FlightHours
FROM Pilots AS p
LEFT JOIN PilotsAircraft AS pa
ON p.id=pa.PilotId
LEFT JOIN Aircraft AS a
ON pa.AircraftId=a.id
WHERE a.FlightHours IS NOT NULL AND a.FlightHours < 310
ORDER BY a.FlightHours DESC, p.FirstName ASC

-- 7. Top 20 Flight Destinations
SELECT TOP 20 fd.Id as DestinationId, fd.[Start], p.FullName, a.AirportName, fd.TicketPrice
FROM FlightDestinations as fd
JOIN Passengers as p ON p.Id = fd.PassengerId
JOIN Airports as a ON a.Id = fd.AirportId
WHERE DATEPART(DAY, fd.[Start]) % 2 = 0
ORDER BY fd.TicketPrice DESC, a.AirportName ASC

-- 8. Number of Courses for Each Car
SELECT a.id AS AircraftId, a.Manufacturer, a.FlightHours, count(fd.id) AS FlightDestinationsCount,
ROUND(AVG(fd.TicketPrice), 2) AS AvgPrice 
FROM Aircraft AS a
LEFT JOIN FlightDestinations AS fd
ON a.id = fd.AircraftId
GROUP BY a.id, a.Manufacturer, a.FlightHours
HAVING count(fd.id) > 1
ORDER BY FlightDestinationsCount DESC, AircraftId ASC;

-- 9. Regular Passengers
SELECT ps.FullName, count(a.id) as CountOfAircraft,
sum(fd.TicketPrice) as TotalPayed
FROM Passengers ps
JOIN FlightDestinations fd ON fd.PassengerId = ps.id
JOIN Aircraft a ON a.id = fd.AircraftId
WHERE substring(ps.FullName, 2, 1) = 'a'
GROUP BY ps.id, ps.FullName
HAVING count(a.id) > 1
ORDER BY ps.FullName;

-- 10. Full Info for Flight Destinations 
SELECT al.AirportName, fd.[Start] AS DayTime,
fd.TicketPrice, p.FullName, s.Manufacturer, s.Model
FROM Airports  AS al 
JOIN FlightDestinations AS fd  ON fd.AirportId = al.id
JOIN Passengers AS p ON p.id = fd.PassengerId
JOIN Aircraft AS s ON fd.AircraftId = s.id
JOIN AircraftTypes AS aty ON aty.id = s.TypeId
WHERE DATEPART(HOUR, fd.[Start]) BETWEEN 6 and 20 and TicketPrice > 2500
ORDER BY s.Model ASC;


-- 11. Find all Destination by Passengers’s Email Address
CREATE FUNCTION udf_FlightDestinationsByEmail(@email varchar(50))
RETURNS INT
AS
BEGIN
	DECLARE @count INT = (select count(fd.id)
        from Passengers p
                 left join FlightDestinations fd on p.id = fd.PassengerId
        where p.Email = @email
        group by p.FullName);
		
	RETURN @count
END

SELECT dbo.udf_FlightDestinationsByEmail('MerisShale@gmail.com')


-- 12. Full Info for Airports
CREATE PROCEDURE usp_SearchByAirportName(@airportName VARCHAR(70))
AS
BEGIN
SELECT al.AirportName,
    p.FullName,
    (CASE
        WHEN fd.TicketPrice BETWEEN 15 AND 400 THEN 'Low'
        WHEN fd.TicketPrice BETWEEN 401 AND 1500 THEN 'Medium'
        ELSE 'High'
    END) AS LevelOfTickerPrice, 
    air.Manufacturer, 
    air.Condition,
    aty.TypeName 
	FROM Airports AS al
        LEFT JOIN FlightDestinations AS fd ON al.Id = fd.AirportId
        LEFT JOIN Passengers AS p ON p.Id = fd.PassengerId
		LEFT JOIN Aircraft AS air ON air.Id = fd.AircraftId
		LEFT JOIN AircraftTypes AS aty ON air.TypeId = aty.Id
	WHERE
    al.AirportName  = @airportName
    ORDER BY air.Manufacturer , p.FullName
END

--DROP PROCEDURE usp_SearchByAirportName
EXEC usp_SearchByAirportName 'Sir Seretse Khama International Airport'
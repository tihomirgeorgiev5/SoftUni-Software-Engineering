---03.Update (mySolution)
UPDATE [Aircraft]
 SET [Condition] = 'A'
 WHERE ([Condition] IN ('C','B') AND
 ([FlightHours] IS NULL OR [FlightHours] <= 100) AND
 ([Year] >= 2013)) 

 ---04.Delete(mySolution)
 DELETE FROM [Passengers]
 WHERE LEN([FullName]) <= 10

 ---05.Aircraft
SELECT [Manufacturer],
       [Model],
	   [FlightHours],
	   [Condition]
	   FROM [Aircraft]
	   ORDER BY[FlightHours]DESC
---06.Pilots
	SELECT p.[FirstName],
	       p.[LastName],
		   a.[Manufacturer],
		   a.[Model],
		   a.[FlightHours]
		   FROM [Pilots] AS p
	JOIN [PilotsAircraft] AS pa
	ON p.[Id] = pa.[PilotId]
	JOIN [Aircraft] AS a
	ON pa.[AircraftId] = a.[Id]
	WHERE a.[FlightHours] <= 304
	ORDER BY a.[FlightHours]DESC, p.[FirstName] 
	
---07.Top20
	SELECT TOP(20) fd.[Id]AS [DestinationId],
	       fd.[Start],
		   p.[FullName],
		   a.[AirportName],
		   fd.[TicketPrice]

	    FROM   [FlightDestinations] AS fd
	LEFT JOIN [Passengers] AS p
	ON fd.[PassengerId] = p.[Id]
	LEFT JOIN [Airports] AS a
	ON fd.[AirportId] = a.[Id]
	WHERE (DAY(fd.[Start]) % 2 = 0)
	ORDER BY fd.[TicketPrice]DESC, a.[AirportName]
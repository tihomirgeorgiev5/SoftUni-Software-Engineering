-- 04. Employees from Town
GO
CREATE PROCEDURE usp_GetEmployeesFromTown1 @townName VARCHAR(50)
AS
BEGIN
SELECT e.[FirstName],
       e.[LastName]
FROM [Employees] AS e
LEFT JOIN [Addresses] AS a
ON e.[AddressID] = a.[AddressID]
LEFT JOIN [Towns] AS t
ON a.[TownID] = t.[TownID]
WHERE t.[Name] = @townName
END
GO

--EXEC usp_GetEmployeesFromTown1 'Sofia'
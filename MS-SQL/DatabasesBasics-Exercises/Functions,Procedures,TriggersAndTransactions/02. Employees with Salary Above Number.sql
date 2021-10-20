-- 02. Employees with Salary Above Number
CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber
@minSalary DECIMAL(18,4)
AS
BEGIN
SELECT [FirstName],
       [LastName]
FROM [Employees]
WHERE [Salary] >= @minSalary
END

--EXEC usp_GetEmployeesSalaryAboveNumber 48100
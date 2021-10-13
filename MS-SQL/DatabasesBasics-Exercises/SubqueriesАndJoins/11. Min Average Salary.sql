USE [Softuni]

SELECT TOP(1) AVG(Salary) AS MinAverageSalary

FROM [Employees] AS e 
GROUP BY e.[DepartmentID]
ORDER BY MinAverageSalary



    
     
 


         
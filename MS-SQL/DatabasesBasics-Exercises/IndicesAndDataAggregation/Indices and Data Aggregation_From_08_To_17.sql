
-- 08. Deposit Charge
SELECT [DepositGroup],
       [MagicWandCreator],
       MIN([DepositCharge]) AS [MinDepositCharge]
FROM [WizzardDeposits]
GROUP BY [DepositGroup],[MagicWandCreator]
ORDER BY [MagicWandCreator],
         [DepositGroup]

-- 09. Age Groups
SELECT [AgeGroup],
       COUNT([Id]) AS [WizardCount]
	   FROM
(SELECT *, 
CASE
WHEN [Age] BETWEEN 0 AND 10 THEN '[0-10]'
WHEN [Age] BETWEEN 11 AND 20 THEN '[11-20]'
WHEN [Age] BETWEEN 21 AND 30 THEN '[21-30]'
WHEN [Age] BETWEEN 31 AND 40 THEN '[31-40]'
WHEN [Age] BETWEEN 41 AND 50 THEN '[41-50]'
WHEN [Age] BETWEEN 51 AND 60 THEN '[51-60]'
WHEN [Age] > 60 THEN '[61+]'
END AS [AgeGroup]

FROM [WizzardDeposits] )
AS [AgeGroupingquery]

GROUP BY [AgeGroup]

-- 10. First Letter
SELECT [FirstLetter]
FROM (SELECT SUBSTRING([FirstName],1,1) AS [FirstLetter]

FROM [WizzardDeposits]
WHERE [DepositGroup] = 'Troll Chest')
AS AllFirstLetters
GROUP BY [FirstLetter]

-- 11. Average Interest
SELECT [DepositGroup],
       [IsDepositExpired],
	   AVG([DepositInterest]) AS [Average interest]
FROM [WizzardDeposits]
WHERE [DepositStartDate] > '1985-01-01'

GROUP BY [DepositGroup],[IsDepositExpired]
ORDER BY [DepositGroup]DESC,
         [IsDepositExpired]

-- 12. Rich Wizard, Poor Wizard
SELECT SUM([Difference]) AS [SumDifference]
FROM(SELECT [FirstName] AS [Host Wizard],
       [DepositAmount] AS [Host Wizard Deposit],
	   LEAD([FirstName]) OVER(ORDER BY [Id]) AS [Guest Wizard],
	   LEAD ([DepositAmount]) OVER (ORDER BY [Id]) AS [Guest Wizard Deposit],
	   [DepositAmount] - LEAD ([DepositAmount]) OVER (ORDER BY [Id]) AS [Difference] 
FROM [WizzardDeposits]
) AS [SumSubquery]
-- 13. Departments Total Salaries
 SELECT [DepartmentID],
        SUM([Salary]) AS TotalSalary
 FROM [Employees]
 GROUP BY [DepartmentID]
 ORDER BY [DepartmentID]

 -- 14. Employees Minimum Salaries
 SELECT [DepartmentID],
        MIN([Salary]) AS MinimumSalary
 FROM [Employees]
 WHERE [HireDate] > '2000-01-01'
 GROUP BY [DepartmentID]
 HAVING [DepartmentID] IN (2,5,7)

 -- 15. Employees Average Salaries
 SELECT *
 INTO [EmployeesWitnBigSalaries]
 FROM [Employees]
 WHERE [Salary] > 30000

 DELETE FROM [EmployeesWitnBigSalaries]
 WHERE [ManagerID] = 42

 UPDATE
  [EmployeesWitnBigSalaries]
  SET  [Salary] = [Salary] + 5000
  WHERE [DepartmentID] = 1

  SELECT [DepartmentID],
  AVG([Salary]) AS [AverageSalary]
  FROM [EmployeesWitnBigSalaries]
  GROUP BY [DepartmentID]

  -- 16. Employees Maximum Salaries
  SELECT [DepartmentID],
         MAX([Salary]) AS [MaxSalary]
  FROM [Employees]
  GROUP BY [DepartmentID]
  HAVING MAX([Salary]) NOT BETWEEN 30000 AND 70000

  -- 17. Employees Count Salaries
  SELECT  COUNT([EmployeeID]) AS [Count]
  FROM [Employees]
  WHERE [ManagerID] IS NULL
  

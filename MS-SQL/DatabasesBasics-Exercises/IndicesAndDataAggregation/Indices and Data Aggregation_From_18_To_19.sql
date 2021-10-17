
  -- 18. 3rd Highest Salary
  SELECT DISTINCT [DepartmentID],
               [Salary] AS [ThirdHighestSalary]
        
  FROM(
  SELECT  
  [DepartmentID],
  [Salary],
  DENSE_RANK() OVER(PARTITION BY [DepartmentID]
                      ORDER BY [Salary]DESC) AS [RankingSalary] 
  FROM [Employees]
  ) AS [SalaryRankingQuery]
  WHERE [RankingSalary] = 3

  -- 19. Salary Challenge

  SELECT TOP(10) e.[FirstName],
         e.[LastName],
		 e.[DepartmentID]
  FROM [Employees] AS e
  WHERE [Salary] >
  (SELECT AVG(esub.[Salary]) AS [DepartmentAvgSalary]
  FROM [Employees] AS esub
  WHERE esub.[DepartmentID] = e.[DepartmentID]
  GROUP BY esub.[DepartmentID]
  ) 
  ORDER BY e.[DepartmentID]


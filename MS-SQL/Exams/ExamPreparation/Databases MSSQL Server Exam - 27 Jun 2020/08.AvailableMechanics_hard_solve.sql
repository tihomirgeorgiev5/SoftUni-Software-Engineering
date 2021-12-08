SELECT CONCAT([FirstName], ' ', [LastName]) AS [Available]
FROM(
SELECT m1.[MechanicId], [FirstName],[LastName],
      (SELECT COUNT(*) FROM [Mechanics] AS m
       LEFT JOIN [Jobs] AS j
       ON m.[MechanicId] = j.[MechanicId]
       WHERE m.[MechanicId] = m1.[MechanicId]
	   ) AS [All jobs Count],
      ( SELECT COUNT(*) FROM [Mechanics] AS m
       LEFT JOIN [Jobs] AS j
       ON m.[MechanicId] = j.[MechanicId]
       WHERE m.[MechanicId] = m1.[MechanicId] AND (j.[Status] = 'Finished' OR j.[Status] IS NULL)
) AS [Finished Jobs Count]
FROM [Mechanics] AS m1
LEFT JOIN [Jobs] AS j
ON m1.[MechanicId] = j.[MechanicId]
) AS [JobsCountSubQuery]
WHERE [All jobs Count] = [Finished Jobs Count]
GROUP BY [FirstName], [LastName], [MechanicId]
ORDER BY [MechanicId]
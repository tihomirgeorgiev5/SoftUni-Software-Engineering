--HOW TO START WITH A FRESH DATASET
 --1. Delete database
 --2. Create database
 --3. Create tables
 --4.Run dataset(insert data)

 SELECT CONCAT (m.[FirstName], ' ' , m.[LastName]) AS [Mechanic],
                j.[Status],
				j.[IssueDate] FROM [Mechanics] AS m
 JOIN [Jobs] AS j
 ON m.[MechanicId]=j.[MechanicId]
 ORDER BY m.[MechanicId],j.[IssueDate],j.[JobId]
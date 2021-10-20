-- 03. Town Names Starting With
CREATE PROCEDURE usp_GetTownsStartingWith (@someString NVARCHAR(50)) 
AS
BEGIN
DECLARE @countOfSymbol INT = LEN(@someString)
SELECT [Name] 
FROM [Towns]
WHERE SUBSTRING(LOWER([Name]),1,@countOfSymbol) = @someString

END

--EXEC usp_GetTownsStartingWith @someString = 'be'
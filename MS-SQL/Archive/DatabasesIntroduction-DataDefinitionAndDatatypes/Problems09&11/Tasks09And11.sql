
-- 09.Change Primary Key 
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC07611991AB

ALTER TABLE Users
ADD CONSTRAINT PK_CompositeIdUserName
PRIMARY KEY(Id, Username)

-- 10.Add Check Constraint
--to ensure that
-- the values in the Password field
--are at least 5 symbols long


-- 11.Set Default Value of a Field

ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime
DEFAULT GETDATE() FOR LastLoginTime

INSERT INTO Users
(Username, [Password], ProfilePicture, IsDeleted)
VALUES
('Testtttttt', '123', NULL, 1)

SELECT * FROM Users




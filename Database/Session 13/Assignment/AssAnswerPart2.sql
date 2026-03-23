-- ==================== DCL ====================

--Question 01 : 
----------------
--Write the SQL commands to: 
-- a) Disable the trigger trg_Posts_LogInsert 
-- b) Enable the trigger trg_Posts_LogInsert 
-- c) Check if the trigger is disabled or enabled 

DISABLE TRIGGER trg_Posts_LogInsert
ON Posts;

ENABLE TRIGGER trg_Posts_LogInsert
ON Posts;


SELECT name, is_disabled
FROM sys.triggers
WHERE name = 'trg_Posts_LogInsert';


--Question 02 : 
----------------
--Create a SQL login, database user, and grant them SELECT 
--permission on the Users table only. 

CREATE LOGIN TestUser1 WITH PASSWORD = 'SecurePass123!';

CREATE USER TestUser1 FOR LOGIN TestUser1;
CREATE ROLE db_readonly;
GRANT SELECT ON Users TO db_readonly;
ALTER ROLE db_readonly ADD MEMBER TestUser1;


--Question 03 : 
----------------
--Create a database role called "DataAnalysts" and grant it: 
-- - SELECT permission on all tables 
-- - EXECUTE permission on all stored procedures 
-- - Then add a user to this role. 

CREATE ROLE DataAnalysts;
GRANT SELECT ON SCHEMA::dbo TO DataAnalysts;
GRANT EXECUTE TO DataAnalysts;
ALTER ROLE DataAnalysts ADD MEMBER TestUser1;



--Question 04 : 
----------------
--Write SQL to REVOKE INSERT and UPDATE permissions from a role 
-- called "DataEntry" on the Posts table.

CREATE ROLE DataEntry;
GRANT INSERT, UPDATE ON Posts TO DataEntry;
GRANT INSERT, UPDATE ON Comments TO DataEntry;
REVOKE INSERT, UPDATE ON Posts FROM DataEntry;



--Question 05 :
----------------
--Write SQL to DENY DELETE permission on the Users table to a 
--specific user, even if they have it through a role. 
--Explain why DENY is used instead of REVOKE 

DENY DELETE ON Users TO TestUser1;
--#REVOKE: Removes a granted permission - User may still have access through role membership
--#DENY: Blocks permission completely - Overrides ALL grants, even from roles!


--Question 06 : 
----------------
--Create a comprehensive audit trigger that tracks all changes 
--to the Comments table, storing: 
-- Operation type (INSERT/UPDATE/DELETE) 
-- Before and after values for UPDATE - Timestamp and user who made the change 
SELECT TOP 1* FROM AuditLog;

GO
CREATE OR ALTER TRIGGER Trg_Comments_AfterIUD
ON Comments 
AFTER INSERT, UPDATE, DELETE
AS 
BEGIN
	SET NOCOUNT ON;


	DECLARE @InsertedRows INT;
	DECLARE @DeletedRows INT;

	SELECT @InsertedRows = COUNT(*) FROM INSERTED;
	SELECT @DeletedRows = COUNT(*) FROM DELETED;

	--Insert
	IF @InsertedRows > @DeletedRows
	BEGIN
		INSERT INTO AuditLog(TableName, ActionType, UserId, Details)
		SELECT 'Comments', 'Insert', I.UserId, 'New Comment Created By: ' + U.DisplayName
		FROM inserted I INNER JOIN Users U On U.Id = I.UserId

		PRINT 'Comments Insert logged';
	END

	--Delete
	IF @InsertedRows < @DeletedRows
	BEGIN
		INSERT INTO AuditLog(TableName, ActionType, UserId, Details)
		SELECT 'Comments', 'Delete', I.UserId, 'Delete Comment By: ' + U.DisplayName
		FROM inserted I INNER JOIN Users U On U.Id = I.UserId

		PRINT 'Comments Delete logged';
	END

	IF UPDATE(Score)
	BEGIN
		INSERT INTO AuditLog(TableName, ActionType, UserId, OldValue, NewValue, Details)
		SELECT 'Comments', 'Update', I.UserId, D.Score, I.Score, 
		'Score Changed From ' + CAST(D.Score AS NVARCHAR) + ' To ' + CAST(I.Score AS nvarchar)
		FROM inserted I INNER JOIN deleted D On D.Id = I.Id

		PRINT 'Comments update logged';
	END

END


--Question 07 : 
 -----------------
--Write a query to view all triggers in the database along with: 
-- their status (enabled/disabled), type (AFTER/INSTEAD OF), and 
-- the tables they're attached to. 

SELECT 
	name,
	CASE 
		WHEN is_disabled = 0 THEN 'Enabled'
		WHEN is_disabled = 1 THEN 'Disabled'
		END AS Status, 
	CASE
		WHEN is_instead_of_trigger = 1 THEN 'INSTEAD OF'
		WHEN is_instead_of_trigger = 0 THEN 'AFTER'
	END AS Type,
	CASE
		WHEN name Like '%Users%' THEN 'Users'
		WHEN name Like '%Posts%' THEN 'Posts'
		WHEN name Like '%Comments%' THEN 'Comments'
		WHEN name Like '%Badges%' THEN 'Badges'
	END AS AttachedTable
FROM sys.triggers



--Question 08 :
----------------
--Write a query to view all permissions granted to a specific role 
--or user, including the object name, permission type, and state. 

SELECT  
    pr.name AS PrincipalName,        
    pr.type_desc AS PrincipalType,   
    pe.permission_name AS PermissionType,
    pe.state_desc AS PermissionState, 
    OBJECT_NAME(pe.major_id) AS ObjectName
FROM sys.database_permissions pe
JOIN sys.database_principals pr
    ON pe.grantee_principal_id = pr.principal_id


--QUESTION 1 
-------------
--Create an AFTER INSERT trigger on the Posts table that logs every new post creation into a 
--ChangeLog table. 
--The log should include: 
	--● Table name 
	--● Action type 
	--● User ID of the post owner 
	--● Post title stored as new data 

Create Table AuditLog
(
	AuditId INT PRIMARY KEY IDENTITY,
	TableName NVARCHAR(100),
	ActionType NVARCHAR(100),
	UserId INT,
	PostTitle NVARCHAR(MAX),
	ChangeDate DATETIME DEFAULT GETDATE(),
    OldValue NVARCHAR(MAX),
    NewValue NVARCHAR(MAX),
	Details NVARCHAR(500)
)


GO
CREATE OR ALTER TRIGGER Trg_Posts_AfterInsert
ON Posts 
AFTER INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO AuditLog(TableName, ActionType, UserId, PostTitle)
	SELECT 'Posts', 'Insert', i.OwnerUserId, i.Title
	FROM inserted I;

	PRINT 'Post Creation Logged';
END

GO

INSERT INTO Posts (Body, CreationDate, LastActivityDate, PostTypeId, Score, ViewCount, Title, OwnerUserId)
VALUES ('Test post body', GETDATE(), GETDATE(), 1, 0, 0, 'Test Post Title', 1);

Select *
From AuditLog

--QUESTION 2 
--------------
--Create an AFTER UPDATE trigger on the Users table that tracks changes to the Reputation 
--column. 
--The trigger should: 
	--● Log changes only when the reputation value actually changes 
	--● Store both the old and new reputation values in the ChangeLog table

GO
CREATE OR ALTER TRIGGER Tgr_Users_AfterUpdate
ON Users
AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;

	IF UPDATE(Reputation)
	BEGIN 
		INSERT INTO AuditLog(TableName, ActionType, UserId, OldValue, NewValue, Details)
		SELECT 'Users', 'Update', I.Id, CAST(D.Reputation AS nvarchar), CAST(I.Reputation AS NVARCHAR), 
		'Reputation Changed From ' + CAST(D.Reputation AS nvarchar) + ' To ' + CAST(I.Reputation AS nvarchar)
		FROM inserted I JOIN deleted D On I.Id = D.Id
		WHERE I.Reputation != D.Reputation;
	END

	PRINT 'User Update Logged';
END
GO


UPDATE Users
SET Reputation += 100
WHERE Id = 100

SELECT *
FROM AuditLog


--QUESTION 3 
-------------
--Create an AFTER DELETE trigger on the Posts table that archives deleted posts into a 
--DeletedPosts table. 
--All relevant post information should be stored before the post is removed.

GO
CREATE OR ALTER TRIGGER Trg_Posts_AfterDelete
ON Posts
AFTER DELETE
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO AuditLog(TableName, ActionType, UserId, PostTitle, Details)
	SELECT 'Posts', 'Delete', D.OwnerUserId, CAST(D.Title AS NVARCHAR(200)), 'Post Deleted : ' + ISNULL(CAST(d.Title AS NVARCHAR(200)), 'No title')
    FROM deleted d;

	PRINT 'Post Deletion Logged';
END;

DELETE FROM Posts
WHERE Id = 172799


SELECT * FROM AuditLog



--QUESTION 4 
-------------
--Create an INSTEAD OF INSERT trigger on a view named vw_NewUsers (based on the Users table). 
--The trigger should: 
	--● Validate incoming data 
	--● Prevent insertion if the DisplayName is NULL or empty
	

GO
Create Or Alter View vw_NewUsers(UserId, DisplayName, UserReputation, Location, CreationDate)
As
  Select Id, DisplayName , Reputation, Location , CreationDate 
  From Users;
GO


CREATE OR ALTER TRIGGER Trg_vw_NewUsers_InsteadOfInsert
ON vw_NewUsers
INSTEAD OF INSERT
AS 
BEGIN
	SET NOCOUNT ON;
    
    -- Validate Data Before Actual Insert
    IF EXISTS (SELECT 1 FROM inserted WHERE DisplayName IS NULL OR DisplayName = '')
    BEGIN
		ROLLBACK;
		INSERT INTO AuditLog(TableName, ActionType, UserId, Details)
		SELECT 'Users', 'Insert', I.UserId,
		'Attempt to Insert User with null or empty name'
		FROM inserted I

        RAISERROR('Cannot insert User with Null Or Empty Name', 16, 1);
        RETURN;
    END
    
    -- Perform The Actual Insert With Modifications
    INSERT INTO Users(Id, DisplayName, Reputation, Location, CreationDate)
    SELECT UserId, DisplayName, UserReputation, Location, CreationDate
    FROM inserted;
    
    PRINT 'Data validated and inserted';
END


INSERT INTO vw_NewUsers(UserId, DisplayName, UserReputation, Location, CreationDate)
VALUES(1000000, NULL, 100, 'Cairo', GETDATE())

SELECT * FROM AuditLog

--QUESTION 5 
-------------
--Create an INSTEAD OF UPDATE trigger on the Posts table that prevents updates to the Id 
--column. 
--Any attempt to update the Id column should be: 
	--● Blocked 
	--● Logged in the ChangeLog table

GO
CREATE OR ALTER TRIGGER Trg_Posts_InsteadOfUpdate
ON Posts
INSTEAD OF UPDATE
AS 
BEGIN
	SET NOCOUNT ON;

	IF UPDATE(Id)
	BEGIN
		INSERT INTO AuditLog(TableName, ActionType, UserId, PostTitle, OldValue, NewValue, Details)
		SELECT 'Posts', 'Update', D.OwnerUserId, D.Title, CAST(D.Id AS NVARCHAR), CAST(I.Id AS NVARCHAR),
		'Attempt to change Post Id is not allowed'
		FROM inserted I JOIN DELETED D ON D.OwnerUserId = I.OwnerUserId AND D.Title = I.Title

        RAISERROR('Cannot update Id column', 16, 1);
        RETURN;		
	END


	UPDATE P
    SET Title = I.Title, Body = I.Body, Score = I.Score, OwnerUserId = I.OwnerUserId
    FROM Posts P
    JOIN inserted I ON P.Id = I.Id;


	PRINT 'Update controlled and logged';
END


Update Posts
Set Id = 100000
Where id = 6


Select * FROM AuditLog;

--QUESTION 6 
--------------
--Create an INSTEAD OF DELETE trigger on the Comments table that implements a soft delete mechanism. 
--Instead of deleting records: 
	--● Add an IsDeleted flag 
	--● Mark records as deleted 
	--● Log the soft delete operation 

ALTER TABLE Comments ADD IsDeleted BIT DEFAULT 0;

GO
CREATE OR ALTER TRIGGER Trg_Comments_InteadOfDelete
ON Comments
INSTEAD OF DELETE
AS 
BEGIN
	SET NOCOUNT ON;

	UPDATE C
	SET C.IsDeleted = 1
	FROM Comments C JOIN deleted D ON C.Id = D.Id


	INSERT INTO AuditLog(TableName, ActionType, Details)
	SELECT 'Comments', 'Soft Delete', 'Record soft deleted: Id ' + CAST(d.Id AS VARCHAR)
	FROM deleted D;
	

	PRINT 'Soft delete performed';
END

Delete From Comments Where Id = 4

SELECT * FROM Comments




--QUESTION 7 
--------------
--Create a DDL trigger at the database level that prevents any table from being dropped. 
--All drop table attempts should be logged in the ChangeLog table. 

-- Create table to log DDL events
CREATE TABLE DDLAuditLog (
    EventId INT IDENTITY(1,1) PRIMARY KEY,
    EventType VARCHAR(100),
    EventDate DATETIME DEFAULT GETDATE(),
    LoginName VARCHAR(100),
    TSQLCommand NVARCHAR(MAX),
    DatabaseName VARCHAR(100)
);
GO

GO
CREATE OR ALTER TRIGGER trg_PreventTableDrop
ON DATABASE 
FOR DROP_TABLE
AS 
BEGIN
	SET NOCOUNT ON;

	DECLARE @EventData XML = EVENTDATA();
	DECLARE @TableName VARCHAR(100) = @EventData.value('(/EVENT_INSTANCE/ObjectName)[1]', 'VARCHAR(100)');

	ROLLBACK;

	INSERT INTO DDLAuditLog(EventType, LoginName, TSQLCommand, DatabaseName)
	VALUES('DROP_TABLE_PREVENTED', SYSTEM_USER, 'Attempted to drop table: ' + @TableName, DB_NAME());

	PRINT 'Table drop prevented: ' + @TableName;
	
END;

CREATE TABLE TempTest(ID INT);

DROP TABLE TempTest


--QUESTION 8 
-------------
--Create a DDL trigger that logs all CREATE TABLE operations. 
--The trigger should record: 
	--● The action type 
	--● The full SQL command used to create the table 

GO
CREATE OR ALTER TRIGGER Tgr_AuditTableCreation
ON DATABASE 
FOR CREATE_TABLE
AS 
BEGIN
	SET NOCOUNT ON;

	DECLARE @EventData XML = EVENTDATA();

	INSERT INTO DDLAuditLog(EventType, LoginName, TSQLCommand, DatabaseName)
	VALUES ('CREATE_TABLE', SYSTEM_USER, @EventData.value('(/EVENT_INSTANCE/TSQLCommand/CommandText)[1]', 'NVARCHAR(MAX)'),
	DB_NAME());

	PRINT 'Table Creation Logged';
END


CREATE TABLE TestDDL (Id INT, Name VARCHAR(50));
SELECT * FROM DDLAuditLog;
DROP TABLE TestDDL;

--QUESTION 9 
--------------
--Create a DDL trigger that prevents any ALTER TABLE statement that attempts to drop a 
--column. 
--All blocked attempts should be logged. 

GO
CREATE OR ALTER TRIGGER Trg_PreventDropColumn
ON DATABASE 
FOR ALTER_TABLE
AS 
BEGIN
	SET NOCOUNT ON;

	DECLARE @EventData XML = EVENTDATA();
	DECLARE @Command NVARCHAR(MAX) = @EventData.value('(/EVENT_INSTANCE/TSQLCommand/CommandText)[1]', 'NVARCHAR(MAX)');

	IF @Command LIKE '%DROP COLUMN%'
	BEGIN
		ROLLBACK;
		INSERT INTO DDLAuditLog(EventType, LoginName, TSQLCommand, DatabaseName)
		VALUES('DROP_COLUMN_PREVENTED', SYSTEM_USER, 'Attempted DROP COLUMN command blocked: ' + @Command, DB_NAME());

		PRINT 'Drop Column Prevented';
		
	END
END;
GO

ALTER TABLE TestDDL
DROP COLUMN NAME

SELECT *
FROM DDLAuditLog

--QUESTION 10 
--------------
--Create a single trigger on the Badges table that tracks INSERT, UPDATE, and DELETE 
--operations. 
--The trigger should: 
	--● Detect the operation type using INSERTED and DELETED tables 
	--● Log the action appropriately in the ChangeLog table

GO
CREATE OR ALTER TRIGGER Trg_Badges_AuditChanges
ON Badges
AFTER INSERT, UPDATE, DELETE
AS 
BEGIN
	SET NOCOUNT ON;

	DECLARE @InsertedCount INT;
	DECLARE @DeletedCount INT;

	SELECT @InsertedCount = COUNT(*) 
	FROM inserted;

	SELECT @DeletedCount = COUNT(*) 
	FROM deleted;

	--INSERT
	IF @InsertedCount > 0 And @DeletedCount = 0
	BEGIN
		INSERT INTO AuditLog(TableName, ActionType, UserId, Details)
		SELECT 'Badges', 'Insert', i.UserId, 'New Badge created with Name: ' + CAST(i.Name AS VARCHAR(200))
		FROM inserted I;

		PRINT 'Badge Creation Logged';
	END

	--DELETE
	IF @InsertedCount = 0 And @DeletedCount > 0
	BEGIN
		INSERT INTO AuditLog(TableName, ActionType, UserId, Details)
		SELECT 'Badges', 'Delete', D.UserId, 'Badge Deleted with Name : ' + CAST(d.Name AS NVARCHAR(200))
		FROM deleted D;

		PRINT 'Badge Deletion Logged';
	END
	

	IF UPDATE(Name)
	BEGIN 
		INSERT INTO AuditLog(TableName, ActionType, UserId, OldValue, NewValue, Details)
		SELECT 'Badges', 'Update', I.UserId, CAST(D.Name AS nvarchar(200)), CAST(I.Name AS NVARCHAR(200)), 
		'Name Changed From ' + CAST(D.Name AS nvarchar(200)) + ' To ' + CAST(I.Name AS nvarchar(200))
		FROM inserted I JOIN deleted D On I.Id = D.Id
		WHERE I.Name != D.Name;
		
		PRINT 'Badge Update Logged';
	END

END





--QUESTION 11 
--------------
--Create a trigger that maintains summary statistics in a PostStatistics table whenever posts are 
--inserted, updated, or deleted. 
--The trigger should update: 
	--● Total number of posts 
	--● Total score 
	--● Average score 
		--for the affected users. 


CREATE TABLE PostStatistics
(
    StatId INT PRIMARY KEY IDENTITY,     
	UserID INT,
    TotalPosts INT DEFAULT 0,              
    TotalScore INT DEFAULT 0,              
    AvgScore FLOAT DEFAULT 0,              
    LastUpdated DATETIME DEFAULT GETDATE() 
);

--I tried to solve this Question11 but I couldn't.




--QUESTION 12 
--------------
--Create an INSTEAD OF DELETE trigger on the Posts table that prevents deletion of posts with 
--a score greater than 100. 
--Any prevented deletion should be logged.

GO
CREATE OR ALTER TRIGGER Trg_Posts_InteadOfDelete
ON Posts
INSTEAD OF DELETE
AS 
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM deleted WHERE Score > 100)
    BEGIN
        ROLLBACK;

        INSERT INTO AuditLog(TableName, ActionType, Details)
        SELECT 'Posts', 'DELETE', 'Failed to delete because score more than 100'
        FROM deleted
        WHERE Score > 100;

        PRINT 'Failed to delete post because Score more than 100';
    END
    ELSE
    BEGIN
        DELETE P
        FROM Posts P INNER JOIN deleted D ON P.ID = D.ID;
    END
END
GO



SELECT Id, Score
FROM Posts
Where ID = 337704

DELETE FROM Posts
WHERE Id = 337704


SELECT *
FROM AuditLog

--QUESTION 13 
--------------
--Write the SQL commands required to: 
	--1. Disable a specific trigger on the Posts table 
	--2. Enable the same trigger again 
	--3. Check whether the trigger is currently enabled or disabled 

DISABLE TRIGGER Trg_Posts_AfterDelete
ON Posts


ENABLE TRIGGER Trg_Posts_AfterDelete
ON Posts

--search
SELECT name, is_disabled
FROM sys.triggers
WHERE name = 'Trg_Posts_AfterDelete';
--QUESTION 1:
---------------
--Create a stored procedure named sp_GetRecentBadges that retrieves all badges earned by 
--users within the last N days. 
-- The procedure should accept one input parameter @DaysBack (INT) to determine how many 
--days back to search. 
-- Test the procedure using different values for the number of days. 

Create Or Alter Procedure sp_GetRecentBadges @DaysBack INT 
As Begin 
	Select id, name, UserId
	From Badges
	Where DATEDIFF(day, date, GETDATE()) <= @DaysBack
End

EXEC sp_GetRecentBadges @DaysBack = 5500


--QUESTION 2 
-------------
--Create a stored procedure named sp_GetUserSummary that retrieves summary statistics for a 
--specific user. 
-- The procedure should accept @UserId as an input parameter and return the following values 
--as output parameters: 
	--● Total number of posts created by the user 
	--● Total number of badges earned by the user 
	--● Average score of the user’s posts 
Go
CREATE OR ALTER PROCEDURE sp_GetUserSummary @UserId INT, @TotalPosts INT Output, 
								@TotalBadges INT Output, @AvgScore Decimal(10, 2) Output
AS BEGIN
	Select @TotalPosts = IsNull(COUNT(*), 0)
	From Posts
	Where OwnerUserId = @UserId;

	Select @TotalBadges = IsNull(COUNT(*), 0)
	From Badges
	Where UserId = @UserId;

	Select @AvgScore = IsNull(AVG(Score), 0)
	From Posts
	Where OwnerUserId = @UserId;


	SET @TotalPosts = ISNULL(@TotalPosts, 0);
    SET @TotalBadges = ISNULL(@TotalBadges, 0);
    SET @AvgScore = ISNULL(@AvgScore, 0);
END;
Go

DECLARE @Posts INT, @Badges INT, @AvgScoreCount Decimal(10, 2);

EXECUTE sp_GetUserSummary @UserId = 1, @TotalPosts = @Posts Output, 
				@TotalBadges = @Badges Output, @AvgScore = @AvgScoreCount Output;

Select @Posts As TotalPosts, @Badges As TotalBadges, @AvgScoreCount As AvgScore;



--QUESTION 3 
-------------
--Create a stored procedure named sp_SearchPosts that searches for posts based on: 
	--● A keyword found in the post title 
	--● A minimum post score 	
--The procedure should accept @Keyword as an input parameter and @MinScore as an 
--optional parameter with a default value of 0. 
--The result should display matching posts ordered by score.

GO
CREATE OR ALTER PROC sp_SearchPosts @Keyword NVARCHAR(MAX), @MinScore INT = 0
AS BEGIN
	SELECT Title, Body, Score
	FROM Posts
	Where LOWER(Title) Like '%' + LOWER(@Keyword) + '%' And Score >= @MinScore
	Order By Score Desc
END;
GO

EXEC sp_SearchPosts @Keyword = 'E', @MinScore = 100




--QUESTION 3 
--------------
--Create a stored procedure named sp_GetUserOrError that retrieves user details by user ID. 
--If the specified user does not exist, the procedure should raise a meaningful error. 
--Use TRY…CATCH for proper error handling.

Go
CREATE OR ALTER PROC sp_GetUserOrError @UserId INT
AS BEGIN
	BEGIN TRY
		IF NOT EXISTS(SELECT 1 FROM Users Where Id = @UserId)
		BEGIN RAISERROR('User with ID %d does not exist', 16, 1, @UserId) With Log;
        RETURN;
		END

		SELECT  Id, DisplayName, Reputation, Location
        FROM Users
        WHERE Id = @UserId;
        
        PRINT 'User retrieved successfully';

	END TRY

	BEGIN CATCH
	SELECT  ERROR_NUMBER() AS ErrorNumber, ERROR_MESSAGE() AS ErrorMessage, ERROR_SEVERITY() AS ErrorSeverity, ERROR_STATE() AS ErrorState, ERROR_LINE() AS ErrorLine;
            
    PRINT 'An error occurred while retrieving user';
	END CATCH
END

EXEC sp_GetUserOrError -2




--QUESTION 4 
-------------
--Create a stored procedure named sp_AnalyzeUserActivity that: 
--● Calculates an Activity Score for a user using the formula: 
--Reputation + (Number of Posts × 10) 
--● Returns the calculated Activity Score as an output parameter 
--● Returns a result set showing the user’s top 5 posts ordered by score

GO 
CREATE OR ALTER PROC sp_AnalyzeUserActivity @UserId INT, @ActivityScore INT Output
AS BEGIN
	DECLARE @Reputation INT = 0, @PostCount INT = 0;

    SELECT @Reputation = Reputation
    FROM Users
    WHERE Id = @UserId;

    SELECT @PostCount = COUNT(*)
    FROM Posts
    WHERE OwnerUserId = @UserId;

    SET @ActivityScore = ISNULL(@Reputation, 0) + (ISNULL(@PostCount, 0) * 10);



	SELECT TOP (5) Id, Title, Score
    FROM Posts
    WHERE OwnerUserId = @UserId
    ORDER BY Score DESC;
END


--QUESTION 5 
-------------
--Create a stored procedure named sp_GetReputationInOut that uses a single input/output 
--parameter. 
--The parameter should initially contain a UserId as input and return the corresponding user 
--reputation as output.

GO
CREATE OR ALTER PROCEDURE sp_GetReputationInOut @UserId_Reputation INT OUTPUT
AS
BEGIN
    DECLARE @UserId INT = @UserId_Reputation;

    SELECT @UserId_Reputation = Reputation
    FROM Users
    WHERE Id = @UserId;

    IF @UserId_Reputation IS NULL
        SET @UserId_Reputation = -1; 
END;
GO




--QUESTION 6 
-------------
--Create a stored procedure named sp_UpdatePostScore that updates the score of a post. 
--The procedure should: 
	--● Accept a post ID and a new score as input 
	--● Validate that the post exists 
	--● Use transactions and TRY…CATCH to ensure safe updates 
	--● Roll back changes if an error occurs 

GO
CREATE OR ALTER PROC sp_UpdatePostScore @PostId INT, @NewScore INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        IF NOT EXISTS (SELECT 1 FROM Posts WHERE Id = @PostId)
        BEGIN
            RAISERROR('Post does not exist', 16, 1);
            RETURN;
        END
        
        UPDATE Posts
        SET Score = @NewScore
        WHERE Id = @PostId;

        COMMIT TRANSACTION;

        SELECT 'Score updated successfully' AS Result, @PostId AS PostId, @NewScore AS UpdatedScore;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT 'Error: ' + ERROR_MESSAGE() AS Result;
    END CATCH
END;
GO




--#QUESTION 7 
-------------
--Create a stored procedure named sp_GetTopUsersByReputation that retrieves the top N 
--users whose reputation is above a specified minimum value. 
--Then create a permanent table named TopUsersArchive and insert the results returned by the 
--procedure into this table.

GO
CREATE OR ALTER PROC sp_GetTopUsersByReputation @Number INT, @MinReputation INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP (@Number)
        Id,
        DisplayName,
        Reputation,
        CreationDate
    FROM Users
    WHERE Reputation > @MinReputation
    ORDER BY Reputation DESC;
END
GO


CREATE TABLE TopUsersArchive
(
    Id INT,
    DisplayName NVARCHAR(255),
    Reputation INT,
    CreationDate DATETIME,
    ArchiveDate DATETIME DEFAULT GETDATE()
);

INSERT INTO TopUsersArchive (Id, DisplayName, Reputation, CreationDate)
EXEC sp_GetTopUsersByReputation 
    @Number = 5,
    @MinReputation = 1000;



--QUESTION 8 
-------------
--Create a stored procedure named sp_InsertUserLog that inserts a new record into a UserLog 
--table. 
--The procedure should: 
	--● Accept user ID, action, and details as input 
	--● Return the newly created log ID using an output parameter 

GO
CREATE OR ALTER PROC sp_InsertUserLog @UserId INT, @Action VARCHAR(100), 
										@Details NVARCHAR(500), @LogId INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO UserLog(UserId, Action, Details)
        VALUES (@UserId, @Action, @Details);

        SET @LogId = SCOPE_IDENTITY();

        COMMIT TRANSACTION;
		SELECT 'Log added successfully' AS Result, @LogId AS NewLogId;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

		SELECT  'Error: ' + ERROR_MESSAGE() AS Result;
        SET @LogId = -1;
    END CATCH
END;
GO




--QUESTION 9 
-------------
--Create a stored procedure named sp_UpdateUserReputation that updates a user’s reputation. 
--The procedure should: 
	--● Validate that the reputation value is not negative 
	--● Validate that the user exists 
	--● Return the number of rows affected 
	--● Handle errors appropriately


GO
CREATE OR ALTER PROC sp_UpdateUserReputation @UserId INT, 
							@NewReputation INT, @RowsAffected INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        IF @NewReputation < 0
        BEGIN
            RAISERROR('Reputation cannot be negative', 16, 1);
            RETURN;
        END

        IF NOT EXISTS (SELECT 1 FROM Users WHERE Id = @UserId)
        BEGIN
            RAISERROR('User does not exist', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        UPDATE Users
        SET Reputation = @NewReputation
        WHERE Id = @UserId;

        SET @RowsAffected = @@ROWCOUNT;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
			SELECT 
            'Error: ' + ERROR_MESSAGE() AS Result;
        SET @RowsAffected = -1;
    END CATCH
END;
GO


--QUESTION 10 
--------------
--Create a stored procedure named sp_DeleteLowScorePosts that deletes all posts with a score 
--less than or equal to a given value. 
--The procedure should: 
	--● Use transactions 
	--● Return the number of deleted records as an output parameter 
	--● Roll back changes if an error occurs 

GO
CREATE OR ALTER PROC sp_DeleteLowScorePosts @MaxScore INT, @DeletedCount INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        DELETE FROM Posts
        WHERE Score <= @MaxScore;

        SET @DeletedCount = @@ROWCOUNT;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
		SELECT 
            'Error: ' + ERROR_MESSAGE() AS Result;
        SET @DeletedCount = -1;
    END CATCH
END;
GO




--QUESTION 11 
--------------
--Create a stored procedure named sp_BulkInsertBadges that inserts multiple badge records for 
--a user. 
--The procedure should: 
	--● Accept a user ID 
	--● Accept a badge count indicating how many badges to insert 
	--● Insert multiple related records in a single operation 

GO
CREATE OR ALTER PROC sp_BulkInsertBadges @UserId INT, @BadgeCount INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @i INT = 1;

        WHILE @i <= @BadgeCount
        BEGIN
            INSERT INTO Badges (UserId, Name, Date)
            VALUES (@UserId, 'New Badge', GETDATE());

            SET @i = @i + 1;
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
    END CATCH
END;
GO




--#QUESTION 12 
----------------
--Create a stored procedure named sp_GenerateUserReport that generates a complete user 
--report. 
--The procedure should: 
	--➢ Call another stored procedure internally to retrieve user statistics 
	--➢ Combine user profile data and statistics 
	--➢ Return a formatted report including a calculated user level 


GO
CREATE OR ALTER PROC sp_GenerateUserReport
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE 
        @TotalPosts INT,
        @TotalBadges INT,
        @AvgScore DECIMAL(10,2);

    EXEC sp_GetUserSummary
        @UserId = @UserId,
        @TotalPosts = @TotalPosts OUTPUT,
        @TotalBadges = @TotalBadges OUTPUT,
        @AvgScore = @AvgScore OUTPUT;

    SELECT 
        U.Id,
        U.DisplayName,
        U.Reputation,
        @TotalPosts AS TotalPosts,
        @TotalBadges AS TotalBadges,
        @AvgScore AS AvgScore,
        CASE
            WHEN U.Reputation >= 5000 THEN 'Elite'
            WHEN U.Reputation >= 1000 THEN 'Advanced'
            WHEN U.Reputation >= 200 THEN 'Intermediate'
            ELSE 'Beginner'
        END AS UserLevel
    FROM Users U
    WHERE U.Id = @UserId;
END
GO

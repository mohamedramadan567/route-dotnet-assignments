--Question 01 :
-----------------
--Retrieve a list of users who meet at least one of these criteria:
--1. Reputation greater than 8000
--2. Created more than 15 posts
--Display UserId, DisplayName, and Reputation.
--Ensure that each user appears only once in the results.
Select Id, DisplayName, Reputation
From Users
Where Reputation > 8000
Union
Select P.OwnerUserId, U.DisplayName, U.Reputation
From Users U Join Posts P On U.Id = P.OwnerUserId
Group By P.OwnerUserId, U.DisplayName, U.Reputation
Having COUNT(P.OwnerUserId) > 15;

--another Solution
SELECT Id, DisplayName, Reputation
FROM Users 
Where Reputation > 8000 OR Id in (	Select 
										OwnerUserId
									From Posts
									Group By OwnerUserId
									Having COUNT(*) > 15);




--Question 02 :
----------------
--Find users who satisfy BOTH of these conditions simultaneously:
--1. Have reputation greater than 3000
--2. Have earned at least 5 badges
--Display UserId, DisplayName, and Reputation.

Select Id, DisplayName, Reputation
From Users
Where Reputation > 3000
INTERSECT
Select U.Id, DisplayName, Reputation
From Users U Join Badges B On U.Id = b.UserId
Group By U.Id, DisplayName, Reputation
Having COUNT(B.Id) >= 5




--Question 03 :
----------------
--Identify posts that have a score greater than 20 but have never 
--received any comments. Display PostId, Title, and Score

Select 
	Id, 
	Title,
	Score
From Posts
Where Score > 20
EXCEPT
Select 
	C.PostId, 
	P.Title,
	P.Score
From Comments C Inner Join Posts P On P.Id = C.PostId
Group By C.PostId, P.Title, P.Score
Having COUNT(C.Id) = 0 
Order By Score 


--Question 04 :
----------------
--Create a new permanent table called Posts_Backup that stores all posts with a score greater than 10.
--The new table should include: Id, Title, Score, ViewCount, CreationDate, OwnerUserId.

Select Id, Title, Score, ViewCount, CreationDate, OwnerUserId
Into Posts_Backup
From Posts
Where Score > 10;


--Question 05 :
----------------
--Create a new table called ActiveUsers containing users who meet the following criteria:
--1.	Reputation greater than 1000
--2.	Have created at least one post
-- The table should include: UserId, DisplayName, Reputation, Location, and PostCount (calculated).

Select 
	U.Id, 
	U.DisplayName, 
	U.Reputation, 
	U.Location, 
	COUNT(P.Id) As PostCount
Into ActiveUsers
From Users U Join Posts P On U.Id = P.OwnerUserId
Group By U.Id, U.DisplayName, U.Reputation, U.Location
Having COUNT(P.Id) >= 1 And U.Reputation > 1000



--Question 06 :
----------------
--Create a new empty table called Comments_Template that has 
--the exact same structure as the Comments table but contains no data rows.
Select *
Into Comments_Template
From Comments
Where 10 = 0;


--Question 07 :
----------------
--Create a summary table called PostEngagementSummary that 
--combines data from Posts, Users, and Comments tables.
--The table should include:  PostId, Title, AuthorName, Score, ViewCount 
--CommentCount (calculated), TotalCommentScore (calculated)
--Include only posts that have received at least 3 comments.

Select 
	P.Id As PostId,
	P.Title, 
	U.DisplayName As AuthorName,
	P.Score,
	P.ViewCount,
	COUNT(C.Id) As CommentCount, 
	SUM(C.Score) As TotalCommentScore
Into PostEngagementSummary
From Posts P Join Users U On U.Id = P.OwnerUserId
			 Join Comments C On P.Id = C.PostId
Group By P.Id, P.Title, U.DisplayName, P.Score, P.ViewCount
Having COUNT(C.Id) > 3




--Question 08 :
----------------
--Develop a reusable calculation that determines the age of a post in days based on its creation date.
--Input: CreationDate (DATETIME)
--Output: Age in days (INTEGER)
--Test your solution by displaying posts with their calculated ages.
GO
CREATE OR ALTER FUNCTION dbo.CalaculateAgeOfPost(@CreationDate DATETIME)
RETURNS INTEGER
AS 
BEGIN 
	RETURN DATEDIFF(Day, @CreationDate, GETDATE())
END;
GO

--Test
Select Id, Title, Score, dbo.CalaculateAgeOfPost(CreationDate) As AgeInDays
From Posts


--Question 09 :
--Develop a reusable calculation that assigns a badge level to users based 
--on their reputation and post activity.
--Inputs: Reputation (INT), PostCount (INT)
--Output: Badge level (VARCHAR)
--Logic:
--'Gold' if reputation > 10000 AND posts > 50
--'Silver' if reputation > 5000 AND posts > 20
--'Bronze' if reputation > 1000 AND posts > 5
--'None' otherwise
Go
CREATE OR ALTER FUNCTION dbo.CalculateBadgeLevel(@Reputation INT, @PostCount INT)
RETURNS VARCHAR(15)
AS
BEGIN
	DECLARE @BadgeLevel VARCHAR(15);
	
	IF @Reputation > 10000 And @PostCount > 50
		SET @BadgeLevel = 'Gold';
	ELSE IF @Reputation > 5000 AND @PostCount > 20
		SET @BadgeLevel = 'Silver';
	ELSE IF @Reputation > 1000 AND @PostCount > 5
		SET @BadgeLevel = 'Bronze';
	ELSE 
		SET @BadgeLevel = 'None';

	RETURN @BadgeLevel;
END;
GO

--Test
Select 
	U.DisplayName, 
	U.Reputation, 
	COUNT(P.Id) AS PostCount,
	dbo.CalculateBadgeLevel(U.Reputation, COUNT(P.Id)) As BadgeLevel
From Users U Join Posts P On U.Id = P.OwnerUserId
Group By U.DisplayName, U.Reputation



--Question 10 :
----------------
--Develop a reusable query that retrieves posts created within a specified 
--number of days from today.
--Input: @DaysBack (INT) - number of days to look back
--Output: Table with PostId, Title, Score, ViewCount, CreationDate
--Test with different day ranges (e.g., 30 days, 90 days).
GO
CREATE OR ALTER FUNCTION dbo.GetPostsFromDaysAgo(@DaysBack INT)
RETURNS TABLE 
AS 
RETURN
(
	SELECT 
		Id,
		Title,
		Score,
		ViewCount,
		CreationDate
	FROM Posts
	WHERE DATEDIFF(Day, CreationDate, GETDATE()) <= @DaysBack
);
GO

--Test
Select *
FROM dbo.GetPostsFromDaysAgo(6000);




-------------------------NoT Completed-------------------------------
--Question 11 :
----------------
--Develop a reusable query that finds top users from a specific location or 
--all locations based on reputation threshold.
--Inputs: @MinReputation (INT), @Location (VARCHAR)
--Output: Table with UserId, DisplayName, Reputation, Location, CreationDate
--If @Location is NULL, return users from all locations.
--Test with different parameters.
GO
CREATE OR ALTER FUNCTION dbo.GetUsersBasedOnLocationAndMinReputation(@MinReputation INT, @Location NVARCHAR(100))
RETURNS Table
AS 
RETURN
(
	SELECT 
		Id, 
		DisplayName, 
		Reputation,
		Location,
		CreationDate
	FROM Users	
	WHERE Reputation >= @MinReputation  
									AND(@Location IS NULL OR Location = @Location)
);
GO

--Test
Select *
From dbo.GetUsersBasedOnLocationAndMinReputation(1000, 'El Cerrito, CA')





--Question 12 :
----------------
--Write a query to find the top 3 highest scoring posts for each PostTypeId.
--Use a subquery or CTE with ROW_NUMBER() and PARTITION BY.
--Display PostTypeId, Title, Score, and the rank.
WITH GetRank As (
	SELECT
		PostTypeId,
		Title,
		Score,
		ROW_NUMBER() OVER (PARTITION BY PostTypeId Order By Score DESC) As Rn
	FROM Posts
)
Select *
From GetRank
Where Rn <= 3
Order By PostTypeId


--Question 13 :
----------------
--Write a query using a CTE to find all users whose reputation is above the average reputation. The CTE should calculate 
--1.	the average reputation first.
--2.	Display DisplayName, Reputation, and the average reputation.
WITH GetAvg As
(	
	SELECT AVG(Reputation) As RepAvg
	FROM Users
)
SELECT U.DisplayName, U.Reputation, GA.RepAvg
FROM Users U Cross Join GetAvg GA 
Where U.Reputation > GA.RepAvg





--Question 14 :
-----------------
--Write a query using a CTE to calculate the total number of posts and 
--average score for each user. Then join with the Users table to display: 
--DisplayName, Reputation, TotalPosts, and AvgScore.
--Only include users with more than 5 posts.

WITH UsersDetails AS
(
	SELECT 
		OwnerUserId,
		COUNT(Id) AS TotalPosts,
		AVG(Score) As AvgScore
	FROM Posts
	Group By OwnerUserId
)
SELECT 
	U.DisplayName,
	U.Reputation,
	UD.TotalPosts,
	UD.AvgScore
FROM Users U Join UsersDetails UD On U.Id = UD.OwnerUserId
WHERE UD.TotalPosts > 5;



--Question 15 :
----------------
--Write a query using multiple CTEs:
--First CTE: Calculate post count per user
--Second CTE: Calculate badge count per user
--Then join both CTEs with Users table to show:
--DisplayName, Reputation, PostCount, and BadgeCount.
--Handle NULL values by replacing them with 0.

WITH UserPosts AS
(
	SELECT OwnerUserId, COUNT(*) As TotalPosts
	FROM Posts
	GROUP BY OwnerUserId
),
UserBadges As (
	SELECT UserId, COUNT(*) AS TotalBadges
	FROM Badges
	GROUP BY UserId
)
SELECT U.DisplayName, U.Reputation, UP.TotalPosts, UB.TotalBadges
FROM Users U Join UserPosts UP On U.Id = UP.OwnerUserId
			 Join UserBadges UB On U.Id = UB.UserId


--Question 16 :
----------------
--Write a recursive CTE to generate a sequence of numbers from 1 to 20. 
--Display the generated numbers.
WITH PrintFrom1To20 AS
(
	SELECT 1 AS Number 
	UNION ALL
	SELECT Number + 1 
	From PrintFrom1To20
	Where Number < 20
)
Select Number
From PrintFrom1To20

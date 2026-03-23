-- QUESTION 1 :
----------------
-- Create a view that displays basic user information including 
-- their display name, reputation, location, and account creation date. 
-- Name the view: vw_BasicUserInfo 
-- Test the view by selecting all records from it.

Go
Create Or Alter View vw_BasicUserInfo
As 
Select DisplayName, Reputation, Location, CreationDate
From Users
Go

Select *
From vw_BasicUserInfo



--Question 02 : 
---------------
--Create a view that shows all posts with their titles, scores, 
-- view counts, and creation dates where the score is greater than 10. 
-- Name the view: vw_HighScoringPosts 
-- Test by querying posts from this view. 

Go 
Create Or Alter View vw_HighScoringPosts
As
Select Title, Score, ViewCount, CreationDate
From Posts
Where Score > 10
Go

Select *
From vw_HighScoringPosts



--Question 03 : 
----------------
--Create a view that combines data from Users and Posts tables. 
-- Show the post title, post score, author name, and author reputation. 
-- Name the view: vw_PostsWithAuthors 
-- This is a complex view involving joins.

Go
Create Or Alter View vw_PostsWithAuthors
As
Select 
	P.Title, 
	P.Score, 
	U.DisplayName As AutherName,
	U.Reputation As AuthorRep
From Users U Join Posts P On U.Id = P.OwnerUserId
Go


Select *
From vw_PostsWithAuthors




--Question 04 : 
---------------
--Create a view that aggregates comment statistics per post. 
-- Include: PostId, total comment count, sum of comment scores, 
-- and average comment score. 
-- Name the view: vw_PostCommentStats 
-- This is a complex view with aggregation. 

Go
Create Or Alter View vw_PostCommentStats
As 
Select 
	P.Id As PostId,
	COUNT(C.Id) As TotalComments, 
	SUM(C.Score) As TotalScores,
	AVG(C.Score * 0.1) As TotalAvgScores
From Posts P Join Comments C On C.PostId = P.Id
Group By P.Id
Go

Select *
From vw_PostCommentStats




--Question 05 : 
----------------
-- Create an indexed view that shows user activity summaries. 
-- Include: UserId, DisplayName, Reputation, total posts count. 
-- Name the view: vw_UserActivityIndexed 
-- Make it an indexed view with a unique clustered index on UserId 

Go
Create Or Alter View vw_UserActivityIndexed
WITH SCHEMABINDING
As 
Select 
	U.Id As UserId, 
	U.DisplayName As UserName, 
	U.Reputation,
	COUNT_BIG(*) As TotalPosts
From dbo.Users U Join dbo.Posts P On P.OwnerUserId = U.Id
Group By U.Id, DisplayName, Reputation
GO

Go
Create UNIQUE CLUSTERED INDEX IX_vw_UserActivityIndexed
ON vw_UserActivityIndexed(UserId)
Go

Select *
From vw_UserActivityIndexed



--Question 06 : 
----------------
--Create a partitioned view that combines high reputation users 
-- (reputation > 5000) and low reputation users (reputation <= 5000) 
-- from the same Users table using UNION ALL. 
-- Name the view: vw_UsersPartitioned 

Go
Create Or Alter View vw_UsersPartitioned
As 
Select 
	Id, 
	DisplayName,
	Reputation,
	Location
From Users
Where Reputation > 5000
Union All
Select 
	Id, 
	DisplayName,
	Reputation,
	Location
From Users
Where Reputation <= 5000
Go

Select *
From vw_UsersPartitioned



--Question 07 : 
-----------------
--Create an updatable view on the Users table that shows 
-- UserId, DisplayName, and Location. 
-- Test the view by updating a user's location through the view. 
-- Name the view: vw_EditableUser

Go
Create Or Alter View vw_EditableUser
As 
Select 
	Id, 
	DisplayName,
	Location
From Users
Go

--Test
Update vw_EditableUser
Set Location = 'Charlotte, NC, United States'
Where Id = 40

Select *
From vw_EditableUser
Where Id = 40




--Question 08 : 
---------------
-- Create a view with CHECK OPTION that only shows posts with 
-- score greater than or equal to 20. 
-- Name the view: vw_QualityPosts 
-- Ensure that any updates through this view maintain the score >= 20 condition . 

Go
Create Or Alter View vw_QualityPosts
As
Select 
	Id, 
	Title,
	Body,
	Score,
	CreationDate
From Posts 
Where Score >= 20
With Check Option


Update vw_QualityPosts
Set Score = 10
Where Id = 4


--Question 09 : 
----------------
-- Create a complex view that shows comprehensive post information 
-- including post details, author information, and comment count. 
-- Include: PostId, Title, Score, AuthorName, AuthorReputation, CommentCount. 

Go
Create Or Alter View vw_PostFullInfo
As 
Select 
	P.Id As PostId,
	P.Title,
	P.Score, 
	U.DisplayName As AuthorName,
	U.Reputation As AuthorReputation,
	P.CommentCount
From Users U join Posts P On P.OwnerUserId = U.Id
Go

Select * From vw_PostFullInfo

--Question 10 : 
----------------
--Create a view that shows badge statistics per user. 
-- Include: UserId, DisplayName, Reputation, total badge count, 
-- and a list of unique badge names (comma-separated if possible, 
-- or just the count for simplicity). 
-- Name the view: vw_UserBadgeStats . 

Go
Create Or Alter View vw_UserBadgeStats
As
Select 
	U.Id As UserId, 
	U.DisplayName,
	U.Reputation,
	COUNT_BIG(*) As TotalBadges
From Users U Join Badges B On B.UserId = U.Id
Group By U.Id, U.DisplayName, U.Reputation
Go

Select * From vw_UserBadgeStats

--Question 11 : 
----------------
--Create a view that shows only active users (those who have 
-- posted in the last 365 days from today, or have a reputation > 1000). 
-- Include: UserId, DisplayName, Reputation, LastActivityDate 
-- Name the view: vw_ActiveUsers.

Go
Create Or Alter View vw_ActiveUsers
As
Select 
	U.Id As UserId,
	U.DisplayName,
	U.Reputation,
	P.LastActivityDate
From Users U Join Posts P On P.OwnerUserId = U.Id
Where (P.LastActivityDate - GETDATE() <= 365) Or U.Reputation > 1000
Go

Select *
From vw_ActiveUsers



--Question 12 : 
----------------
-- Create an indexed view that calculates total views and average 
-- score per user from their posts. 
-- Include: UserId, TotalPosts, TotalViews, AvgScore 
-- Name the view: vw_UserPostMetrics 
-- Create a unique clustered index on UserId. 

Go
Create Or Alter View vw_UserPostMetrics
WITH SCHEMABINDING 
As 
Select 
	U.Id As UserId,
	COUNT_BIG(*) As TotalPosts,
	SUM(P.Score) As TotalScore,
	SUM(P.ViewCount) As TotalViews
From dbo.Users U Join dbo.Posts P On U.Id = P.OwnerUserId
Group By U.Id
Go

Create UNIQUE CLUSTERED INDEX IX_vw_UserPostMetrics
ON vw_UserPostMetrics(UserId)


SELECT 
    UserId,
    TotalPosts,
    TotalViews,
    TotalScore * 1.0 / TotalPosts AS AvgScore
FROM vw_UserPostMetrics;

	
--Question 13 : 
---------------
--Create a view that categorizes posts based on their score ranges. 
-- Categories: 'Excellent' (>= 100), 'Good' (50-99), 'Average' (10-49), 'Low' (< 10) 
-- Include: PostId, Title, Score, Category 
-- Name the view: vw_PostsByCategory

GO
CREATE OR ALTER VIEW vw_PostsByCategory
AS
	SELECT 
		Id, 
		Title, 
		Score, 
		CASE 
			WHEN Score >= 100 THEN 'Excellent'
			WHEN Score BETWEEN 50 AND 99 THEN 'Good' 
			WHEN Score BETWEEN 10 AND 49 THEN 'Average'
			WHEN Score < 10 THEN 'Low'
			ELSE 'No Category'
		END AS Category
	FROM Posts
GO
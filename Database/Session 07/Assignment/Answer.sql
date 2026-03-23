USE StackOverflow2010;

--Question 01:
-----------------
--●	Write a query to display all user display names in uppercase 
--along with the length of their display name.

SELECT
	UPPER(DisplayName) As UpperName,
	LEN(DisplayName) As Length
From Users

--Question 02:
-------------------
--●	Write a query to show all posts with their titles and calculate 
--how many days have passed since each post was created.
--Use DATEDIFF to calculate the difference from CreationDate to today.

SELECT	
	Title, 
	DATEDIFF(DAY, CreationDate, GETDATE()) AS NumOfDays
FROM Posts



--Question 03 :
----------------
--●	Write a query to count the total number of posts for each user.
--Display the OwnerUserId and the count of their posts.
--Only include users who have created posts.

SELECT 
	OwnerUserId, 
	COUNT(Id) AS NumOfPosts
FROM Posts
GROUP BY OwnerUserId
HAVING COUNT(Id) >= 1;



--Question 04:
----------------
--●	 Write a query to find users whose reputation is greater than 
--the average reputation of all users. Display their DisplayName 
-- and Reputation. Use a subquery in the WHERE clause.
SELECT Id, DisplayName, Reputation
FROM Users
Where Reputation > (SELECT AVG(Reputation)
					FROM Users)

--Question 05 :
-----------------
--●	Write a query to display each post title along with the first 
--50 characters of the title. If the title is NULL, replace it 
--with 'No Title'. Use SUBSTRING and ISNULL functions.
SELECT ISNULL(SUBSTRING(Title, 1, 50), 'No Title') AS Title
FROM Posts;



--Question 06 :
-----------------
--●	Write a query to calculate the total score and average score 
--for each PostTypeId. Also show the count of posts for each type.
-- Only include post types that have more than 100 posts.

SELECT 
	PostTypeId, 
	SUM(Score) AS SUMScore, 
	AVG(Score) AS AVGScore
FROM Posts
GROUP BY PostTypeId
HAVING COUNT(Id) > 100;



--Question 07 :
----------------
--●	Write a query to show each user's DisplayName along with 
--the total number of badges they have earned. Use a subquery 
--in the SELECT clause to count badges for each user.

SELECT	
	DisplayName,
	(Select COUNT(*)FROM Badges B Where B.UserId = U.Id) AS TotalBadges
FROM Users U;



--Question 08 :
-----------------
--● Write a query to find all posts where the title contains the word 
--'SQL'. Display the title, score, and format the CreationDate as 
--'Mon DD, YYYY'. Use CHARINDEX and FORMAT functions.

SELECT
	Title,
	Score,
	FORMAT(CreationDate, 'MM dd, yyyy') AS CreationDate
FROM Posts
WHERE CHARINDEX('SQL', Title) > 0;

--Question 09 :
----------------
--Write a query to group comments by PostId and calculate:
--Total number of comments
--Sum of comment scores
--Average comment score
--Only show posts that have more than 5 comments.

SELECT 
	COUNT(Id) AS TotalComments,
	SUM(Score) AS TotalScores,
	AVG(Score) AS AVGScores
From Comments
GROUP BY PostId
HAVING COUNT(Id) > 5;


--Question 10 :
----------------
--● Write a query to find all users whose location is not NULL.
--Display their DisplayName, Location, and calculate their 
--reputation level using IIF: 'High' if reputation > 5000, 
--otherwise 'Normal'.

SELECT 
	DisplayName,
	Location,
	Reputation,
	IIF(Reputation > 5000, 'High', 'Normal') AS REPStatus
FROM Users
WHERE Location IS NOT NULL;



--Question 11 :
----------------
--●	 Write a query using a derived table (subquery in FROM) to:
--. First, calculate total posts and average score per user
--. Then, join with Users table to show DisplayName
--. Only include users with more than 3 posts
--  The derived table must have an alias.
SELECT  
	UserStatus.OwnerUserId, 
	U.DisplayName,
	UserStatus.TotalPosts, 
	UserStatus.AVGScores
FROM Users U Inner Join (SELECT
							OwnerUserId,
							COUNT(Id) AS TotalPosts,
							AVG(Score) As AVGScores
							FROM Posts
							GROUP BY OwnerUserId) AS UserStatus
ON U.Id = UserStatus.OwnerUserId
WHERE UserStatus.TotalPosts > 3


--Question 12 :
----------------
--●Write a query to group badges by UserId and badge Name.
--Count how many times each user earned each specific badge.
--Display UserId, badge Name, and the count.
--Only show combinations where a user earned the same badge 
--more than once
SELECT 
	UserId,
	Name,
	COUNT(*) AS NumOfBadges
FROM Badges
GROUP BY UserId, Name
HAVING COUNT(*) > 1


--Question 13 :
----------------
--●	 Write a query to display user information along with their 
--account age in years. Use DATEDIFF to calculate years between 
--CreationDate and current date. Round the result to 2 decimal places.
--Also show the absolute value of their DownVotes.
SELECT 
	ROUND(DATEDIFF(YEAR, CreationDate, GETDATE()), 2) AS AccountAge,
	ABS(DownVotes) AS ABSDownVotes
FROM Users



--Question 14 :
----------------
--●	Write a complex query that:
--. Uses a derived table to calculate comment statistics per post
--. Joins with Posts and Users tables
--. Shows: Post Title, Author Name, Author Reputation, 
-- Comment Count, and Total Comment Score
--. Filters to only show posts with more than 3 comments 
-- and post score greater than 10
--. Uses COALESCE to replace NULL author names with 'Anonymous'


SELECT 
    P.Title AS PostTitle,
    COALESCE(U.DisplayName, 'Anonymous') AS AuthorName,
    U.Reputation AS AuthorReputation,
    C.CommentCount,
    C.TotalCommentScore
FROM Posts P
INNER JOIN 
(
    SELECT 
        PostId,
        COUNT(*) AS CommentCount,
        SUM(Score) AS TotalCommentScore
    FROM Comments
    GROUP BY PostId
) C ON P.Id = C.PostId
LEFT JOIN Users U 
    ON P.OwnerUserId = U.Id
WHERE 
    C.CommentCount > 3
    AND P.Score > 10
ORDER BY C.CommentCount DESC;


Use StackOverflow2010;

--Question 1:
--------------
-- Write a query to display all users along with all post types  
SELECT u.*, pt.Type
FROM Users u
CROSS JOIN PostTypes pt;

--Question 2:
--------------
--Write a query to retrieve all posts along with their owner's  
--display name and reputation. Only include posts that have an 
--owner

SELECT p.*, u.DisplayName, u.Reputation
FROM Posts p
INNER JOIN Users u ON p.OwnerUserId = u.Id;



--Question 3:
--------------
--Write a query to show all comments with their associated post 
--titles. Display the comment text, comment score, and post title. 

SELECT c.Text, c.Score AS CommentScore, p.Title AS PostTitle
FROM Comments c
INNER JOIN Posts p ON c.PostId = p.Id;


--Question 4:
--------------
--Write a query to list all users and their badges (if any). 
--Include users even if they don't have badges. Show display name, 
--badge name, and badge date.

SELECT u.DisplayName, b.Name AS BadgeName, b.Date AS BadgeDate
FROM Users u
LEFT JOIN Badges b ON u.Id = b.UserId
ORDER BY u.DisplayName, b.Date;


--Question 5:
--------------
--Write a query to display all posts along with their comments (if 
--any). Include posts that have no comments. Show post title, post 
--score, comment text, and comment score.

SELECT p.Title AS PostTitle, p.Score AS PostScore, c.Text AS CommentText, c.Score AS CommentScore
FROM Posts p
LEFT JOIN Comments c ON p.Id = c.PostId
ORDER BY p.Id;


--Question 6:
--------------
--Write a query to show all votes along with their corresponding 
--posts. Include all votes even if the post information is missing. 
--Display vote type ID, creation date, and post title. 

SELECT v.VoteTypeId, v.CreationDate, p.Title AS PostTitle
FROM Votes v
LEFT JOIN Posts p ON v.PostId = p.Id;



--Question 7:
--------------
--Write a query to find all answers (posts with ParentId) along with 
--their parent question. Show the answer title, answer score, 
--question title, and question score

SELECT a.Title AS AnswerTitle, a.Score AS AnswerScore,
       q.Title AS QuestionTitle, q.Score AS QuestionScore
FROM Posts a
INNER JOIN Posts q ON a.ParentId = q.Id
WHERE a.PostTypeId = 2;  -- 2 = Answer


--Question 8:
--------------
--Write a query to display all related posts using the PostLinks table. 
--Show the original post title, related post title, and link type ID.

SELECT p.Title AS OriginalPostTitle,
       rp.Title AS RelatedPostTitle,
       pl.LinkTypeId
FROM PostLinks pl
INNER JOIN Posts p ON pl.PostId = p.Id
INNER JOIN Posts rp ON pl.RelatedPostId = rp.Id;


--Question 9:
--------------
--Write a query to show posts with their authors and the post type 
--name. Display post title, author display name, author reputation,  
--and post type.

SELECT p.Title AS PostTitle,
       u.DisplayName AS AuthorDisplayName,
       u.Reputation AS AuthorReputation,
       pt.Type AS PostType
FROM Posts p
INNER JOIN Users u ON p.OwnerUserId = u.Id
INNER JOIN PostTypes pt ON p.PostTypeId = pt.Id;


--Question 10:
--------------
--Write a query to retrieve all comments along with the post title, 
--post author, and the commenter's display name.

SELECT c.*,
       p.Title AS PostTitle,
       pu.DisplayName AS PostAuthorDisplayName,
       cu.DisplayName AS CommenterDisplayName
FROM Comments c
INNER JOIN Posts p ON c.PostId = p.Id
INNER JOIN Users pu ON p.OwnerUserId = pu.Id
INNER JOIN Users cu ON c.UserId = cu.Id;


--Question 11:
--------------
--Write a query to display all votes with post information and vote 
--type name. Show post title, vote type name, creation date, and 
--bounty amount. 

SELECT p.Title AS PostTitle,
       vt.Name AS VoteTypeName,
       v.CreationDate,
       v.BountyAmount
FROM Votes v
INNER JOIN Posts p ON v.PostId = p.Id
INNER JOIN VoteTypes vt ON v.VoteTypeId = vt.Id;


--Question 12:
--------------
--Write a query to show all users along with their posts and 
--comments on those posts. Include users even if they have no 
--posts or comments. Display user name, post title, and comment 
--text. 

SELECT u.DisplayName AS UserName,
       p.Title AS PostTitle,
       c.Text AS CommentText
FROM Users u
LEFT JOIN Posts p ON u.Id = p.OwnerUserId
LEFT JOIN Comments c ON p.Id = c.PostId AND u.Id = c.UserId;


--Question 13:
--------------
--Write a query to retrieve posts with their authors, post types, and 
--any badges the author has earned. Show post title, author name, 
--post type, and badge name. 

SELECT p.Title AS PostTitle,
       u.DisplayName AS AuthorName,
       pt.Type AS PostType,
       b.Name AS BadgeName
FROM Posts p
INNER JOIN Users u ON p.OwnerUserId = u.Id
INNER JOIN PostTypes pt ON p.PostTypeId = pt.Id
LEFT JOIN Badges b ON u.Id = b.UserId;


--Question 14:
--------------
--Write a query to create a comprehensive report showing:  
--post title, post author name, author reputation, comment text, 
--commenter name, vote type, and vote creation date. Include 
--posts even if they don't have comments or votes. Filter to only 
--show posts with a score greater than 5. 

SELECT p.Title AS PostTitle,
       u.DisplayName AS AuthorName,
       u.Reputation AS AuthorReputation,
       c.Text AS CommentText,
       cu.DisplayName AS CommenterName,
       vt.Name AS VoteType,
       v.CreationDate AS VoteCreationDate
FROM Posts p
INNER JOIN Users u ON p.OwnerUserId = u.Id
LEFT JOIN Comments c ON p.Id = c.PostId
LEFT JOIN Users cu ON c.UserId = cu.Id
LEFT JOIN Votes v ON p.Id = v.PostId
LEFT JOIN VoteTypes vt ON v.VoteTypeId = vt.Id
WHERE p.Score > 5;
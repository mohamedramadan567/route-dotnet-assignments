--Question 01 :
----------------
--Optimize the performance of queries that search for posts by a specific 
--user with a minimum score threshold, ordered by score. 
--Example query pattern: 
--"Find all posts by user 5 with score > 50, ordered by score descending" 

--Tasks: 
	--a) Design and implement an appropriate index structure 
	--b) Ensure the index covers all columns needed by the query 
	--c) Write a test query that demonstrates the optimization 
	--d) Verify the index was created successfully

SELECT Title, Score, CreationDate
FROM Posts
WHERE OwnerUserId = 5 AND Score > 50
ORDER BY Score DESC

CREATE NONCLUSTERED INDEX IX_PostsOwnerScore
ON Posts(OwnerUserId, Score Desc)
INCLUDE(Title, CreationDate)

SELECT Title, Score, CreationDate
FROM Posts
WHERE OwnerUserId = 5 AND Score > 50
ORDER BY Score DESC



--Question 02 :
----------------
--Optimize queries that frequently access high-value posts. These queries 
--always filter for posts with score > 100 and non-null titles. 
-- 
--Tasks: 
--a) Design an index that only includes posts meeting these criteria 
--b) Include relevant columns in the index 
--c) Write a query that demonstrates the optimization 
--d) Explain why this specialized index design is beneficial

SELECT Title, OwnerUserId, Score, CreationDate
FROM Posts
WHERE Score > 100 AND Title IS NOT NULL


--This specialized filtered covering index improves performance by 
--reducing index size to only high-value rows and eliminating key lookups, 
--enabling efficient index seeks for the targeted query pattern.
CREATE NONCLUSTERED INDEX IX_PostsScoreTitle
ON Posts(Score)
INCLUDE(Title, OwnerUserId, CreationDate)
WHERE Score > 100 AND Title IS NOT NULL

SELECT Title, OwnerUserId, Score, CreationDate
FROM Posts
WHERE Score > 100 AND Title IS NOT NULL
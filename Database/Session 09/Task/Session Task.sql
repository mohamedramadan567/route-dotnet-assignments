-- Scenario: The marketing team runs this query frequently to 
-- find popular posts by specific users, but it is running very slow.
-- Create the best possible Index to optimize this specific query
SELECT Id, Title, Score, ViewCount, CreationDate
FROM Posts
WHERE OwnerUserId = 22656  AND Score > 100
ORDER BY CreationDate DESC;



















CREATE NONCLUSTERED INDEX IX_Posts_Owner_Date_Score
ON Posts(OwnerUserId, CreationDate DESC) 
INCLUDE (Title, Score, ViewCount);
GO
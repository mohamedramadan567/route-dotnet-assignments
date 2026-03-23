-- Scenario: Management wants a simple dashboard showing "User Engagement". 
-- They need a view that hides the complexity of joins.
-- Create a view named v_UserEngagement.
-- The view should return:  
-- UserDisplayName 
-- TotalPosts (Count of their posts)
-- TotalComments (Count of their comments)
-- OverallScore (Sum of scores from both posts and comments)
-- Condition: Only include users who have at least 1 Post.

CREATE OR ALTER VIEW v_UserEngagement
AS
SELECT 
    u.DisplayName AS UserDisplayName,
    p.TotalPosts,
    c.TotalComments,
    p.TotalScore + c.TotalScore AS OverallScore
FROM Users u
JOIN (
    SELECT OwnerUserId, COUNT(*) AS TotalPosts, SUM(Score) AS TotalScore
    FROM Posts
    GROUP BY OwnerUserId
) p ON u.Id = p.OwnerUserId
LEFT JOIN (
    SELECT UserId, COUNT(*) AS TotalComments, SUM(Score) AS TotalScore
    FROM Comments
    GROUP BY UserId
) c ON u.Id = c.UserId;


-- Scenario: We have a heavy reporting query that calculates the Total Views received by all posts for each year.
-- This calculation takes too long because the Posts table is huge.
-- Create a view v_YearlyPostStats that calculates:
-- PostYear (derived from CreationDate)
-- TotalViews (Sum of ViewCount)
-- TotalPostCount (Count of posts)
-- Constraint: You must use WITH SCHEMABINDING and COUNT_BIG(*).
-- Create a Unique Clustered Index on this view to materialize it.

Go
CREATE OR ALTER VIEW dbo.v_YearlyPostStats
WITH SCHEMABINDING
AS
SELECT 
    YEAR(CreationDate) AS PostYear,
    SUM(ViewCount) AS TotalViews,
    COUNT_BIG(*) AS TotalPostCount
FROM dbo.Posts
GROUP BY YEAR(CreationDate);
GO

CREATE UNIQUE CLUSTERED INDEX IX_v_YearlyPostStats_Year
ON dbo.v_YearlyPostStats(PostYear);

GO


CREATE UNIQUE CLUSTERED INDEX IX_v_YearlyPostStats_Year
ON v_YearlyPostStats(PostYear);
GO

SELECT * 
FROM v_YearlyPostStats 
ORDER BY PostYear DESC;


-- Scenario: You need to give a junior moderator access to update post titles, but they are only allowed to touch posts 
-- that have a Score lower than 10 (Low quality posts). They should not be able to edit high-scoring posts or accidentally 
-- upgrade a low-score post to a high score manually.
-- Create a view v_LowScorePosts that selects Id, Title, Score from Posts where Score < 10.
-- Add the necessary option to prevent the moderator from updating a post's score to be 20 (which would make it disappear from their view).

GO
CREATE OR ALTER VIEW v_LowScorePosts
AS
    SELECT Id, Title, Score
    FROM Posts
    WHERE Score < 10
    WITH CHECK OPTION; 
GO

UPDATE v_LowScorePosts
SET Title = 'Updated Low Quality Post'
WHERE Id = 123; 


UPDATE v_LowScorePosts
SET Score = 20
WHERE Id = 123;
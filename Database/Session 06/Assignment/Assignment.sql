Use StackOverflow2010;

----------------------------------
		  -- Question 1 --
----------------------------------
--● Write a query to retrieve the top 15 users with the highest reputation. 
--● Display their DisplayName, Reputation, and Location. 
--● Order the results by Reputation in descending order

Select Top 15 DisplayName, Reputation, Location
From Users 
Order By Reputation DESC;


----------------------------------
		  -- Question 2 --
----------------------------------
--● Write a query to get the top 10 posts by score, but include  
--●  all posts that have the same score as the 10th post. 
--● Use TOP WITH TIES. Display Title, Score, and ViewCount. 

Select top 10 with ties Title, Score, ViewCount
From Posts
Order By Score Desc;


----------------------------------
		  -- Question 3 --
----------------------------------
--● Write a query to implement pagination: skip the first 20 users  
--● and retrieve the next 10 users when ordered by reputation. 
--● Use OFFSET and FETCH. Display DisplayName and Reputation.

Select DisplayName, Reputation
From Users
Order By Reputation DESC
OFFSET 20 Rows Fetch NEXT 10 Rows Only


----------------------------------
		  -- Question 4 --
----------------------------------
--●Write a query to assign a unique row number to each post  
--●  ordered by Score in descending order. 
--● Use ROW_NUMBER(). Display the row number, Title, and Score. 
--● Only include posts with non-null titles.

Select ROW_NUMBER() Over(order By Score DESC) As Rn, Title, Score
From Posts
Where Title is Not NULL


----------------------------------
		  -- Question 5 --
----------------------------------
--●  Write a query to rank users by their reputation using RANK(). 
--●  Display the rank, DisplayName, and Reputation. 

Select RANK() Over(Order By Reputation DESC) As rn, DisplayName, Reputation
From Users

--● Explain what happens when two users have the same reputation. 
--Answer: Two users share the same rank, and there is a gap before the next user’s rank.



----------------------------------
		  -- Question 6 --
----------------------------------
--● Write a query to rank posts by score using DENSE_RANK(). 
--● Display the dense rank, Title, and Score. 

Select DENSE_RANK() Over(Order By Score DESC) As 'Dense Rank', Title, Score
From Posts

--● Explain how DENSE_RANK differs from RANK.
--Answer: RANK Causes Gap, while DESE_RANK don't cause Gap.


----------------------------------
		  -- Question 7 --
----------------------------------
--●  Write a query to divide all users into 5 equal groups (quintiles) 
--● based on their reputation. Use NTILE(5). 
--● Display the quintile number, DisplayName, and Reputation.

Select NTILE(5) Over(Order By Reputation DESC) As 'Quintile Number', DisplayName, Reputation
From Users


----------------------------------
		  -- Question 8 --
----------------------------------
--● Write a query to rank posts within each PostTypeId separately. 
--● Use ROW_NUMBER() with PARTITION BY. 
--● Display PostTypeId, rank within type, Title, and Score. 
--● Order by Score descending within each partition. 

Select  PostTypeId, 
		ROW_NUMBER() Over(PARTITION BY PostTypeId Order By Score Desc) As RankInType,
		Title,
		Score
From Posts
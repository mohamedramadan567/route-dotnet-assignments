--Question 1:
--------------
--Write a query to display all researchers along with the projects they work on. Include 
--researchers who are not currently working on any project. 
SELECT 
	R.Id, 
	CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS ResearcherName, 
	W.ProjectId, 
	W.Role 
FROM WorksOn W RIGHT JOIN Researcher R ON R.Id = W.ResearcherId

--Question 2:
--------------
--List all research projects with their lead researcher's full name and email. Show only projects 
--that have at least one grant funding them. 

SELECT 
	DISTINCT RP.Id AS ProjectId,
	RP.Title AS ProjectTitle,
	CONCAT(R.FirstName, ' ', R.MiddleName, ' ', R.LastName) AS LeaderFullName, 
	R.Email
FROM ResearchProject RP JOIN Funds F ON RP.Id = F.ProjectId
						JOIN Researcher R ON R.Id = RP.LeaderId


--Question 3:
--------------
--Write a query to show all possible combinations of researchers and publications. Then explain 
--why this might be a bad idea for a production query. 

SELECT R.Id, P.Id
FROM Researcher R CROSS JOIN Publication P
--Why? Cross join creates too many unnecessary records, 
--which can severely impact performance and is not suitable for production environments.


--Question 4:
--------------
--Display all researchers who supervise others, along with the names of researchers they 
--supervise. Include the supervision start date and role. 
SELECT
	S.SupervisorId,
	CONCAT(L.FirstName, ' ', L.MiddleName, ' ', L.LastName) AS SupervisorName, 
	S.SupervisedId,
	CONCAT(E.FirstName, ' ', E.MiddleName, ' ', E.LastName) AS SupervisedName,
	S.SupervisionStartDate,
	S.Role
FROM Supervises S JOIN Researcher L ON L.Id = S.SupervisorId
				  JOIN Researcher E ON E.Id = S.SupervisedId

--#Question 5:
----------------
--Write a query to find all researchers who have published papers but are NOT currently working 
--on any active project. 

SELECT 
	R.Id,
	CONCAT(R.FirstName, ' ', R.MiddleName, ' ', R.LastName) AS ResearcherName,
	R.Email,
	P.PublicationId,
	Pb.Title AS PublicationTitle
FROM Publishes P JOIN Researcher R ON R.Id = P.ResearcherId
				 JOIN Publication Pb ON Pb.Id = P.PublicationId
WHERE NOT EXISTS (
    SELECT 1
    FROM WorksOn W
    JOIN ResearchProject Pr ON Pr.Id = W.ProjectId
    WHERE W.ResearcherId = R.Id
      AND Pr.Status = 'Active'
);




--Question 6:
--------------
--Retrieve the five most-cited publications, ensuring that any publications sharing the same 
--citation count as the fifth-ranked entry are also included.

SELECT TOP 5 WITH TIES *
FROM Publication
Order By CitationCount DESC



--Question 7:
-------------
--Retrieve researchers ordered by last name, displaying the second page of results with 10 
--records per page. 

SELECT * 
FROM Researcher 
ORDER BY LastName 
OFFSET 10 ROWS
FETCH NEXT 10 ROWS ONLY

--Question 8:
--------------
--Compare the results of: 
SELECT TOP 3 *  
FROM Researcher 
ORDER BY LastName  

--Versus 
SELECT *  
FROM Researcher  
ORDER BY LastName  
OFFSET 0 ROWS 
FETCH NEXT 3 ROWS ONLY 
--Are they functionally identical? What are the advantages of OFFSET-FETCH over TOP? 
--In this case yes but in general no - OFFSET-FETCH More Flexible than Top Which we can skip certain rows



--Question 9:
--------------
--Assign a unique sequential index to each researcher within the same building,
--ordered by date of birth from oldest to youngest.

SELECT
    Id,
    FirstName,
    LastName,
    Building,
    DateOfBirth,
    ROW_NUMBER() OVER (PARTITION BY Building ORDER BY DateOfBirth ASC) AS SequentialIndex
FROM Researcher;


--Question 10:
---------------
--Rank publications within each publication type (Journal or Conference) based on their citation 
--count, and display the publication title, type, citation count, and rank. 

SELECT 
	Title,
	Type,
	CitationCount,
	RANK() OVER (PARTITION BY Type ORDER BY CitationCount DESC) AS RN
FROM Publication

--Question 11:
---------------
--Rank research projects by their budget within each status category, then explain how ranking 
--with gaps differs from ranking without gaps. 


--Ranking with gaps gives the same rank to ties and leaves gaps in the next ranks, while ranking without gaps gives the same rank to ties but the next ranks continue consecutively.
--With Gaps
SELECT 
	Id,
	Title,
	Budget,
	Status,
	LeaderId,
	RANK() OVER(PARTITION BY Status ORDER BY Budget DESC) AS Rn
FROM ResearchProject

--Without Gaps
SELECT 
	Id,
	Title,
	Budget,
	Status,
	LeaderId,
	DENSE_RANK() OVER(PARTITION BY Status ORDER BY Budget DESC) AS Rn
FROM ResearchProject


--Question 12:
--------------
--Divide researchers into four equal groups based on the number of publications they have 
--authored, and display each researcher’s ID, name, publication count, and group number.

SELECT 
	P.ResearcherId, 
	CONCAT(R.FirstName, ' ', R.MiddleName, ' ', R.LastName) AS FullName,
	COUNT(P.PublicationId) AS TotalPublication,
	NTILE(4) OVER (ORDER BY COUNT(P.PublicationId) DESC) AS GroupNumber
FROM Researcher R JOIN Publishes P ON R.Id = P.ResearcherId
GROUP BY P.ResearcherId, R.FirstName, R.MiddleName, R.LastName


--Question 13:
---------------
--Explain the logical execution order of the following query clauses: SELECT, FROM, WHERE, 
--GROUP BY, HAVING, ORDER BY, TOP/OFFSET-FETCH.

--FROM -> WHERE -> GROUP BY -> HAVING -> SELECT -> ORDER BY -> TOP -> OFFSET-FETCH


--Question 14:
--------------
--Given this query, explain why it produces an error and how to fix it: 

--error because
--1- we can't use where with group by but we use having instead of where 
--2- We can't use ailes name of COUNT(*) Because Having Excute Before Select 
SELECT ResearcherId, COUNT(*) as ProjectCount 
FROM WorksOn  
WHERE ProjectCount > 2
GROUP BY ResearcherId 


--Fixed Query
SELECT ResearcherId, COUNT(*) as ProjectCount 
FROM WorksOn  
GROUP BY ResearcherId 
Having COUNT(*) > 2

--#Question 15:
---------------
--Write a query to display each researcher's full name (FirstName + MiddleName + LastName) as 
--a single column, their email in lowercase, and their age in years. 

SELECT 
    CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS FullName,
    LOWER(Email) AS Email,
    DATEDIFF(YEAR, DateOfBirth, GETDATE())
    - CASE 
        WHEN FORMAT(GETDATE(), 'MM-dd') < FORMAT(DateOfBirth, 'MM-dd') THEN 1
        ELSE 0
      END AS AgeInYears
FROM Researcher;

--Question 16:
---------------
--For each research project, calculate the duration in days between StartDate and EndDate (or 
--current date if EndDate is NULL). Also show the month and year when the project started. 

SELECT 
	Id, 
	Title,
	DATEDIFF(DAY, StartDate, ISNULL(EndDate, GETDATE())) AS DurationInDays,
	MONTH(StartDate) AS BeginngMonth,
	YEAR(StartDate) AS BeginngYear
FROM ResearchProject


--Question 17:
---------------
--Write a query to find all researchers whose email domain (part after @) is 'university.edu'. 

SELECT *
FROM Researcher
WHERE Email Like '%@university.edu'


--Question 18:
---------------
--Display researcher details, substituting 'N/A' wherever the MiddleName or RoomNumber is 
--missing.

SELECT 
	Id,
	FirstName, 
	ISNULL(MiddleName, 'N/A') AS MiddleName,
	LastName, 
	Email, 
	ISNULL(RoomNumber, 'N/A') AS RoomNumber
FROM Researcher



--Question 19:
----------------
--Write a query to classify projects into categories based on their budget: 'Small' for budgets 
--under 50,000, 'Medium' for budgets between 50,000 and 150,000, and 'Large' for budgets 
--exceeding 150,000.

SELECT 
	Id, 
	Title,
	CASE 
		WHEN Budget < 50000 THEN 'Small'
		WHEN Budget BETWEEN 50000 AND 150000 THEN 'Medium'
		WHEN Budget > 150000 THEN 'Large'
	END AS Budget
FROM ResearchProject


--Question 20:
---------------
--Calculate the total budget managed by each researcher who leads one or more projects, and 
--display their full name alongside this total. 

SELECT 
	LeaderId,
	CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS LeaderFullName,
	SUM(Budget) AS TotalBudget
FROM ResearchProject P JOIN Researcher R ON R.Id = P.LeaderId
GROUP BY LeaderId, FirstName, MiddleName, LastName

--Question 21:
---------------
--Display the number of researchers in each building, 
--but only for buildings that have more than 3 researchers. 

SELECT 
	Building, 
	COUNT(*) AS TotalResearchers
FROM Researcher
GROUP BY Building
HAVING COUNT(*) > 3


--Question 22:
--------------
--For each publication type, calculate the average citation count, total citations, and
--number of publications. Filter to show only types with an average citation count above 50. 

SELECT 
	Type,
	AVG(CitationCount) AS AvgCitationCount,
	SUM(CitationCount) AS TotalCitationCount,
	COUNT(*) AS TotalPublications
FROM Publication
GROUP BY Type
HAVING AVG(CitationCount) > 50


--Question 23:
---------------
--Find researchers who work on more than 2 projects and have a total weekly hour commitment 
--exceeding 60 hours. Show ResearcherId, project count, and total hours. 

SELECT 
	ResearcherId,
	COUNT(ProjectId) AS ProjectsCount,
	SUM(HoursPerWeek) AS TotalHours
FROM WorksOn
GROUP BY ResearcherId
HAVING COUNT(*) > 2 AND SUM(HoursPerWeek) > 60

--Question 24:
---------------
--Write a query using a subquery to find all projects that have a budget greater than the average 
--budget of all projects. 

SELECT 
	*
FROM ResearchProject
WHERE Budget > (SELECT AVG(Budget) FROM ResearchProject)


--Question 25:
---------------
--Write a query using a subquery to find researchers who have more publications than the 
--average number of publications for researchers in the same building.

SELECT R.Id, R.FirstName, R.LastName, R.Building
FROM Researcher R
JOIN Publishes P ON R.Id = P.ResearcherId
GROUP BY R.Id, R.FirstName, R.LastName, R.Building
HAVING COUNT(P.PublicationId) >
(
    SELECT AVG(PubCount)
    FROM
    (
        SELECT COUNT(P2.PublicationId) AS PubCount
        FROM Researcher R2
        JOIN Publishes P2 ON R2.Id = P2.ResearcherId
        WHERE R2.Building = R.Building
        GROUP BY R2.Id
    ) AS BuildingAvg
);

--Question 26:
---------------
--Write a query using EXISTS to find all researchers who supervise at least one other researcher. 

SELECT *
FROM Researcher R
WHERE EXISTS (
    SELECT 1
    FROM Supervises S
    WHERE S.SupervisorId = R.Id
);


--Question 27:
---------------
--Use a subquery to display each project along with the total number of researchers working on 
--it. 

SELECT 
    P.Id AS ProjectId,
    (
        SELECT COUNT(*)
        FROM WorksOn W
        WHERE W.ProjectId = P.Id
    ) AS TotalResearchers
FROM ResearchProject P;

--#Question 28:
---------------
--Write a query to find the second highest budget among all research projects (Do not use 
--OFFSET-FETCH or ranking functions). 

--Q28: Query returns full rows instead of only the second highest budget value.

SELECT Top 1 WITH TIES Budget 
FROM ResearchProject
WHERE Budget < (SELECT MAX(Budget) FROM ResearchProject)
ORDER BY Budget DESC



--Question 29:
---------------
--Combine the list of all researcher emails and all grant funding agency names into a single list 
--labeled "Contact Information". 

SELECT Email AS [Contact Information]
FROM Researcher

UNION

SELECT AgencyName AS [Contact Information]   
FROM ProjectFundingAgency;

--#Question 30:
---------------
--Identify researchers involved in projects who have not authored any publications. 

--Q30: Logic is reversed — it returns researchers not working on projects instead of those working but without publications.
--SELECT Id
--FROM Researcher
--EXCEPT
--SELECT DISTINCT ResearcherId
--FROM WorksOn

SELECT DISTINCT W.ResearcherId
FROM WorksOn W
EXCEPT
SELECT DISTINCT P.ResearcherId
FROM Publishes P;


--another sol
SELECT DISTINCT W.ResearcherId
FROM WorksOn W
WHERE NOT EXISTS (
    SELECT 1
    FROM Publishes P
    WHERE P.ResearcherId = W.ResearcherId
);


--Question 31:
---------------
--Find researchers who supervise others and also lead one or more research projects.

SELECT DISTINCT SupervisorId
FROM Supervises
INTERSECT
SELECT 
	DISTINCT LeaderId
FROM ResearchProject

--Question 32:
---------------
--Write a CTE to calculate the total hours per week for each researcher across all their projects,
--then use it to find researchers working more than 40 hours per week.
GO
WITH TotalHours AS
(
	SELECT 
		ResearcherId,
		SUM(HoursPerWeek) AS TotalHours
	FROM WorksOn
	GROUP BY ResearcherId
)
SELECT * 
FROM TotalHours TH
WHERE TH.TotalHours > 40;


--Question 33:
---------------
--Write a query using multiple CTEs: one to get the total budget per researcher (who leads
--projects), another to get their publication count, then join them to show researchers with
--budget > 100000 AND at least 3 publications.

WITH LeaderTotalBudget AS
(
	SELECT 
	LeaderId, 
	SUM(Budget) AS TotalBudget
	FROM ResearchProject
	GROUP BY LeaderId
),
ResearcherPublications AS
(
	SELECT 
		ResearcherId,
		COUNT(PublicationId) AS TotalPublications
	FROM Publishes 
	GROUP BY ResearcherId
)
SELECT 
	RP.ResearcherId,
	LTB.TotalBudget,
	RP.TotalPublications
FROM LeaderTotalBudget LTB JOIN ResearcherPublications RP ON LTB.LeaderId = RP.ResearcherId
WHERE LTB.TotalBudget > 100000 AND RP.TotalPublications >= 3


--Question 34:
---------------
--Write a reusable function that takes a ProjectId and returns how many days the project has
--been active, calculating from the start date to either the end date or today if the project is
--ongoing.
GO
CREATE OR ALTER FUNCTION dbo.GetActiveDays(@ProjectId VARCHAR(10))
RETURNS INT
AS
BEGIN
	DECLARE @Days INT;

	SELECT 
		@Days = DATEDIFF(Day, StartDate, ISNULL(EndDate, GetDate()))
	FROM ResearchProject
	WHERE Id =@ProjectId

	RETURN @Days
END
GO


SELECT 
	Id, 
	Title, 
	Budget,
	dbo.GetActiveDays(Id) AS ActiveDays
FROM ResearchProject

--Question 35:
--------------
--Write a reusable function that takes a ResearcherId and returns all projects they are involved in,
--showing the project title, their role, and hours worked per week.

GO 
CREATE OR ALTER FUNCTION dbo.ResearcherProjects(@ResearcherId VARCHAR(10))
RETURNS TABLE 
AS 
RETURN
(
	SELECT
		P.Title, 
		W.Role, 
		W.HoursPerWeek
	FROM WorksOn W JOIN ResearchProject P ON P.Id = W.ProjectId
	WHERE ResearcherId = @ResearcherId
)
GO

SELECT * FROM dbo.ResearcherProjects('R099');


--Question 36:
--------------
--Write a function that takes a ResearcherId and returns a table containing the total number of
--projects, total publications, total hours worked per week, and average citations per publication
--for that researcher. Also, explain the scenarios where a multi-statement table-valued function is
--preferred over an inline table-valued function.

GO
CREATE OR ALTER FUNCTION dbo.ResearcherDetails(@ResearcherId VARCHAR(10))
RETURNS @Details TABLE
(
	TotalProjects INT, TotalPublications INT, TotalHoursPerWeek INT,
	AvgCitations DECIMAL(10, 2)
)
AS
BEGIN
	DECLARE @TotalProjects INT, @TotalPublications INT, @TotalHoursPerWeek INT;
	DECLARE @AvgCitations DECIMAL(10, 2);

	SELECT 
		@TotalProjects = COUNT(ProjectId),
		@TotalHoursPerWeek = SUM(HoursPerWeek)
	FROM WorksOn 
	WHERE ResearcherId = @ResearcherId

	SELECT 
		@TotalPublications = COUNT(PublicationId)
	FROM Publishes
	WHERE ResearcherId = @ResearcherId

	SELECT 
		@AvgCitations = AVG(CitationCount)
	FROM Publication Pub JOIN Publishes P ON P.PublicationId = Pub.Id
	WHERE P.ResearcherId = @ResearcherId

	SET @TotalProjects = ISNULL(@TotalProjects, 0);
	SET @TotalPublications = ISNULL(@TotalPublications, 0);
	SET @TotalHoursPerWeek = ISNULL(@TotalHoursPerWeek, 0);

	INSERT INTO @Details
	VALUES(@TotalProjects, @TotalPublications, @TotalHoursPerWeek, @AvgCitations)
    RETURN;
END
GO

SELECT * FROM dbo.ResearcherDetails('R008');


--A multi-statement table-valued function is preferred when the logic is complex 
--and cannot be expressed as a single SELECT statement, such as when you need multiple queries, 
--intermediate variables, conditional logic (IF/ELSE), or step-by-step calculations.

--An inline table-valued function is better for simple, 
--single-query logic and usually offers better performance.


--Question 37:
---------------
--Create a non-clustered index on the ResearchProject table to improve queries that search by
--Status and StartDate.

SELECT Title, Status, StartDate
FROM ResearchProject

CREATE NONCLUSTERED INDEX IX_ResearchProject_Status_StartDate
ON ResearchProject(Status, StartDate)
INCLUDE(Title)

SELECT Title, Status, StartDate
FROM ResearchProject


--Question 38:
---------------
--Explain the difference between a clustered and non-clustered index. How many clustered
--indexes can a table have? What happens to existing indexes when you create a clustered index?

--clustered Index: Is the Index that will arrange the rows physically in the Disk in sorted order .
--non-clustered Index: A separate structure that holds indexed column values and pointers to actual data.

--one clustered index can a table have.

--When you create a clustered index on a table:
	--The table data is physically reordered based on the clustered key.
	--Existing non-clustered indexes are automatically updated.
	--Their row locators change from RID to the clustered key.

--Question 39:
--------------
--You have a query that frequently searches for researchers by Email and retrieves their
--FirstName and LastName. Write a covering index that would make this query more efficient.
--Explain what a covering index is and why it improves performance

CREATE NONCLUSTERED INDEX IX_Researchers_Email
ON Researcher(Email)
INCLUDE(FirstName, LastName)

--A covering index is an index that contains all the columns used in the where clause
--and all the columns in the SELECT list.

--Why it improves performance?
--- Decreases logical reads.
--- Prevents key lookups.
--- Makes query execution faster.


--Question 40:
---------------
--Create a view named ActiveProjectSummary that shows project title, leader name, number of team
--members, total hours per week allocated, and total budget..

CREATE OR ALTER VIEW ActiveProjectSummary
AS
SELECT 
    P.Title,
    CONCAT(R.FirstName, ' ', R.MiddleName, ' ', R.LastName) AS [Leader Name],
    COUNT(W.ResearcherId)AS NumberOfTeamMembers,
    SUM(W.HoursPerWeek)AS TotalHoursPerWeek,
    P.Budget AS TotalBudget
FROM ResearchProject P
    JOIN Researcher R ON P.LeaderId = R.Id
    JOIN WorksOn W ON P.Id = W.ProjectId   
GROUP BY 
    P.Id, 
    P.Title, 
    R.FirstName, R.MiddleName, R.LastName, 
    P.Budget;

SELECT * FROM ActiveProjectSummary

--Question 41:
---------------
--Create an indexed view named ResearcherPublicationStats that shows ResearcherId, researcher full
--name, and total number of publications. Include the necessary.

GO
CREATE OR ALTER VIEW ResearcherPublicationStats
WITH SCHEMABINDING
AS 
	SELECT 
		R.Id AS ResearcherId, 
		R.FirstName,
		R.MiddleName,
		R.LastName,
		COUNT_BIG(*) AS TotalPublications
	FROM dbo.Researcher R JOIN dbo.Publishes P ON R.Id = P.ResearcherId
	GROUP BY R.Id, R.FirstName, R.MiddleName, R.LastName
GO

CREATE UNIQUE CLUSTERED INDEX IX_ResearcherPublicationStats
ON dbo.ResearcherPublicationStats (ResearcherId);

SELECT 
	ResearcherId,
	CONCAT(FirstName, ' ', MiddleName, ' ', LastName) AS FullName,
	TotalPublications
FROM dbo.ResearcherPublicationStats;

--Question 42:
---------------
--Explain the requirements and restrictions for creating an indexed view. What are the
--performance benefits? When would you choose an indexed view over a regular view or a table?

--Requirments: Must use WITH SCHEMABINDING and include COUNT_BIG(*) if grouping.
--Restrictions: -No LEFT/RIGHT/FULL JOIN, UNION, or DISTINCT (Only INNER JOIN is allowed).
--				-No Subqueries, CTEs, Derived Tables, or TOP/OFFSET.
--				-No MIN(), MAX(), or AVG().
--				-No Non-deterministic functions like GETDATE() or NEWID().

--Huge Performance Boost: Pre-calculates complex Aggregations (`SUM`, `COUNT`) and JOINs.
--NOTE: Only use this on tables that are read-heavy but updated rarely.



--Question 43:
---------------
--Create a stored procedure named AddResearcherToProject that accepts ResearcherId, ProjectId,
--JoinDate, Role, and HoursPerWeek as parameters. The procedure should:
	--● Validate that both researcher and project exist
	--● Check that the researcher isn't already on the project
	--● Insert the record into WorksOn
	--● Return 0 for success, -1 for errors

GO
CREATE OR ALTER PROC AddResearcherToProject @ResearcherId VARCHAR(10), @ProjectId VARCHAR(10), 
@JoinDate Date, @Role VARCHAR(50), @HoursPerWeek INT
AS 
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		IF NOT EXISTS (SELECT 1 FROM Researcher WHERE Id = @ResearcherId)
			BEGIN RAISERROR('Researcher with ID %s does not exist', 16, 1, @ResearcherId) With Log;
			RETURN -1;
			END

		IF NOT EXISTS (SELECT 1 FROM ResearchProject WHERE Id = @ProjectId)
			BEGIN RAISERROR('Project with ID %s does not exist', 16, 1, @ProjectId) With Log;
			RETURN -1;
			END

		IF EXISTS(SELECT 1 FROM WorksOn WHERE ResearcherId = @ResearcherId AND ProjectId = @ProjectId)
			BEGIN RAISERROR('Researcher with ID %s Already in this Project', 16, 1, @ResearcherId) With Log;
			RETURN -1;
			END

		INSERT INTO WorksOn(ResearcherId, ProjectId, JoinDate, Role, HoursPerWeek)
		VALUES(@ResearcherId, @ProjectId, @JoinDate, @Role, @HoursPerWeek);

		RETURN 0;
	END TRY
	BEGIN CATCH
		RETURN -1;
	END CATCH

END
GO

--Question 44:
---------------
--Create a stored procedure named UpdateProjectStatus that accepts a ProjectId and changes its
--status from 'Pending' to 'Active', but only if the project has at least one researcher assigned and
--at least one funding source. Use appropriate error handling.

GO
CREATE OR ALTER PROC UpdateProjectStatus
    @ProjectId VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM ResearchProject WHERE Id = @ProjectId)
        BEGIN
            RAISERROR('Project does not exist', 16, 1);
            RETURN -1;
        END

        IF NOT EXISTS (SELECT 1 FROM ResearchProject WHERE Id = @ProjectId AND Status = 'Pending')
        BEGIN
            RAISERROR('Project is not in Pending status', 16, 1);
            RETURN -1;
        END

        IF NOT EXISTS (SELECT 1 FROM WorksOn WHERE ProjectId = @ProjectId)
        BEGIN
            RAISERROR('Project has no assigned researchers', 16, 1);
            RETURN -1;
        END

        IF NOT EXISTS (SELECT 1 FROM ProjectFundingAgency WHERE ProjectId = @ProjectId)
        BEGIN
            RAISERROR('Project has no funding source', 16, 1);
            RETURN -1;
        END

        UPDATE ResearchProject
        SET Status = 'Active'
        WHERE Id = @ProjectId;

        RETURN 0;
    END TRY
    BEGIN CATCH
        RETURN -1;
    END CATCH
END
GO

--Question 45:
---------------
--Write a stored procedure with OUTPUT parameters that accepts a ResearcherId and returns the
--total number of projects they work on, their total publications, and their total weekly hours
--across all projects.

GO
CREATE OR ALTER PROC Pr_ResearcherDetails @ResearcherId VARCHAR(10), @TotalProjects INT OUTPUT,
@TotalPublications INT OUTPUT, @TotalWeeklyHours INT OUTPUT
AS 
BEGIN
	SELECT @TotalProjects = COUNT(ProjectId), @TotalWeeklyHours = SUM(HoursPerWeek)
	FROM WorksOn
	GROUP BY ResearcherId
	HAVING ResearcherId = @ResearcherId;

	SELECT @TotalPublications = COUNT(PublicationId)
	FROM Publishes
	GROUP BY ResearcherId
	HAVING ResearcherId = @ResearcherId;

	SET @TotalProjects = ISNULL(@TotalProjects, 0);
    SET @TotalPublications = ISNULL(@TotalPublications, 0);
    SET @TotalWeeklyHours = ISNULL(@TotalWeeklyHours, 0);
END


--#Question 46:
---------------
--Create an AFTER INSERT trigger on the WorksOn table that prevents a researcher from being
--assigned to more than 5 projects. If the insertion would exceed this limit, rollback the
--transaction and raise an error.

--Q46: Trigger not implemented (missing logic and rollback handling).

GO
CREATE OR ALTER TRIGGER tgr_WorksOn_AfterInsert
ON WorksOn
AFTER INSERT
AS 
BEGIN
    SET NOCOUNT ON;

    IF EXISTS
    (
        SELECT I.ResearcherId
        FROM INSERTED I
        GROUP BY I.ResearcherId
        HAVING (
                SELECT COUNT(*)
                FROM WorksOn W
                WHERE W.ResearcherId = I.ResearcherId
               ) > 5
    )
    BEGIN
        ROLLBACK TRANSACTION;

        THROW 50001, 'A researcher cannot be assigned to more than 5 projects.', 1;
    END
END
GO


--Question 47:
---------------
--Create a trigger on the ResearchProject table that automatically updates the Status to
--'Completed' when an EndDate is set to a date in the past. Should this be an AFTER or INSTEAD
--OF trigger? Explain your choice.


-- I Choice After Update Because Instead Of Replace Update to another operation and This is not what is required

GO
CREATE OR ALTER TRIGGER trg_Project_AfterUpdate
ON ResearchProject
AFTER UPDATE 
AS 
BEGIN
	SET NOCOUNT ON;
	IF UPDATE(EndDate)
	BEGIN
		UPDATE P
        SET Status = 'Completed'
        FROM ResearchProject P INNER JOIN inserted I ON P.Id = I.Id
        WHERE I.EndDate IS NOT NULL AND I.EndDate < GETDATE();

		PRINT 'Status Updated Successfully'
	END

END


--Question 48:
--------------
--Create an audit trigger that logs all updates to the Grants table. Create an appropriate audit
--table to store: GrantId, OldAmount, NewAmount, ModifiedBy (SYSTEM_USER), ModifiedDate.

CREATE TABLE AuditLogUni
(
	AuditId INT IDENTITY(1,1) PRIMARY KEY,
	GrantId VARCHAR(10),
	OldAmount DECIMAL(12, 2),
	NewAmount DECIMAL(12, 2),
	ModifiedBy NVARCHAR(128),
	ModifiedDate DATETIME DEFAULT GETDATE()
)

GO
CREATE OR ALTER TRIGGER tgr_Grants_AFterUpdate
ON Grants
AFTER UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	IF UPDATE(Amount)
	BEGIN
		INSERT INTO AuditLogUni(GrantId, OldAmount, NewAmount, ModifiedBy)
		SELECT I.Id, D.Amount, I.Amount, SYSTEM_USER 
		FROM inserted I JOIN deleted D ON I.Id = D.Id
		WHERE I.Amount <> D.Amount
	END 
END
GO



--Question 49:
---------------
--Write a transaction that:
	--1. Creates a new research project
	--2. Assigns the project leader to work on it
	--3. Allocates a grant to fund it
--Include proper error handling with TRY-CATCH and ROLLBACK if any step fails.


BEGIN TRY
	BEGIN TRANSACTION
	INSERT INTO ResearchProject(Id ,Title, StartDate, EndDate, Budget, LeaderId)
	VALUES('P101', 'Test Title', '2024-10-01', NULL, 100000, 'R001');

	INSERT INTO WorksOn(ResearcherId, ProjectId, JoinDate, Role, HoursPerWeek, ContributionPercentage)
	VALUES('R001', 'P101', '2024-11-01', 'Lead Investigator', 18, 10);

	INSERT INTO Funds(GrantId, ProjectId, AllocationAmount, AllocationDate)
	VALUES('G003', 'P101', 200000, '2025-01-01');

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;

    PRINT 'Entire transaction rolled back: ' + ERROR_MESSAGE();
END CATCH
	

--Question 50:
---------------
--Explain the ACID properties of transactions. For each property, give an example from the
--university research database showing why it's important.

--Atomicity: All operations succeed or all fail (no partial updates).
	--Ex: Like Question 49 Must 3 opertions do if only one fail another operations rolled back.

--Consistency: Database remains in valid state before and after transaction
	--EX: Can't add leader to Project doesn't exists in Researcher Table.
	--	  Can't assign int to ResearcherId 

--Isolation: Transactions don't interfere with each other
	--EX: Two users updating the same project budget; isolation prevents lost or inconsistent updates.


--Durability: Committed changes survive system failures
	--EX: In Question 49 Once you perform a commit, you cannot undo it even if a failure occurs



--Question 51:
----------------
--Write the necessary GRANT statements to:
--● Give user 'ResearchManager' full permissions on all tables
--● Give user 'ResearchAssistant' SELECT and INSERT permissions only on Researcher and Publication tables
--● Give user 'DataAnalyst' SELECT permission on all views but no direct table access

CREATE LOGIN ResearchManager WITH PASSWORD = 'SecurePassTestUser4123!';
CREATE LOGIN ResearchAssistant WITH PASSWORD = 'SecurePassTestUser5456!';
CREATE LOGIN DataAnalyst WITH PASSWORD = 'SecurePassTestUser6789!';

CREATE USER ResearchManager FOR LOGIN ResearchManager;
CREATE USER ResearchAssistant FOR LOGIN ResearchAssistant;
CREATE USER DataAnalyst FOR LOGIN DataAnalyst;

CREATE ROLE FullAccessAllTable;
CREATE ROLE Assistant_Role;
CREATE ROLE Analyst_Role;

GRANT SELECT, Insert, UPDATE, DELETE, EXECUTE ON SCHEMA::dbo TO FullAccessAllTable;
GRANT SELECT, INSERT ON Researcher TO Assistant_Role;
GRANT SELECT, INSERT ON Publication TO Assistant_Role;

--Give Permission to each view manual 
GRANT SELECT ON OBJECT::dbo.ActiveProjectSummary TO Analyst_Role;
GRANT SELECT ON OBJECT::dbo.ResearcherPublicationStats TO Analyst_Role;


ALTER ROLE FullAccessAllTable ADD MEMBER ResearchManager;
ALTER ROLE Assistant_Role ADD MEMBER ResearchAssistant;
ALTER ROLE Analyst_Role ADD MEMBER DataAnalyst;




--Question 52:
---------------
--Write REVOKE statements to remove INSERT and UPDATE permissions from user 
--'ResearchAssistant' on the Researcher table. Explain the difference between GRANT, REVOKE, 
--and DENY. 

REVOKE INSERT, UPDATE ON Researcher FROM Assistant_Role;
--GRNAT: gives permissions to users or roles.
--REVOKE: Removes a granted permission.
--DENY: Blocks permission completely.


--Question 53:
---------------
--Compare these two queries for finding researchers who work on project 'P001': 
--Query A: 
	SELECT r.*  
	FROM Researcher r 
	WHERE r.Id IN (SELECT ResearcherId FROM WorksOn WHERE ProjectId = 'P001') 

--Query B: 
	SELECT r.*  
	FROM Researcher r 
	WHERE EXISTS (SELECT 1 FROM WorksOn w WHERE w.ResearcherId = r.Id AND w.ProjectId = 'P001') 

--Which query is likely to perform better and why? What factors influence the optimizer's choice? 
--Query A: Return All Researchers from table WorksOn achive the requirement then compare each researcher 
--         from Researcher table with returned researchers from inner query, that's leads to more time.
--Query B: Stop at first row satisfies the condition and don't waste time to return all rows.

--Result -> Query B is Better 
--Fators -> Query Stracture - Rows count - Indexes.

--Question 54:
---------------
--A query retrieving all projects with their researchers is running slowly: 
	SELECT p.Title, r.FirstName, r.LastName 
	FROM ResearchProject p LEFT JOIN WorksOn w  
	ON p.Id = w.ProjectId 
	LEFT JOIN Researcher r  
	ON w.ResearcherId = r.Id 
	WHERE p.Status = 'Active' 
	ORDER BY p.StartDate DESC 
--Suggest at least 3 different optimizations (indexes, query rewrite, etc.) that could improve 
--performance.

--Indexes: 
CREATE INDEX idx_WorksOn_ProjectId ON WorksOn(ProjectId);
CREATE INDEX idx_ResearchProject_Status ON ResearchProject(Status);

--Query rewrite:
SELECT p.Title, r.FirstName, r.LastName
FROM ResearchProject p
INNER JOIN WorksOn w ON p.Id = w.ProjectId
INNER JOIN Researcher r ON w.ResearcherId = r.Id
WHERE p.Status = 'Active'
ORDER BY p.StartDate DESC;

--Covering index to avoid extra table reads
CREATE INDEX idx_ResearchProject_Covering
ON ResearchProject(Status, StartDate, Title);

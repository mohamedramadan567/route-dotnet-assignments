 
CREATE TABLE AccountBalance ( 
    AccountId INT PRIMARY KEY, 
    AccountName VARCHAR(100), 
    Balance DECIMAL(18,2) CHECK (Balance >= 0), 
    LastUpdated DATETIME DEFAULT GETDATE() 
); 
GO 
 
CREATE TABLE TransferHistory ( 
    TransferId INT IDENTITY(1,1) PRIMARY KEY, 
    FromAccountId INT, 
    ToAccountId INT, 
    Amount DECIMAL(18,2), 
    TransferDate DATETIME DEFAULT GETDATE(), 
    Status VARCHAR(20), 
    ErrorMessage VARCHAR(500) 
); 
GO 
CREATE TABLE AuditTrail ( 
    AuditId INT IDENTITY(1,1) PRIMARY KEY, 
    TableName VARCHAR(100), 
    Operation VARCHAR(50), 
    RecordId INT, 
    OldValue VARCHAR(500), 
    NewValue VARCHAR(500), 
    AuditDate DATETIME DEFAULT GETDATE(), 
    UserName VARCHAR(100) DEFAULT SYSTEM_USER 
); 

GO -- Insert sample data 
INSERT INTO AccountBalance (AccountId, AccountName, Balance) 
VALUES  
(101, 'Checking Account', 10000.00), 
(102, 'Savings Account', 25000.00), 
(103, 'Investment Account', 50000.00), 
(104, 'Emergency Fund', 15000.00); 
GO 



--Question 01 : 
----------------
--Write a simple transaction that transfers $500 from Account 101 
--to Account 102. 
--Use BEGIN TRANSACTION and COMMIT TRANSACTION. 
--Display the balances before and after the transfer. 

GO
BEGIN TRANSACTION 
	BEGIN TRY

		DECLARE @Balance101 DECIMAL(18, 2), @Balance102 DECIMAL(18, 2)

		SELECT @Balance101 = Balance
		FROM AccountBalance
		WHERE AccountId = 101

		SELECT @Balance102 = Balance
		FROM AccountBalance
		WHERE AccountId = 102

		PRINT 'Before Transfer: Balance of Acc101 = ' + CAST(@Balance101 AS NVARCHAR) + ' Balance of Acc102 = ' +  
																				CAST(@Balance102 AS NVARCHAR)

		UPDATE AccountBalance
		SET Balance -= 500
		WHERE AccountId = 101;

		UPDATE AccountBalance
		SET Balance += 500
		WHERE AccountId = 102

		SELECT @Balance101 = Balance
		FROM AccountBalance
		WHERE AccountId = 101

		SELECT @Balance102 = Balance
		FROM AccountBalance
		WHERE AccountId = 102

		PRINT 'After Transfer: Balance of Acc101 = ' + CAST(@Balance101 AS NVARCHAR) + ' Balance of Acc102 = ' +  
																				CAST(@Balance102 AS NVARCHAR)
	
		INSERT INTO TransferHistory(FromAccountId, ToAccountId, Amount)
		VALUES(101, 102, 500);

		COMMIT TRANSACTION;

	END TRY
		
	BEGIN CATCH
		ROLLBACK TRANSACTION;

		INSERT INTO TransferHistory(FromAccountId, ToAccountId, Amount, ErrorMessage)
		VALUES(101, 102, 500, ERROR_MESSAGE());

		THROW;
	END CATCH




--Question 02 : 
----------------
--Write a transaction that attempts to transfer $1000 from Account 101 
--to Account 102, but then rolls it back using ROLLBACK TRANSACTION. 
--Verify that the balances remain unchanged.. 


BEGIN TRAN
	DECLARE @Blnc101 DECIMAL(18, 2), @Blnc102 DECIMAL(18, 2)

	SELECT @Blnc101 = Balance
	FROM AccountBalance
	WHERE AccountId = 101

	SELECT @Blnc102 = Balance
	FROM AccountBalance
	WHERE AccountId = 102

	PRINT 'Before Transfer: Balance of Acc101 = ' + CAST(@Blnc101 AS NVARCHAR) + ' Balance of Acc102 = ' +  
																			CAST(@Blnc102 AS NVARCHAR)

	UPDATE AccountBalance
	SET Balance -= 1000
	WHERE AccountId = 101;

	UPDATE AccountBalance
	SET Balance += 1000
	WHERE AccountId = 102

	ROLLBACK TRAN;

	SELECT @Blnc101 = Balance
	FROM AccountBalance
	WHERE AccountId = 101

	SELECT @Blnc102 = Balance
	FROM AccountBalance
	WHERE AccountId = 102

	PRINT 'After Rollback: Balance of Acc101 = ' + CAST(@Blnc101 AS NVARCHAR) + ' Balance of Acc102 = ' +  
																			CAST(@Blnc102 AS NVARCHAR)
		



--Question 03 : 
----------------
--Write a transaction that checks if Account 101 has sufficient 
--balance before transferring $2000 to Account 102. 
--If insufficient, rollback the transaction. 
--If sufficient, commit the transaction. 

GO
BEGIN TRANSACTION 
	DECLARE @Amount DECIMAL(18, 2);

	SELECT @Amount = Balance
	FROM AccountBalance
	WHERE AccountId = 101

	IF @Amount IS NULL
	BEGIN
		ROLLBACK;
		PRINT 'Account 101 not found';
	END	
	ELSE IF @Amount >= 2000
	BEGIN
		UPDATE AccountBalance
		SET Balance -= 2000
		WHERE AccountId = 101;

		UPDATE AccountBalance
		SET Balance += 2000
		WHERE AccountId = 102


		INSERT INTO TransferHistory(FromAccountId, ToAccountId, Amount)
		VALUES(101, 102, 2000);

		COMMIT TRANSACTION;
	END
	
	ELSE 
		BEGIN
			ROLLBACK TRANSACTION;
			PRINT 'Amount insufficient'
		END


--Question 04 : 
----------------
--Write a transaction using TRY...CATCH that transfers money 
--from Account 101 to Account 102. If any error occurs, 
--rollback the transaction and display the error message. 

GO
BEGIN TRY 
	BEGIN TRANSACTION

		UPDATE AccountBalance
		SET Balance -= 500
		WHERE AccountId = 101;

		UPDATE AccountBalance
		SET Balance += 500
		WHERE AccountId = 102

		INSERT INTO TransferHistory(FromAccountId, ToAccountId, Amount)
		VALUES(101, 102, 500);

	COMMIT TRANSACTION;

END TRY
		
BEGIN CATCH
	ROLLBACK TRANSACTION;
	PRINT CAST(ERROR_MESSAGE() AS VARCHAR);

	THROW;
END CATCH



--Question 05 : 
----------------
--Write a transaction that uses SAVE TRANSACTION to create 
--a savepoint after the first update. Then perform a second 
--update and rollback to the savepoint if an error occurs. 

GO
BEGIN TRY 
	BEGIN TRANSACTION

		UPDATE AccountBalance
		SET Balance -= 500
		WHERE AccountId = 101;

		SAVE TRANSACTION sv01;


		UPDATE AccountBalance
		SET Balance += 500
		WHERE AccountId = 102

		INSERT INTO TransferHistory(FromAccountId, ToAccountId, Amount)
		VALUES(101, 102, 500);

	COMMIT TRANSACTION;

END TRY
		
BEGIN CATCH
	ROLLBACK sv01;
	PRINT CAST(ERROR_MESSAGE() AS VARCHAR);

	COMMIT TRAN;
END CATCH


--Question 06 : 
----------------
--Write a transaction with nested BEGIN TRANSACTION statements. 
--Display @@TRANCOUNT at each level to demonstrate how it changes. 

PRINT '--- Nested Transactions Example ---';
PRINT 'TRANCOUNT at start: ' + CAST(@@TRANCOUNT AS VARCHAR);

BEGIN TRANSACTION;  
    PRINT 'After OUTER BEGIN, TRANCOUNT: ' + CAST(@@TRANCOUNT AS VARCHAR);

    UPDATE AccountBalance
    SET Balance = Balance - 1000
    WHERE AccountId = 103;

    BEGIN TRANSACTION; 
        PRINT 'After INNER BEGIN, TRANCOUNT: ' + CAST(@@TRANCOUNT AS VARCHAR);

        UPDATE AccountBalance
        SET Balance = Balance + 1000
        WHERE AccountId = 104;

    COMMIT TRANSACTION; 
    PRINT 'After INNER COMMIT, TRANCOUNT: ' + CAST(@@TRANCOUNT AS VARCHAR);

COMMIT TRANSACTION;   
PRINT 'After OUTER COMMIT, TRANCOUNT: ' + CAST(@@TRANCOUNT AS VARCHAR);


--Question 07 : 
----------------
--Demonstrate ATOMICITY by writing a transaction that performs 
--multiple updates. 
--Show that if one fails, all are rolled back.

BEGIN TRY
	BEGIN TRAN;
		UPDATE AccountBalance
		SET Balance = Balance - 100
		WHERE AccountId = 101;
	
		--Invalid Update
		UPDATE AccountBalance
		SET Balance = Balance / 0
		WHERE AccountId = 102

		COMMIT TRAN;
END TRY
BEGIN CATCH
	IF @@TRANCOUNT > 0
        ROLLBACK TRANSACTION;
	PRINT ERROR_MESSAGE();
END CATCH



--Question 08 : 
-----------------
--Demonstrate CONSISTENCY by writing a transaction that ensures 
--the total balance across all accounts remains constant. 
--Calculate total before and after transfer. 
BEGIN TRAN
	DECLARE @Amount01 DECIMAL(18, 2) = 0;

	SELECT @Amount01 += Balance
	FROM AccountBalance
	WHERE AccountId = 103

	SELECT @Amount01 += Balance
	FROM AccountBalance
	WHERE AccountId = 104

	PRINT 'Total Balance Before Update = ' + CAST(@Amount01 AS NVARCHAR)

	UPDATE AccountBalance
	SET Balance -= 500
	WHERE AccountId = 103;

	UPDATE AccountBalance
	SET Balance += 500
	WHERE AccountId = 104

	SET @Amount01 = 0;

	SELECT @Amount01 += Balance
	FROM AccountBalance
	WHERE AccountId = 103

	SELECT @Amount01 += Balance
	FROM AccountBalance
	WHERE AccountId = 104

	PRINT 'Total Balance After Update = ' + CAST(@Amount01 AS NVARCHAR)

COMMIT TRAN;


--Question 09 :  
----------------
--Demonstrate ISOLATION by setting different isolation levels 
--and explaining their effects. Use READ UNCOMMITTED, READ 
--COMMITTED, and SERIALIZABLE. 



--Question 10 :  
----------------
--Demonstrate DURABILITY by committing a transaction and 
--explaining that the changes will persist even after 
--system restart or failure. 

BEGIN TRAN
	
	UPDATE AccountBalance
	SET Balance -= 500
	WHERE AccountId = 103;

	UPDATE AccountBalance
	SET Balance += 500
	WHERE AccountId = 104

	
COMMIT TRAN; --Permanent: Once committed, changes survive system failures, crashes, power outages, and restarts.


--Question 11 : 
----------------
--Write a stored procedure that uses transactions to transfer 
-- money between two accounts. Include parameter validation, 
-- error handling, and proper transaction management. 

CREATE OR ALTER PROCEDURE sp_TransferMoney @FromAccountId INT, @ToAccountId   INT, @Amount DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @Amount <= 0
            THROW 50001, 'Amount must be greater than zero', 1;

        IF NOT EXISTS (SELECT 1 FROM AccountBalance WHERE AccountId = @FromAccountId)
            THROW 50002, 'Sender account does not exist', 1;

        IF NOT EXISTS (SELECT 1 FROM AccountBalance WHERE AccountId = @ToAccountId)
            THROW 50003, 'Receiver account does not exist', 1;

        DECLARE @Balance DECIMAL(18,2);

        SELECT @Balance = Balance
        FROM AccountBalance
        WHERE AccountId = @FromAccountId;

        IF @Balance < @Amount
            THROW 50004, 'Insufficient balance', 1;

        BEGIN TRANSACTION;

            UPDATE AccountBalance
            SET Balance = Balance - @Amount,
                LastUpdated = GETDATE()
            WHERE AccountId = @FromAccountId;

            UPDATE AccountBalance
            SET Balance = Balance + @Amount,
                LastUpdated = GETDATE()
            WHERE AccountId = @ToAccountId;

            INSERT INTO TransferHistory(FromAccountId, ToAccountId, Amount)
            VALUES(@FromAccountId, @ToAccountId, @Amount);

        COMMIT TRANSACTION;

        PRINT 'Transfer completed successfully';

    END TRY

    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END;


--Question 12 : 
----------------
--Write a transaction that uses multiple savepoints to handle 
--- a multi-step operation. If step 2 fails, rollback to savepoint 1. 
-- If step 3 fails, rollback to savepoint 2

BEGIN TRANSACTION;

    DECLARE @Blc DECIMAL(18,2);

    UPDATE AccountBalance
    SET Balance = Balance - 500
    WHERE AccountId = 101;
	
	SAVE TRANSACTION AfterDebit;
    
	UPDATE AccountBalance
    SET Balance = Balance + 300
    WHERE AccountId = 102;
	
	SAVE TRANSACTION AfterFirstTransfer;
    
	UPDATE AccountBalance
    SET Balance = Balance + 200
    WHERE AccountId = 103;
	
	SAVE TRANSACTION AfterSecondTransfer;
    
	SELECT @Blc = Balance
    FROM AccountBalance
    WHERE AccountId = 101;

    IF @Blc < 0
    BEGIN
        ROLLBACK TRANSACTION AfterFirstTransfer;

		   UPDATE AccountBalance
           SET Balance = Balance + 200
           WHERE AccountId = 101;

        SELECT @Blc = Balance
        FROM AccountBalance
        WHERE AccountId = 101;
        
		IF @Blc < 0
        BEGIN
            ROLLBACK TRANSACTION;
            RETURN;
        END
    END
COMMIT TRANSACTION;


--QUESTION 13 : 
----------------
--- Write a transaction that handles a deadlock scenario using 
--- TRY...CATCH. Retry the operation if a deadlock is detected. 

--انا فاهم Deadlock بس مش عارف اطبقه ازاي ككود

--QUESTION 14 : 
----------------
--Write a query to check the current transaction count    
--(@@TRANCOUNT) 
--and demonstrate how it changes within nested transactions. 

PRINT '--- Nested Transactions Example ---';
PRINT 'TRANCOUNT at start: ' + CAST(@@TRANCOUNT AS VARCHAR);

BEGIN TRANSACTION;  
    PRINT 'After OUTER BEGIN, TRANCOUNT: ' + CAST(@@TRANCOUNT AS VARCHAR);


    BEGIN TRANSACTION; 
        PRINT 'After INNER BEGIN, TRANCOUNT: ' + CAST(@@TRANCOUNT AS VARCHAR);

    COMMIT TRANSACTION; 
    PRINT 'After INNER COMMIT, TRANCOUNT: ' + CAST(@@TRANCOUNT AS VARCHAR);

COMMIT TRANSACTION;   
PRINT 'After OUTER COMMIT, TRANCOUNT: ' + CAST(@@TRANCOUNT AS VARCHAR);


--QUESTION 15 : 
----------------
--Write a transaction that logs all changes to the AuditTrail table. 
--Include before and after values for updates. 

SELECT * FROM AuditTrail

BEGIN TRAN;
	BEGIN TRY
		DECLARE @OldValue1 DECIMAL(18, 2), @NewValue1 DECIMAL(18, 2), @OldValue2 DECIMAL(18, 2), @NewValue2 DECIMAL(18, 2)

		SELECT @OldValue1 = Balance
		FROM AccountBalance
		WHERE AccountId = 101

		UPDATE AccountBalance
		SET Balance -= 100
		WHERE AccountId = 101

		SELECT @NewValue1 = Balance
		FROM AccountBalance
		WHERE AccountId = 101


		SELECT @OldValue2 = Balance
		FROM AccountBalance
		WHERE AccountId = 102

		UPDATE AccountBalance
		SET Balance += 100
		WHERE AccountId = 102

		SELECT @NewValue2 = Balance
		FROM AccountBalance
		WHERE AccountId = 102

		INSERT INTO AuditTrail(TableName, Operation, RecordId, OldValue, NewValue)
		VALUES('AccountBalance', 'Update', 101, @OldValue1, @NewValue1)

		INSERT INTO AuditTrail(TableName, Operation, RecordId, OldValue, NewValue)
		VALUES('AccountBalance', 'Update', 102, @OldValue2, @NewValue2)
		COMMIT TRAN;
	END TRY 
	BEGIN CATCH
		ROLLBACK TRAN;
	END CATCH
	

--QUESTION 16 : 
-----------------
--Write a transaction that demonstrates the difference between 
--COMMIT and ROLLBACK by creating two identical transactions, 
--committing one and rolling back the other. 

PRINT '===== BEFORE TRANSACTIONS =====';
SELECT AccountId, Balance 
FROM AccountBalance 
WHERE AccountId IN (101,102);

PRINT '===== TRANSACTION WITH COMMIT =====';

BEGIN TRANSACTION;
	UPDATE AccountBalance
	SET Balance -= 100
	WHERE AccountId = 101;

	UPDATE AccountBalance
	SET Balance += 100
	WHERE AccountId = 102;
COMMIT TRANSACTION;

PRINT 'After COMMIT';
SELECT AccountId, Balance 
FROM AccountBalance 
WHERE AccountId IN (101,102);


PRINT '===== TRANSACTION WITH ROLLBACK =====';

BEGIN TRANSACTION;
	UPDATE AccountBalance
	SET Balance -= 100
	WHERE AccountId = 101;

	UPDATE AccountBalance
	SET Balance += 100
	WHERE AccountId = 102;
ROLLBACK TRANSACTION;

PRINT 'After ROLLBACK';
SELECT AccountId, Balance 
FROM AccountBalance 
WHERE AccountId IN (101,102);


--QUESTION 17 : 
----------------
--Write a transaction that enforces a business rule: "Total 
--withdrawals in a single transaction cannot exceed $5000". 
--If violated, rollback the transaction. 

DECLARE @WithdrawAmount DECIMAL(18,2) = 6000;  
DECLARE @CurrentBalance DECIMAL(18,2);

BEGIN TRANSACTION

    SELECT @CurrentBalance = Balance
    FROM AccountBalance
    WHERE AccountId = 101;

    IF @WithdrawAmount > 5000
    BEGIN
        PRINT 'Business Rule Violation: Withdrawal exceeds $5000';
        ROLLBACK TRANSACTION;
        RETURN;
    END

    IF @CurrentBalance < @WithdrawAmount
    BEGIN
        PRINT 'Insufficient Balance';
        ROLLBACK TRANSACTION;
        RETURN;
    END

    UPDATE AccountBalance
    SET Balance -= @WithdrawAmount
    WHERE AccountId = 101;

    INSERT INTO TransferHistory(FromAccountId, ToAccountId, Amount)
    VALUES(101, NULL, @WithdrawAmount); 

COMMIT TRANSACTION;

BEGIN TRAN;
	

--QUESTION 18 :
----------------
--Write a transaction that uses explicit locking hints (WITH (UPDLOCK)) 
--to prevent concurrent modifications during a transfer. 

BEGIN TRY
    BEGIN TRANSACTION;

    DECLARE @Balance101 DECIMAL(18,2);

    SELECT @Balance101 = Balance
    FROM AccountBalance WITH (UPDLOCK)
    WHERE AccountId = 101;

    IF @Balance101 < 500
    BEGIN
        PRINT 'Insufficient funds';
        ROLLBACK TRANSACTION;
        RETURN;
    END

    SELECT Balance
    FROM AccountBalance WITH (UPDLOCK)
    WHERE AccountId = 102;

    UPDATE AccountBalance
    SET Balance -= 500
    WHERE AccountId = 101;

    UPDATE AccountBalance
    SET Balance += 500
    WHERE AccountId = 102;

    COMMIT TRANSACTION;
    PRINT 'Transfer Successful';

END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
    PRINT ERROR_MESSAGE();
END CATCH



--QUESTION 19 : 
---------------
--Write a comprehensive error handling transaction that catches 
--specific error numbers and handles them differently. 
--Handle: Constraint violations, insufficient funds, and general errors. 

BEGIN TRY
    BEGIN TRANSACTION;

    DECLARE @Amt DECIMAL(18,2) = 6000;
    DECLARE @Balnce DECIMAL(18,2);

    SELECT @Balnce = Balance
    FROM AccountBalance
    WHERE AccountId = 101;

    IF @Balnce < @Amt
        THROW 50001, 'Insufficient Funds', 1;

    UPDATE AccountBalance
    SET Balance -= @Amt
    WHERE AccountId = 101;

    UPDATE AccountBalance
    SET Balance += @Amt
    WHERE AccountId = 102;

    COMMIT TRANSACTION;
    PRINT 'Transfer Completed';

END TRY

BEGIN CATCH
    DECLARE @ErrNum INT = ERROR_NUMBER();

    ROLLBACK TRANSACTION;

    IF @ErrNum IN (2627, 547)  
        PRINT 'Constraint violation occurred';

    ELSE IF @ErrNum = 50001
        PRINT 'Transfer failed: Not enough balance';

    ELSE
        PRINT 'General Error: ' + ERROR_MESSAGE();
END CATCH



--QUESTION 20: 
--------------
--Write a transaction monitoring query that shows all active 
--transactions in the database, including their status, start time, 
--and session information.

SELECT 
    at.transaction_id,
    at.name AS TransactionName,
    at.transaction_begin_time,
    at.transaction_state,
    s.session_id,
    s.login_name,
    s.host_name,
    s.program_name,
    r.status
FROM sys.dm_tran_active_transactions at
JOIN sys.dm_tran_session_transactions st
    ON at.transaction_id = st.transaction_id
JOIN sys.dm_exec_sessions s
    ON st.session_id = s.session_id
LEFT JOIN sys.dm_exec_requests r
    ON s.session_id = r.session_id;

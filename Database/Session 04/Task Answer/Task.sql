-- ===============================================================================
-- Insert a new Manager into the Managers table,providing only FullName and Email.
-- ===============================================================================

Insert into Managers(FullName , Email)
Values ('Ahmed Khaled', 'AhmedKhaled@Bank.com');

-- ===============================================================================
-- Create a new table called ArchivedCustomers, then insert all customers born 
-- before 1990 using INSERT…SELECT.
-- ===============================================================================

CREATE TABLE ArchivedCustomers (
    CustomerNumber INT PRIMARY KEY,
    FullName NVARCHAR(100),
    DateOfBirth DATE,
    Email NVARCHAR(150),
    PhoneNumber NVARCHAR(20)
);

INSERT INTO ArchivedCustomers (CustomerNumber, FullName, DateOfBirth, Email, PhoneNumber)
SELECT CustomerNumber, FullName, DateOfBirth, Email, PhoneNumber
FROM Customers
WHERE DateOfBirth < '1990-01-01';

-- ===============================================================================
-- Delete all transactions where the Amount greater than 50,000.
-- ===============================================================================

DELETE FROM Transactions
WHERE Amount > 50000;

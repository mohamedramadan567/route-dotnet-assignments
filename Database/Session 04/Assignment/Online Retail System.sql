---------------------------------- Online Retail System ----------------------------------

Use StoreDB_ROUTE;

--#1. INSERT OPERATIONS : 
-------------------------

--● Insert a new Customer (FullName, PhoneNumber, Email, 
--ShippingAddress, RegistrationDate) 

Insert Into Customers
(FullName, PhoneNumber, Email, ShippingAddress, RegistrationDate)
Values
('Ahmed Ramzy', '12413452654', 'ahmedramzy23@gmail.com', 'Cairo', '12-14-2025');

--● Insert 3 new Suppliers 
Insert Into Suppliers Values
('Ramy Emam', 'Egypt', 'ramyemam12@gamil.com', 'Nasr City'),
('Bahaa Sultan', 'Oman', 'bahaasultan12@gamil.com', 'Muscat'),
('Emam Ashour', 'Egypt', 'emamashour12@gamil.com', 'Madinty');

--● Insert 2 Categories
INSERT INTO Categories 
VALUES
(3, 'Laptops', 'All kinds of laptops', NULL),
(4, 'Smartphones', 'All mobile phones', NULL);


--● Insert a Product but only (Name, UnitPrice) 
Insert Into Products(Name, UnitPrice)
Values ('Mouse', 200)

--● Create table ArchivedStock (TranId, ProductId, QuantityChange, 
--TranDate) Insert into ArchivedStock all StockTransactions before 2023
Create Table ArchivedStock
(
	TranId INT, 
	ProductId INT, 
	QuantityChange INT, 
	TranDate DATE
)

Insert Into ArchivedStock(TranId, ProductId, QuantityChange, TranDate)
Select TranId, ProductId, QuantityChange, TranDate
From StockTransactions
Where TranDate < '01/01/2023';



--#2. TEMPORARY TABLES 
----------------------

--● Create #CustomerOrders with (OrderId, CustomerId, TotalAmount) 
--Insert customers who made orders above 5000. 
Create Table #CustomerOrders
(
	OrderId INT, 
	CustomerId INT, 
	TotalAmount DECIMAL(10, 2)
)

INSERT INTO #CustomerOrders(OrderId, CustomerId, TotalAmount)
SELECT OrderId, CustomerId, TotalAmount
FROM Orders
Where TotalAmount > 5000


--● Create ##TopRatedProducts with (ProductId, Rating) Insert 
--products with rating ≥ 4.5 

Create Table ##TopRatedProducts
(
	ProductId INT, 
	Rating Decimal(2, 1) 
)

INSERT INTO ##TopRatedProducts(ProductId, Rating)
Select ProductId, Rating
From Reviews
Where Rating >= 4.5

--#3. UPDATE OPERATIONS 
------------------------
--●  Increase all UnitPrice by 10% for products under 100 EGP 
Update Products
Set UnitPrice+= UnitPrice * 0.1
Where UnitPrice < 100

--●  Update Order Status: If TotalAmount > 5000 → “Premium” Else → 
--“Standard” 
Update Orders
Set Status = CASE
	WHEN TotalAmount > 5000 THEN 'Premium'
	ELSE 'Standard'
END

--#4. DELETE OPERATIONS 
-------------------------

--● Delete a Review by ReviewId 

Delete Reviews
Where ReviewId = 3

--● Delete all Orders with Status = “Cancelled 
DELETE Orders
Where Status = 'Cancelled'


--● Delete OrderItems for a given OrderId
DELETE OrderItems 
Where OrderId = 3
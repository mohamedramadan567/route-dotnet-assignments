-- =============================================
-- CREATE DATABASE 
-- =============================================
CREATE DATABASE StoreDB_ROUTE;
USE StoreDB_ROUTE;

-- Suppliers
-- ============================
Create Table Suppliers
(
	SupplierId INT PRIMARY KEY IDENTITY,
	Name VARCHAR(100) NOT NULL,
	Country VARCHAR(50),
	Email VARCHAR(50) NOT NULL UNIQUE,
	Address VARCHAR(100)
)


-- Customers
-- ============================
Create Table Customers
(
	CustomerId INT PRIMARY KEY IDENTITY,
	FullName VARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(20),
	Email VARCHAR(50) UNIQUE,
	ShippingAddress VARCHAR(100),
	RegistrationDate DATE
)


-- Payments
-- ============================
Create Table Payments
(
	PaymentId INT Primary Key IDENTITY,
	Method VARCHAR(20) CHECK (Method In('Credit card', 'Wallet', 'Bank Transfer')),
	PaymentDate Date,
	Amount DECIMAL(10, 2),
	Status VARCHAR(20)
)


-- Orders
-- ============================
CREATE TABLE Orders
(
	OrderId INT PRIMARY KEY IDENTITY,
	Status VARCHAR(20) NOT NULL,
	TotalAmount DECIMAL(10, 2),
	OrderDate DATE, 
	CustomerId INT NOT NULL REFERENCES Customers(CustomerId)
)


-- Orders_Payments
-- ============================
CREATE TABLE Orders_Payments
(
	OrderId INT REFERENCES Orders(OrderId),
	PaymentId INT REFERENCES Payments(PaymentId),
	PRIMARY KEY(OrderId, PaymentId)
)


-- Shipments
-- ============================
CREATE TABLE Shipments
(
	ShipmentId INT PRIMARY KEY IDENTITY,
	[Status] VARCHAR(20) NOT NULL,
	DeliveryDate DATE,
	ShipmentDate DATE NOT NULL, 
	CarrierName VARCHAR(50),
	TrackingNumber VARCHAR(20),
	OrderId INT REFERENCES Orders(OrderId)
)


-- Categories
-- ============================
CREATE TABLE Categories
(
	CategoryId INT PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL,
	[Description] VARCHAR(100),
	MainCategory INT REFERENCES Categories(CategoryId)
)


-- Products
-- ============================
CREATE TABLE Products
(
	ProductId INT PRIMARY KEY IDENTITY,
	StockQuantity INT CHECK(StockQuantity >= 0),
	[Name] VARCHAR(50) NOT NULL,
	AddedDate Date,
	[Description] VARCHAR(200),
	UnitPrice DECIMAL(10, 2),
	CategoryId INT REFERENCES Categories(CategoryId)
)


-- StockTransactions
-- ============================
CREATE TABLE StockTransactions
(
	TranId INT PRIMARY KEY IDENTITY,
	TranDate Date,
	QuantityChange INT,
	Type VARCHAR(10) CHECK(Type IN ('in', 'out')),
	Reference INT,
	ProductId INT REFERENCES Products(ProductId)
)



-- Reviews
-- ============================
CREATE TABLE Reviews
(
	ReviewId INT PRIMARY KEY IDENTITY,
	Rating INT CHECK(Rating BETWEEN 1 AND 5),
	[Date] DATE,
	Comment VARCHAR(500),
	ProductId INT REFERENCES Products(ProductId),
	CustomerId INT REFERENCES Customers(CustomerId)
)


-- OrderItems
-- ============================
CREATE TABLE OrderItems
(
	OrderItemsId INT PRIMARY KEY IDENTITY,
	Quantity INT CHECK(Quantity >= 0),
	UnitPrice DECIMAL(10, 2),
	ProductId INT REFERENCES Products(ProductId),
	OrderId INT REFERENCES Orders(OrderId)
)


-- Products_Suppliers
-- ============================
CREATE TABLE Products_Suppliers
(
	SupplierId INT REFERENCES Suppliers(SupplierId),
	ProductId INT REFERENCES Products(ProductId),
	PRIMARY KEY(SupplierId, ProductId)
)


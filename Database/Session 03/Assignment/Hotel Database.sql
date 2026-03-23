-- =============================================
-- CREATE DATABASE 
-- =============================================
Create Database HotelDB_ROUTE;

Use HotelDB_ROUTE;


-- Reservations
-- ============================
Create Table Reservations
(
	ReservationId INT PRIMARY KEY IDENTITY,
	BookingDate DATE NOT NULL, 
	CheckinDate DATE,
	CheckoutDate DATE,
	ReservationStatus VARCHAR(20) CHECK (ReservationStatus IN ('Checked-in','Confirmed','Cancelled','Completed')),
	TotalPrice DECIMAL(8, 2),
	NumberOfAdults INT,
	NumberOfChildren INT
)


-- Guests
-- ============================
Create Table Guests
(
	GuestId INT PRIMARY KEY IDENTITY(100, 1),
	FullName VARCHAR(100) NOT NULL,
	Nationality VARCHAR(50) NOT NULL,
	PassportNumber VARCHAR(50) UNIQUE,
	DateOfBirth Date
)


-- Payments
-- ============================
Create Table Payments
(
	PaymentId INT Primary Key IDENTITY,
	Method VARCHAR(15) CHECK (Method In('Credit card', 'Cash', 'Online')),
	[Date] Date,
	Amount DECIMAL(10, 2),
	ConfirmationNumber VARCHAR(40)
)

-- Reservations_Payment
-- ============================
Create Table Reservations_Payment
(
	ReservationId INT References Reservations(ReservationId),
	PaymentId INT References Payments(PaymentId),
	PRIMARY KEY(ReservationId, PaymentId)
)


-- Reservations_Guest
-- ============================
Create Table Reservations_Guest
(
	ReservationId INT References Reservations(ReservationId),
	GuestId INT References Guests(GuestId),
	PRIMARY KEY(ReservationId, GuestId)
)


-- Guest_Contact_Details
-- ============================
Create Table Guest_Contact_Details
(
	GuestId INT References Guests(GuestId),
	Detail VARCHAR(100),
	PRIMARY KEY(GuestId, Detail)
)


-- Hotels --Missing ManagerId
-- ============================
Create Table Hotels
(
	HotelId INT PRIMARY KEY IDENTITY(1000, 10),
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(100),
	City VARCHAR(50),
	StarRating INT CHECK(StarRating Between 1 AND 5),
	ContactNumber VARCHAR(30)
)


-- Staff
-- ============================
Create Table Staff
(
	StaffId INT PRIMARY KEY IDENTITY,
	FullName VARCHAR(100) NOT NULL,
	Position VARCHAR(50),
	Salary DECIMAL(10, 2),
	HotelId INT NOT NULL REFERENCES Hotels(HotelId)
)


-- Services
-- ============================
Create Table Services
(
	ServiceId INT PRIMARY KEY IDENTITY(100, 10),
	ServiceName VARCHAR(100) NOT NULL,
	Charge DECIMAL(10, 2),
	RequestDate DATE,
	StaffId INT NOT NULL REFERENCES Staff(StaffId)	
)


-- ReservationService
-- ============================
Create Table ReservationService
(
	ServiceId INT References Services(ServiceId),
	ReservationId INT References Reservations(ReservationId),
	PRIMARY KEY(ReservationId, ServiceId)	
)


-- Rooms
-- ============================
Create Table Rooms 
(
	RoomNumber INT PRIMARY KEY,
	RoomType VARCHAR(10) CHECK(RoomType IN ('single', 'double', 'suite')),
	Capacity INT CHECK (Capacity > 0), 
	DailyRate DECIMAL(10,2) CHECK (DailyRate > 0),
	[Availability] BIT NOT NULL,
	HotelId INT NOT NULL REFERENCES Hotels(HotelId)
)

-- Amenities
-- ============================
Create Table Amenities
(
	RoomNumber INT References Rooms(RoomNumber),
	Amenity VARCHAR(100),
	PRIMARY KEY(RoomNumber, Amenity)
)


-- Reservations_Rooms
-- ============================
Create Table Reservations_Rooms
(
	ReservationId INT References Reservations(ReservationId),
	RoomNumber INT References Rooms(RoomNumber),
	PRIMARY KEY(ReservationId, RoomNumber)	
)



-- Add Hotel Column 
-- ============================
ALTER TABLE Hotels
ADD ManagerId INT UNIQUE REFERENCES Staff(StaffId)
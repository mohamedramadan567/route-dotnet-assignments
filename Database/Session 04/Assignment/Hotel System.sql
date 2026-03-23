---------------------------------- Hotel System ----------------------------------

Use HotelDB_ROUTE;

--#1. INSERT OPERATIONS :
----------------------------
--● Insert a Guest (FullName, Nationality, PassportNumber, 
--DateOfBirth) 
Insert Into Guests(FullName, Nationality, PassportNumber, DateOfBirth)
Values ('Mohamed Ramadan', 'Egyption', 'A12345678', '05/28/2005');

--● Insert multiple Guests in one statement 
Insert Into Guests (FullName, Nationality, PassportNumber, DateOfBirth)
Values
('Ahmed Ali',   'Egyptian', 'D12375679', '05/12/1998'),
('Mohamed Salah','Egyptian', 'B98765432', '11/25/1995'),
('John Smith',  'British',  'C45678901', '02/03/1990');



--#2. UPDATE OPERATIONS 
------------------------
--● Increase DailyRate by 15% for all suites 
Update Rooms
Set DailyRate += (DailyRate * 0.15)
Where RoomType = 'suite';


--● Update ReservationStatus: If CheckoutDate < GETDATE() → 
--'Completed' If CheckinDate > GETDATE() → 'Upcoming' Else → 
--'Active' 
Update Reservations
Set ReservationStatus = Case
	When CheckoutDate < GETDATE() THEN 'Completed'
	When CheckinDate > GETDATE() THEN 'Upcoming'
	ELSE 'Active'
END


--#3. DELETE OPERATIONS 
-------------------------

--● Delete Reservation_Guest for a reservation 
DELETE Reservations_Guest
Where ReservationId = 1;
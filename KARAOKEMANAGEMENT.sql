CREATE DATABASE KARAOKEMANAGEMENT
GO

USE KARAOKEMANAGEMENT
GO

CREATE TABLE Account
(
	AccountUsername VARCHAR(255) NOT NULL,
	AccountPassword VARCHAR(255) NOT NULL,
	AccountRole NVARCHAR(255) NOT NULL,
	PRIMARY KEY (AccountUsername)
)

CREATE TABLE Room
(
	RoomID VARCHAR(15) NOT NULL,
	RoomName NVARCHAR(255) NOT NULL,
	RoomType NVARCHAR(10) NOT NULL,
	RoomPrice FLOAT NOT NULL,
	Status NVARCHAR(255) NOT NULL,
	PRIMARY KEY (RoomID)
);

CREATE TABLE Staff
(
	StaffID VARCHAR(15) NOT NULL,
	StaffName NVARCHAR(255) NOT NULL,
	StaffPhone VARCHAR(13) NOT NULL,
	StaffUsername VARCHAR(255) NOT NULL,
	StaffRole NVARCHAR(255) NOT NULL,
	PRIMARY KEY (StaffID),
	FOREIGN KEY (StaffUsername) REFERENCES Account(AccountUsername) ON DELETE CASCADE
);

CREATE TABLE Service
(
	ServiceID VARCHAR(15) NOT NULL,
	ServiceName NVARCHAR(255) NOT NULL,
	ServicePrice FLOAT NOT NULL,
	ServiceQuantity INT NOT NULL,
	PRIMARY KEY (ServiceID)
);

CREATE TABLE Customer
(
	CustomerName NVARCHAR(255) NOT NULL,
	CustomerPhone VARCHAR(13) NOT NULL,
	CustomerUsername VARCHAR(255) NOT NULL,
	PRIMARY KEY (CustomerUsername),
	FOREIGN KEY (CustomerUsername) REFERENCES Account(AccountUsername) ON DELETE CASCADE
);

CREATE TABLE BookRoom
(
	BookID VARCHAR(15) NOT NULL,
	RoomID VARCHAR(15),
	TimeStart SMALLDATETIME NOT NULL,
	TimeEnd SMALLDATETIME,
	CustomerPhone VARCHAR(13) NOT NULL,
	CustomerUsername VARCHAR(255),
	Status NVARCHAR(255),
	PRIMARY KEY (BookID),
	FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
	FOREIGN KEY (CustomerUsername) REFERENCES Customer(CustomerUsername)
);

CREATE TABLE Bill
(
	BillID VARCHAR(255) NOT NULL,
	StaffID VARCHAR(15) NOT NULL,
	CustomerName NVARCHAR(255) NOT NULL,
	BillDate SMALLDATETIME,
	TotalPrice FLOAT,
	CustomerPhone VARCHAR(13) NOT NULL,
	CustomerUsername VARCHAR(255),
	BookID VARCHAR(15) NOT NULL,
	PRIMARY KEY (BillID),
	FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
	FOREIGN KEY (CustomerUsername) REFERENCES Customer(CustomerUsername),
	FOREIGN KEY (BookID) REFERENCES BookRoom(BookID) ON DELETE CASCADE
);

CREATE TABLE BillDetail
(
	BillID VARCHAR(255) NOT NULL,
	ServiceID VARCHAR(15) NOT NULL,
	ServiceQuantity INT NOT NULL,
	TotalServicePrice FLOAT NOT NULL,
	PRIMARY KEY (ServiceID, BillID),
	FOREIGN KEY (ServiceID) REFERENCES Service(ServiceID),
	FOREIGN KEY (BillID) REFERENCES Bill(BillID) ON DELETE CASCADE
);



INSERT INTO Account VALUES('admin', '123', 'admin')
GO

CREATE PROC checkLogin @userName VARCHAR(255), @passWord VARCHAR(255)
AS
BEGIN
	SELECT * FROM Account WHERE (AccountUsername = @userName AND AccountPassword = @passWord)
END
GO

CREATE PROC insertBillDetail @billID VARCHAR(255), @serviceID VARCHAR(255),  @quantity INT
AS
BEGIN
	DECLARE @isExistService INT
	DECLARE @serviceQuantity INT
	DECLARE @servicePrice FLOAT

	SELECT @servicePrice = ServicePrice FROM Service WHERE ServiceID = @serviceID

	SELECT @isExistService = COUNT(BillID), @serviceQuantity = ServiceQuantity FROM BillDetail WHERE BillID = @billID AND ServiceID = @serviceID GROUP BY BillID, ServiceQuantity

	IF (@isExistService > 0)
	BEGIN
		DECLARE @newQuantity INT = @serviceQuantity + @quantity

		IF (@newQuantity > 0)
		BEGIN
			UPDATE BillDetail SET ServiceQuantity = @newQuantity, TotalServicePrice = @newQuantity * @servicePrice WHERE BillID = @billID AND ServiceID = @serviceID
			UPDATE Service SET ServiceQuantity = ServiceQuantity - @quantity WHERE ServiceID = @serviceID
		END
		ELSE
		BEGIN
			DELETE FROM BillDetail WHERE BillID = @billID AND ServiceID = @serviceID
			UPDATE Service SET ServiceQuantity = ServiceQuantity + @serviceQuantity WHERE ServiceID = @serviceID
		END
	END
	ELSE
	BEGIN
		IF(@quantity > 0)
		BEGIN
			INSERT INTO BillDetail VALUES(@billID, @serviceID, @quantity, @servicePrice * @quantity)
			UPDATE Service SET ServiceQuantity = ServiceQuantity - @quantity WHERE ServiceID = @serviceID
		END
	END
END
GO

CREATE PROC getBillListByDateAndPage @timeStart SMALLDATETIME, @timeEnd SMALLDATETIME, @page INT
AS
BEGIN
	DECLARE @pageRows INT = 15
	DECLARE @selectRows INT = @pageRows
	DECLARE @exceptRows INT = (@page-1) * @pageRows

	SELECT TOP (@selectRows) BillID N'Mã hóa đơn', StaffID N'Mã nhân viên', b.BookID N'Mã đặt phòng', RoomID N'Mã phòng', BillDate N'Ngày lập', CustomerName N'Tên khách hàng', b.CustomerPhone N'Số điện thoại', 
			b.CustomerUsername N'Tài khoản', TimeStart N'Giờ đặt', TimeEnd N'Giờ kết thúc', TotalPrice N'Tổng tiền' 
	FROM Bill b INNER JOIN BookRoom bk ON b.BookID = bk.BookID
	WHERE Status = N'Đã thanh toán' AND TimeStart >= @timeStart AND TimeEnd <= @timeEnd 
			AND BillID NOT IN (SELECT TOP (@exceptRows) BillID 
								FROM Bill b INNER JOIN BookRoom bk ON b.BookID = bk.BookID
								WHERE Status = N'Đã thanh toán' AND TimeStart >= @timeStart AND TimeEnd <= @timeEnd ORDER BY TimeStart ASC) ORDER BY TimeStart ASC

END
GO


CREATE PROC getBillListByDate @timeStart SMALLDATETIME, @timeEnd SMALLDATETIME
AS
BEGIN
	SELECT BillID N'Mã hóa đơn', StaffID N'Mã nhân viên', b.BookID N'Mã đặt phòng', RoomID N'Mã phòng', BillDate N'Ngày lập', CustomerName N'Tên khách hàng', b.CustomerPhone N'Số điện thoại', 
			b.CustomerUsername N'Tài khoản', TimeStart N'Giờ đặt', TimeEnd N'Giờ kết thúc', TotalPrice N'Tổng tiền' 
	FROM Bill b INNER JOIN BookRoom bk ON b.BookID = bk.BookID
	WHERE Status = N'Đã thanh toán' AND TimeStart >= @timeStart AND TimeEnd <= @timeEnd 
END
GO
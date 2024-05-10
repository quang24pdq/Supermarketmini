--Tao database
IF EXISTS (
    SELECT name FROM sys.databases 
    WHERE name = N'MarketMiniManager'
)
Drop database MarketMiniManager

Create database MarketMiniManager
GO
use MarketMiniManager
GO

--Tao bang loai san pham
create table ProductType(
	TypeID varchar(10) not null,
	[Name] nvarchar(50) not null,
	isDeleted tinyint not null default(1),
	primary key (TypeID)
)
GO

-- Rot du lieu vao bang loai san pham
insert into ProductType(TypeID,Name)
values 
	('LSP1',N'Bánh'),
	('LSP2',N'Mì'),
	('LSP3',N'Cafe'),
	('LSP4',N'Trà'),
	('LSP5',N'Dầu gội'),
	('LSP6',N'Sữa tắm'),
	('LSP7',N'Đồ uống'),
	('LSP8',N'Đồ ăn đóng hộp');
GO

--Tao bang nhan vien
create table Employee(
	EmployeeID varchar(10) not null,
	[Name] nvarchar(50) not null,
	[Address] nvarchar(50) not null,
	PhoneNumber varchar(50) not null,
	Email varchar(50) not null,
	Sex nvarchar(10) not null,
	UserName varchar(50) not null,
	[Password] varchar(50) not null,
	BirthDate DATE,
	RoleID varchar(10),
	isDeleted tinyint not null default(1),
	primary key (EmployeeID)
)
GO

-- Rot du lieu vao bang nhan vien
insert into Employee(EmployeeID,Name,Password,Sex,BirthDate,PhoneNumber,Email,Address,UserName, RoleID)
values
	('E0001',N'Nguyễn Văn A','1',N'Nam','2003-01-01','0912312371','NguyenVanA@gmail.com',N'123 An Dương Vương, Phường 3, Quận 2, TPHCM','admin', 'R0001'),
	('E0002',N'Nguyễn Văn B','1',N'Nữ','2003-02-15','0914736281','NguyenVanB@gmail.com',N'456 Hoàng Hoa Thám, Phường 1, Quận Bình Tân, TPHCM','E0002', 'R0002'),
	('E0003',N'Nguyễn Văn C','1',N'Nam','2003-08-30','0936271371','NguyenVanC@gmail.com',N'789 Nam Kỳ Khởi Nghĩa, Phường 9, Quận 8, TPHCM','E0003', 'R0003');
GO

--Tao bang san pham
create table Product(
	ProductID varchar(10) not null,
	[Name] nvarchar(50) not null,
	TypeID varchar(10) not null,
	Quantity int not null,
	CurrentPrice float(50) not null,
	[Description] nvarchar(100),
	Unit nvarchar(20) not null,
	PromotionID varchar(10),
	isDeleted tinyint not null default(1),
	
	primary key (ProductID)
)
GO

-- Rot du lieu bang san pham	
insert into Product(ProductID,[Name],TypeID,Quantity,CurrentPrice,[Description],Unit, PromotionID)
values
	('P0001',N'Mì Kokomi','LSP2',99,5000,N'Mì Kokomi tôm chua cay 100g',N'Gói', 'PM0001'),
	('P0002',N'Sữa Milo','LSP7',98,4000,N'Sữa Milo vị ca cao lúa mạch 100ml',N'Hộp','PM0001'),
	('P0003',N'Bánh Slay','LSP1',97,9000,N'Bánh Slay khoai tây chiên vị tảo',N'Gói','PM0001'),
	('P0004',N'Mì Hảo hảo','LSP2',0,2500,N'Mì hảo hảo lẩu thái tôm',N'Gói', 'PM0003'),
	('P0005',N'Cafe G7','LSP3',0,58000,N'Hộp Cafe G7',N'Hộp 336g', 'PM0004'),
	('P0006',N'Cafe Trung Nguyên','LSP3',0,53000,N'Hộp Cafe Trung Nguyên',N'Hộp 300g', 'PM0002'),
	('P0007',N'Trà Lipton','LSP4',0,37500,N'Hộp Trà Lipton 16 gói',N'Hộp 300g', 'PM0004'),
	('P0008',N'Trà Cozy','LSP4',0,31000,N'Hộp Trà Cozy túi lọc vị gừng',N'Hộp 400g', 'PM0001'),
	('P0009',N'Dầu gội Clear Men','LSP5',0,193000,N'Dầu gội Clear Men than hoạt tính',N'Chai 900g', 'PO0004'),
	('P0010',N'Dầu gội Head And Shoulders','LSP5',0,148000,N'Dầu gội Head And Shoulders bạc hà mát lạnh',N'Chai 700g', 'PM0001'),
	('P0011',N'Sữa tắm Lifebuoy','LSP6',0,158000,N'Sữa tắm Lifebuoy hương khổ qua',N'Chai 800g', 'PM0001'),
	('P0012',N'Sữa tắm Nerman','LSP6',0,205000,N'Sữa tắm Nerman hương nước hoa cao cấp 3 in 1',N'Chai 350g', 'PM0001'),
	('P0013',N'Redbull','LSP7',0,15000,N'Redbull bò thái',N'Lon', 'PM0001'),
	('P0014',N'Sting','LSP7',0,10000,N'Nước tăng lực Sting Dâu',N'Chai', 'PM0001'),
	('P0015',N'Pate Cột Đèn','LSP8',0,25000,N'Pate Cột Đèn Hải Phòng',N'Hộp', 'PM0002'),
	('P0016',N'Khô bò Tasty Food','LSP8',0,171000,N'Khô bò Củ Chi Tasty Food miếng mềm',N'Hũ 500g', 'PM0001');
GO

--Tao bang khuyen mai
create table Promotion(
	PromotionID varchar(10) not null,
	[Name] nvarchar(50) not null,
	StartDate datetime not null,
	EndDate datetime not null,
	Discount float(50) not null,
	[Status] nvarchar(50) not null,
	isDeleted tinyint not null default(1),
	primary key (PromotionID)
)
GO

-- Rot du lieu vao bang khuyen mai
INSERT INTO Promotion (PromotionID, [Name], StartDate, EndDate, Discount, [Status])
VALUES
    ('PM0001', N'Khuyến mãi giờ vàng', '2023-9-24', '2023-11-24', 10,N'Không hoạt động'),
    ('PM0002', N'Khuyến mãi lễ 2/9', '2023-08-30', '2023-09-03', 20, N'Không hoạt động'),
    ('PM0003', N'Khuyến mãi điểm tích luỹ', '2023-03-01', '2040-03-01', 10, N'Không hoạt động'),
	('PM0004', N'Khuyến mãi cuối năm', '2023-12-01', '2023-12-30', 5, N'Không hoạt động');
GO

--Tao bang khach hang
create table Customer(
	CustomerID varchar(10) not null,
	[Name] nvarchar(50) not null,
	PhoneNumber varchar(50) not null,
	Sex nvarchar(10) not null,
	Point int default(0),
	isDeleted tinyint not null default(1),
	primary key (CustomerID)
)
GO

-- Rot du lieu vao bang khach hang
INSERT INTO Customer (CustomerID, [Name], PhoneNumber, Sex)
VALUES
    ('C0001', N'Trần Thị D', '0123456789', N'Nữ'),
    ('C0002', N'Lê Hữu E', '09876543321', N'Nam'),
    ('C0003', N'Võ Thị Vân F', '0206521773', N'Nữ'),
	('C0004', N'Trần Thị Lan Anh', '03748457125', N'Nữ'),
    ('C0005', N'Nguyễn Trí Dũng', '09876543321', N'Nam'),
    ('C0006', N'Lê Trung Trực', '0206521773', N'Nam'),
	('C0007', N'Nguyễn Thị Ngọc', '0123456789', N'Nữ'),
    ('C0008', N'Phạm Văn B', '09876543321', N'Nam'),
    ('C0009', N'Trần Thị Thu Hương', '0206521773', N'Nữ'),
    ('C0010', N'Lê Văn Đức', '03748457125', N'Nam'),
    ('C0011', N'Nguyễn Thị An', '09876543321', N'Nữ'),
    ('C0012', N'Đỗ Văn Tùng', '0206521773', N'Nam'),
    ('C0013', N'Phạm Thị Lan', '0123456789', N'Nữ'),
    ('C0014', N'Hoàng Văn Phú', '09876543321', N'Nam'),
    ('C0015', N'Nguyễn Thị Trang', '0206521773', N'Nữ'),
    ('C0016', N'Trần Văn Tú', '03748457125', N'Nam'),
    ('C0017', N'Nguyễn Thị Hà', '09876543321', N'Nữ'),
    ('C0018', N'Phan Văn Thành', '0206521773', N'Nam'),
    ('C0019', N'Lê Thị Mai', '0123456789', N'Nữ'),
    ('C0020', N'Trần Văn Cường', '09876543321', N'Nam'),
    ('C0021', N'Vũ Thị Bình', '0206521773', N'Nữ'),
    ('C0022', N'Lê Văn Quốc', '03748457125', N'Nam'),
    ('C0023', N'Nguyễn Thị Ngân', '09876543321', N'Nữ'),
    ('C0024', N'Đặng Văn Thắng', '0206521773', N'Nam'),
    ('C0025', N'Bùi Thị Hương', '0123456789', N'Nữ');

GO

--Tao bang hoa don
create table Bill(
	BillID varchar(10) not null,
	[Date] datetime not null,
	EmployeeID varchar(10) not null,
	CustomerID varchar(10),
	EstimatedPrice float(50) not null default(0),
	ReducePrice float(50) not null default(0),
	TotalPrice float(50) not null default(0),
	[Status] tinyint not null default(0),
	isDeleted tinyint not null default(1),
	primary key(BillID)
)
GO


-- Rot du lieu vao bang hoa don
INSERT INTO Bill (BillID, [Date], EmployeeID, CustomerID, EstimatedPrice, ReducePrice, TotalPrice, [Status])
VALUES
    ('B0001', '2023-09-23', 'E0002', 'C0001', 40000, 0, 40000, 1);
GO

--Tao bang nha cung cap
create table Supplier(
	SupplierID varchar(50) not null,
	[Name] nvarchar(50) not null,
	[Address] nvarchar(100) not null,
	PhoneNumber varchar(50) not null,
	Email varchar(50) not null,
	isDeleted tinyint not null default(1),
	primary key (SupplierID)
)
GO

-- Rot du lieu vao bang nha cung cap


--Tao bang phieu nhap
create table PurchaseOrder(
	OrderID varchar(10) not null,
	EmployeeID varchar(10) not null,
	SupplierID varchar(50) not null,
	importDate datetime not null,
	TotalPrice float(50) not null,
	[Status] tinyint not null default(0),
	isDeleted tinyint not null default(1),
	primary key(OrderID)
)
GO

-- Rot du lieu vao bang phieu nhap
INSERT INTO PurchaseOrder (OrderID, EmployeeID, SupplierID, importDate, TotalPrice, [Status])
VALUES
    ('PO0001', 'E0003', 'S0001', '2023-01-01', 1200000, 1);
GO

--Tao bang chi tiet hoa don
create table DetailBill(
	BillID varchar(10) not null,
	ProductID varchar(10) not null,
	OrderID varchar(10) not null,
	PromotionID nvarchar(50),
	SalePrice float(50) not null,
	Quantity int not null,
	primary key (BillID,ProductID,OrderID)
)
GO

-- Rot du lieu vao bang chi tiet hoa don
INSERT INTO DetailBill (BillID, ProductID, OrderID, PromotionID, SalePrice, Quantity)
VALUES
    ('B0001', 'P0001', 'PO0001', 'PM0004', 5000, 1),
    ('B0001', 'P0002', 'PO0001', 'PM0004', 8000, 2),
    ('B0001', 'P0003', 'PO0001', 'PM0004', 27000, 3);
GO

-- Tao bang chi tiet phieu nhap
create table DetailPurchaseOrder(
	ProductID varchar(10) not null,
	OrderID varchar(10) not null,
	Quantity int not null,
	PurchasePrice float(50) not null,
	primary key (ProductID,OrderID)
)
GO

-- Rot du lieu vao bang chi tiet phieu nhap
INSERT INTO DetailPurchaseOrder (ProductID, OrderID, Quantity, PurchasePrice)
VALUES
    ('P0001', 'PO0001', 100, 3000),
    ('P0002', 'PO0001', 100, 2000),
    ('P0003', 'PO0001', 100, 7000);
GO

--Tao bang san pham ma nha cung cap cung cap
create table SupplierProduct(
	SupplierID varchar(50) not null,
	ProductID varchar(10) not null,
	SupplyStartDate datetime not null,
	primary key (SupplierID,ProductID)
)
GO

-- Rot du lieu vao bang san pham ma nha cung cap cung cap
INSERT INTO SupplierProduct (SupplierID, ProductID, SupplyStartDate)
VALUES
    ('S0001', 'P0001', '2022-01-01'),
    ('S0001', 'P0002', '2022-02-01'),
    ('S0001', 'P0003', '2022-03-01');
GO

--Tao bang hang ton kho
create table Inventory(
	ProductID varchar(10) not null,
	OrderID varchar(10) not null,
	CurrentQuantity int not null,
	isDisplayed tinyint not null default(1),
	primary key (OrderID,ProductID)
)
GO

--Rot du lieu vao bang hang ton kho
INSERT INTO Inventory (ProductID, OrderID, CurrentQuantity)
VALUES
	('P0001', 'PO0001', 99),
    ('P0002', 'PO0001', 98),
    ('P0003', 'PO0001', 97);
GO


--Tao bang quan ly quyen
create table [Role](
	RoleID varchar(10) not null,
	[Name] nvarchar(50) not null,
	[Description] nvarchar(100),
	isDeleted tinyint not null default(1),
	primary key (RoleID)
)
GO

--Rot du lieu vao bang quan ly quyen
INSERT INTO Role (RoleID, Name, Description)
VALUES
    ('R0001', N'Admin', N'Cho phép thực hiện đa số chức năng của hệ thống trừ bán hàng.'),
    ('R0002', N'Nhân viên bán hàng', N'Cho phép Quản lý bán hàng, quản lý khách hàng và sản phẩm.'),
    ('R0003', N'Nhân viên thủ kho', N'Cho phép quản lý kho như nhập, xuất hàng tồn kho.');
GO

-- Tao ban chuc nang cho quyen
create table Functions(
	FunctionID varchar(10) not null,
	[Name] nvarchar(50) not null,
	[Description] nvarchar(100),
	primary key (FunctionID)
)
GO

--Rot du lieu cho bang chuc nang cho quyền
INSERT INTO Functions (FunctionID, Name, Description)
VALUES
    ('F0001', N'Quản lý sản phẩm', N'Tham gia quản lý sản phẩm như thêm, xoá,... sản phẩm.'),
    ('F0002', N'Quản lý loại sản phẩm', N'Quản lý loại sản phẩm.'),
    ('F0003', N'Quản lý khách hàng', N'Tham gia quản lý thông tin khách hàng.'),
    ('F0004', N'Quản lý nhập hàng', N'Tham gia quản lý nhập hàng.'),
    ('F0005', N'Quản lý bán hàng', N'Tham gia bán hàng như tạo hoá đơn và thanh toán.'),
    ('F0006', N'Quản lý nhân viên', N'Tham gia quản lý thông tin nhân viên và tạo tài khoản.'),
    ('F0007', N'Quản lý quyền', N'Tham gia quản lý quyền.'),
    ('F0008', N'Quản lý chương trình khuyến mãi', N'Tham gia quản lý chương trình khuyến mãi.'),
    ('F0009', N'Quản lý nhà cung cấp', N'Tham gia quản lý thông tin nhà cung cấp.'),
    ('F0010', N'Thống kê', N'Thống kê.');
GO

-- Tao bang chuc nang cho quyen quyen nhan vien
create table RoleFunction(
	RoleID varchar(10) not null,
	FunctionID varchar(10) not null,
	primary key(FunctionID,RoleID)
)
GO

--Rot du lieu vao bang chuc nang cho quyen cua nhan vien
INSERT INTO RoleFunction (RoleID, FunctionID)
VALUES
	('R0001', 'F0006'),
    ('R0001', 'F0007'),
    ('R0001', 'F0008'),
	('R0001', 'F0010'),
    ('R0002', 'F0001'),
    ('R0002', 'F0002'),
    ('R0002', 'F0003'),
    ('R0002', 'F0005'),
    ('R0003', 'F0004'),
    ('R0003', 'F0009');
GO

--Them khoa ngoai cho tung bang
--Bang nhan vien
alter table Employee
add constraint fk_Employee_Role foreign key (RoleID) references [Role] (RoleID)
GO

--Bang san pham
alter table Product
add constraint fk_Product_ProductType foreign key (TypeID) references ProductType (TypeID)
GO
--alter table Product
--add constraint fk_Product_Promotion foreign key (PromotionID) references Promotion (PromotionID)
--GO

--Bang Bill
alter table Bill
add constraint fk_Bill_Customer foreign key (CustomerID) references Customer (CustomerID)
GO
alter table Bill
add constraint fk_Bill_Employee foreign key (EmployeeID) references Employee (EmployeeID)
GO

--Bang phieu nhap
alter table PurchaseOrder
add constraint fk_PurchaseOrder_Supplier foreign key (SupplierID) references Supplier (SupplierID)
GO
alter table PurchaseOrder
add constraint fk_PurchaseOrder_Employee foreign key (EmployeeID) references Employee (EmployeeID)
GO

--Bang Chi tiet hoa don
alter table DetailBill
add constraint fk_DetailBill_PurchaseOrder foreign key (OrderID) references PurchaseOrder (OrderID)
GO
alter table DetailBill
add constraint fk_DetailBill_Product foreign key (ProductID) references Product (ProductID)
GO
alter table DetailBill
add constraint fk_DetailBill_Bill foreign key (BillID) references Bill (BillID)
GO

--Bang chi tiet phieu nhap
alter table DetailPurchaseOrder
add constraint fk_DetailPurchaseOrder_PurchaseOrder foreign key (OrderID) references PurchaseOrder (OrderID)
GO
alter table DetailPurchaseOrder
add constraint fk_DetailPurchaseOrder_Product foreign key (ProductID) references Product (ProductID)
GO

--Bang San pham ma nha cung cap cung cap
alter table SupplierProduct
add constraint fk_SupplierProduct_Supplier foreign key (SupplierID) references Supplier (SupplierID)
GO
alter table SupplierProduct
add constraint fk_SupplierProduct_Product foreign key (ProductID) references Product (ProductID)
GO

--Bang ton kho
alter table Inventory
add constraint fk_Inventory_PurchaseOrder foreign key (OrderID) references PurchaseOrder (OrderID)
GO
alter table Inventory
add constraint fk_Inventory_Product foreign key (ProductID) references Product (ProductID)
GO

-- bang chuc nang cua quyen
alter table RoleFunction
add constraint fk_RoleFunction_Role foreign key (RoleID) references Role (RoleID)
GO
alter table RoleFunction
add constraint fk_RoleFunction_Functions foreign key (FunctionID) references Functions (FunctionID)
GO

-- Tạo các procedures

-- Thien ======================================================================================================

-- Select * from ProductType
CREATE PROCEDURE SelectAllFromProductType
AS
BEGIN
    SELECT * FROM ProductType
END;
GO

-- Insert Into ProductType
CREATE PROCEDURE InsertIntoProductType
    @TypeID varchar(10),
	@Name nvarchar(50)
AS
BEGIN
    INSERT INTO ProductType(TypeID, [Name])
    VALUES (@TypeID, @Name)
END;
GO

-- Delete ProductType
CREATE PROCEDURE DeleteProductType
    @TypeID varchar(10)
AS
BEGIN
	UPDATE ProductType SET isDeleted = 0 WHERE TypeID = @TypeID
END;
GO

-- Update ProductType
CREATE PROCEDURE UpdateProductType
    @TypeID varchar(10),
	@Name nvarchar(50)
AS
BEGIN
	UPDATE ProductType SET [Name] = @Name WHERE TypeID = @TypeID
END;
GO

-- Đếm số account
CREATE PROCEDURE CountAccount
    @userName varchar(50),
    @Password varchar(50)
AS
BEGIN
    SELECT COUNT(*) FROM Employee
    WHERE UserName COLLATE SQL_Latin1_General_CP1_CS_AS = @userName 
    AND [Password] = @Password
END;
GO


-- Lấy các chức năng từ account
CREATE PROCEDURE SelectFunctionNameFromAccount
    @userName varchar(50),
	@Password varchar(50)
AS
BEGIN
	SELECT Functions.[Name]
	FROM Employee, [Role], RoleFunction, Functions
    Where Employee.RoleID = [Role].RoleID
    AND [Role].RoleID = RoleFunction.RoleID
    AND RoleFunction.FunctionID = Functions.FunctionID
    AND UserName = @userName AND [Password] = @Password
    AND Employee.IsDeleted = 1
END;
GO

-- Lấy thông tin tài khoản từ username
CREATE PROCEDURE SelectInfoFromAccount
    @userName varchar(50)
AS
BEGIN
	SELECT EmployeeID, [Name], [Address], PhoneNumber, Email
    FROM Employee Where UserName = @userName
    AND Employee.IsDeleted = 1
END;
GO

-- Cập nhật thông tin tài khoản
CREATE PROCEDURE UpdateAccountInfor
    @EmployeeId varchar(10),
	@address nvarchar(50),
	@phone varchar(50),
	@email varchar(50)
AS
BEGIN
	UPDATE Employee SET [Address] = @address, PhoneNumber = @phone, Email = @email
    WHERE EmployeeID = @EmployeeId
END;
GO

-- Cập nhật mật khẩu tài khoản
CREATE PROCEDURE UpdateAccountPassword
    @EmployeeId varchar(10),
	@Password varchar(50)
AS
BEGIN
	UPDATE Employee SET Password = @Password
    WHERE EmployeeID = @EmployeeId
END;
GO

-- Lấy tất cả thông tin hóa đơn
CREATE PROCEDURE SelectAllBills
AS
BEGIN
	SELECT Bill.BillID, Bill.[Date], Bill.EmployeeID,
    Employee.[Name] AS EmployeeName, Bill.CustomerID,
    Customer.[Name] AS CustomerName, 
    Bill.EstimatedPrice, Bill.ReducePrice, Bill.TotalPrice, Bill.[Status], Bill.isDeleted
	FROM Bill INNER JOIN Employee
	ON Bill.EmployeeID = Employee.EmployeeID LEFT JOIN Customer
	ON Bill.CustomerID = Customer.CustomerID
END;
GO
--Lấy tất cả thông tin nhà cung cấp
CREATE PROCEDURE SelectAllSupplier
AS
BEGIN
	SELECT 
	Supplier.SupplierID AS ID,
	Supplier.[Name] AS TÊN ,
	Supplier.[Address] [Địa chỉ],
	Supplier.PhoneNumber AS [Số điện thoại],
	Supplier.Email
	FROM Supplier 
	WHERE Supplier.isDeleted=1;
END;
GO
--Lấy toàn bộ thông tin nhà cung cấp 
CREATE PROCEDURE SelectAllSupplierWithoutIsDeleted
AS
BEGIN
	SELECT 
	Supplier.SupplierID AS ID,
	Supplier.[Name] AS TÊN ,
	Supplier.[Address] [Địa chỉ],
	Supplier.PhoneNumber AS [Số điện thoại],
	Supplier.Email
	FROM Supplier 
END;
GO
--Lấy thông tin chi tiết nhà cung cấp
CREATE PROCEDURE SelectAllSupplierDetail
	@ID varchar(10)
AS
BEGIN
	SELECT
	SupplierProduct.ProductID AS ID,
	SupplierProduct.SupplyStartDate AS [Ngày nhập],
	Product.[Name],
	Product.CurrentPrice

	FROM 
	(Supplier INNER JOIN SupplierProduct ON Supplier.SupplierID =SupplierProduct.SupplierID) INNER JOIN 
	Product ON SupplierProduct.ProductID=Product.ProductID

	WHERE SupplierProduct.SupplierID=@ID
END;
GO
--Tìm thông tin theo ID nhà cung cấp
Create PROCEDURE FindSupplierWithID
	@ID varchar(10)
AS
BEGIN
	SELECT
	Supplier.SupplierID AS ID,
	Supplier.[Name] AS TÊN ,
	Supplier.[Address] [Địa chỉ],
	Supplier.PhoneNumber AS [Số điện thoại],
	Supplier.Email
	FROM Supplier 
	WHERE Supplier.SupplierID=@ID
END;
GO
--Tìm thông tin theo tên nhà cung cấp
CREATE PROCEDURE FindSupplierWithName
	@Name varchar(50)
AS 
BEGIN
	SELECT
	Supplier.SupplierID AS ID,
	Supplier.[Name] AS TÊN ,
	Supplier.[Address] [Địa chỉ],
	Supplier.PhoneNumber AS [Số điện thoại],
	Supplier.Email
	FROM Supplier 
	WHERE Supplier.[Name]=@Name
END;
GO
--Tìm thông tin theo địa chỉ nhà cung cấp
CREATE PROCEDURE FindSupplierWithAddress
	@Address varchar(50)
AS 
BEGIN
	SELECT
	Supplier.SupplierID AS ID,
	Supplier.[Name] AS TÊN ,
	Supplier.[Address] [Địa chỉ],
	Supplier.PhoneNumber AS [Số điện thoại],
	Supplier.Email
	FROM Supplier 
	WHERE Supplier.[Address]=@Address
END;
GO
--Tìm kiếm theo số điện thoại nhà cung cấp
CREATE PROCEDURE FindSupplierWithPhoneNumber
	@PhoneNumber varchar(50)
AS 
BEGIN
	SELECT
	Supplier.SupplierID AS ID,
	Supplier.[Name] AS TÊN ,
	Supplier.[Address] [Địa chỉ],
	Supplier.PhoneNumber AS [Số điện thoại],
	Supplier.Email
	FROM Supplier 
	WHERE Supplier.PhoneNumber=@PhoneNumber
END;
GO
--Tìm kiếm theo email nhà cung cấp
CREATE PROCEDURE FindSupplierWithEmail
	@Email varchar(50)
AS 
BEGIN
	SELECT
	Supplier.SupplierID AS ID,
	Supplier.[Name] AS TÊN ,
	Supplier.[Address] [Địa chỉ],
	Supplier.PhoneNumber AS [Số điện thoại],
	Supplier.Email
	FROM Supplier 
	WHERE Supplier.Email=@Email
END;
GO
--Thêm nhà cung cấp 
CREATE PROCEDURE AddSupplier
	@ID varchar(50),
	@Name nvarchar(50),
	@Address nvarchar(50),
	@PhoneNumber varchar(50),
	@Email varchar(50)
AS
BEGIN
	INSERT INTO Supplier(SupplierID,[Name],[Address],PhoneNumber,Email)
	VALUES 
		(@ID,@Name,@Address,@PhoneNumber,@Email)
	

END;
GO
--Chinh sửa nhà cung cấp
CREATE PROCEDURE UpdateSupplier
	@ID varchar(50),
	@Name nvarchar(50),
	@Address nvarchar(50),
	@PhoneNumber varchar(50),
	@Email varchar(50)
AS
BEGIN
	UPDATE Supplier
	SET 
	[Name]=@Name,
	[Address]=@Address,
	PhoneNumber=@PhoneNumber,
	Email=@Email
	WHERE SupplierID=@ID
END;
GO
--Chỉnh sửa chi tiết nhà cung cấp
CREATE PROCEDURE UpdateSupplierDetail
	@SupplierID varchar(50),
	@ProductID varchar(50),
	@SupplyStartDate datetime
AS
BEGIN 
	UPDATE SupplierProduct
	SET 
	
	[SupplyStartDate]=@SupplyStartDate
	WHERE SupplierID=@SupplierID AND ProductID=@ProductID
END;
GO
--Thêm chi tiết nhà cung cấp
CREATE PROCEDURE AddDetailSupplier
	@SupplierID varchar(50),
	@ProductID varchar(50),
	@SupplyStartDate datetime
AS
BEGIN 
	IF NOT EXISTS(SELECT SupplierProduct.SupplierID,SupplierProduct.ProductID FROM SupplierProduct WHERE SupplierProduct.SupplierID=@SupplierID AND SupplierProduct.ProductID=@ProductID)
		INSERT INTO SupplierProduct(SupplierID,ProductID,SupplyStartDate)
	VALUES
		(@SupplierID,@ProductID,@SupplyStartDate)
	

END;
GO
--Xóa nhà cung cấp
CREATE PROCEDURE DelSupplier
	@ID varchar(10)
AS
BEGIN
	UPDATE Supplier
	SET isDeleted = 0
	WHERE Supplier.SupplierID = @ID AND isDeleted = 1
	
END;
GO
--Xóa chi tiết nhà cung cấp
CREATE PROCEDURE DelSupplierDetail
	@SupplierID varchar(50),
	@ProductID varchar(50)
AS
BEGIN 
	DELETE FROM SupplierProduct
	WHERE SupplierID=@SupplierID AND ProductID=@ProductID
END;
GO
--Lấy thông tin sản phẩm
CREATE PROCEDURE AllProduct
	@ID varchar(50)
AS
BEGIN
	SELECT 
	Product.ProductID AS ID,
	Product.[Name] AS Tên,
	Product.TypeID AS Loại,
	Product.CurrentPrice AS Giá
	FROM Product
	WHERE NOT EXISTS (SELECT * FROM SupplierProduct WHERE Product.ProductID=SupplierProduct.ProductID);
		
END;
GO

-- Lấy mã KH và tên KH
CREATE PROCEDURE SelectCustomerIdAndName
AS
BEGIN
	SELECT CustomerID, [Name]
	FROM Customer
    WHERE isDeleted = 1
END;
GO

-- Thêm một bill mới
CREATE PROCEDURE InsertIntoBill
	@BillID varchar(10),
	@Date datetime,
	@EmployeeID varchar(10),
	@CustomerID varchar(10) = NULL
AS
BEGIN
	INSERT INTO Bill(BillID, [Date], EmployeeID, CustomerID)
	VALUES (@BillID, @Date, @EmployeeID, @CustomerID)
END;
GO

-- Thêm khách hàng cho hóa đơn
CREATE PROC InsertCustomerSale
	@CustomerID varchar(10),
	@Name nvarchar(50),
	@PhoneNumber varchar(50),
	@Sex nvarchar(10)
AS
BEGIN
	INSERT INTO Customer(CustomerID, [Name], PhoneNumber, Sex)
	VALUES (@CustomerID, @Name, @PhoneNumber, @Sex)
END;
GO

-- Xóa hóa đơn
CREATE PROC DeleteBill
	@BillID varchar(10)
AS
BEGIN
	UPDATE Bill
	SET Bill.isDeleted = 0
	WHERE BillID = @BillID AND isDeleted = 1
END;
GO

-- Thien ======================================================================================================


--========= Đại ==========
---------------------------------------------------Chương trình khuyến mãi và chi tiết chương trình khuyến mãi----------------------------------------------------

-- Đại
-- Lấy tất cả thông tin chương trình khuyến mãi
CREATE PROC SelectAllPromotionsToShow
AS
BEGIN
	SELECT Promotion.PromotionID AS ID, Promotion.Name, Promotion.StartDate,
	Promotion.EndDate, Promotion.Discount, Promotion.[Status]
	FROM Promotion
	WHERE Promotion.isDeleted = 1
END;
GO

CREATE PROC SelectAllPromotionsToCreateID
AS
BEGIN
	SELECT PromotionID
	FROM Promotion
END;
GO

-- Thêm chương trình khuyến mãi
CREATE PROC InsertPromotion
	@PromotionID varchar(10),
	@Name nvarchar(50),
	@StartDate datetime,
	@EndDate datetime,
	@Discount float(50)
AS
BEGIN
	INSERT INTO Promotion(PromotionID,[Name],StartDate,EndDate,Discount,[Status])
	VALUES (@PromotionID,@Name,@StartDate,@EndDate,@Discount,N'Không hoạt động')
END;
GO

-- Sửa thông tin chương trình khuyến mãi
CREATE PROC UpdatePromotion
	@PromotionID varchar(10),
	@Name nvarchar(50),
	@StartDate datetime,
	@EndDate datetime,
	@Discount float(50)
AS
BEGIN
	UPDATE Promotion SET Name = @Name, StartDate = @StartDate, EndDate = @EndDate, Discount = @Discount
	WHERE PromotionID = @PromotionID
END;
GO

-- Xoá chương trình khuyến mãi
CREATE PROC DeletePromotion
	@PromotionID varchar(10)
AS
BEGIN
	UPDATE Promotion SET isDeleted = '0'
	WHERE PromotionID = @PromotionID
END;
GO

-- Áp dụng chương trình khuyến mãi
CREATE PROC StartWork
	@PromotionID varchar(10)
AS
BEGIN
	UPDATE Promotion SET [Status] = N'Đang hoạt động'
	WHERE PromotionID = @PromotionID
END;
GO

-- Ngưng áp dụng chương trình khuyến mãi
CREATE PROC StopWork
	@PromotionID varchar(10)
AS
BEGIN
	UPDATE Promotion SET [Status] = N'Không hoạt động'
	WHERE PromotionID = @PromotionID
END;
GO

-- Tải danh sách sản phẩm cho chương trình khuyến mãi (danh sách chọn)
CREATE PROC SelectProductToPromotion
	@PromotionID varchar(10)
AS
BEGIN
	SELECT DISTINCT ProductID, P.[Name], PT.Name, PromotionID, [Description]
	FROM Product P, ProductType PT
	WHERE (PromotionID != @PromotionID or PromotionID is null) and P.TypeID = PT.TypeID and P.isDeleted = '1'
END;
GO

-- Tải danh sách sản phẩm cho chương trình khuyến mãi (danh sách đã chọn)
CREATE PROC SelectProductToPromotionApply
	@PromotionID varchar(10)
AS
BEGIN
	SELECT ProductID, P.[Name], PT.Name, [Description]
	FROM Product P, ProductType PT
	WHERE PromotionID = @PromotionID and P.isDeleted = '1' and P.TypeID = PT.TypeID
END;
GO

-- Xoá sản phẩm khuyến mãi khỏi danh sách chi tiết khuyến mãi
CREATE PROC DeleteProductFromPromotionProduct
	@ProductID varchar(10)
AS
BEGIN
	UPDATE Product SET PromotionID = null
	WHERE ProductID = @ProductID
END;
GO

-- Thêm sản phẩm vào danh sách chi tiết khuyến mãi
CREATE PROC AddProductToPromotionProduct
	@ProductID varchar(10),
	@PromotionID varchar(10)
AS
BEGIN
	UPDATE Product SET PromotionID = @PromotionID
	WHERE ProductID = @ProductID
END;
GO

-- Lấy mã chương trình khuyến mãi trong danh sách
CREATE PROC GetPromotionIDFromProductID
	@ProductID varchar(10)
AS
BEGIN
	SELECT PromotionID
	FROM Product
	WHERE ProductID = @ProductID
END;
GO

CREATE PROC ClearAllProductsFromPromotion
	@PromotionID varchar(10)
AS
BEGIN
	UPDATE Product SET PromotionID = null WHERE PromotionID = @PromotionID
END;
GO

----------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------Phiếu nhập và chi tiết phiếu nhập----------------------------------------------------
-- Lấy danh sách phiếu nhập
CREATE PROC SelectAllPurchaseOrder
	@EmployeeID varchar(10)
AS
BEGIN
	SELECT OrderID, E.Name, S.Name, PO.importDate, PO.TotalPrice, PO.Status
	FROM PurchaseOrder PO, Employee E, Supplier S
	WHERE PO.EmployeeID = E.EmployeeID and PO.SupplierID = S.SupplierID and PO.isDeleted = '1' and E.EmployeeID = @EmployeeID
END;
GO

CREATE PROC SelectAllOrders
AS
BEGIN
	SELECT OrderID
	FROM PurchaseOrder
END;
GO

-- Tạo phiếu nhập
CREATE PROC InsertPurchaseOrder
	@OrderID varchar(10),
	@EmployeeID varchar(10),
	@SupplierID varchar(10),
	@importDate datetime,
	@TotalPrice float(50)
AS
BEGIN
	INSERT INTO PurchaseOrder (OrderID,EmployeeID,SupplierID,importDate,TotalPrice)
	VALUES (@OrderID,@EmployeeID, @SupplierID, @importDate, @TotalPrice)
END;
GO

-- Sửa phiếu nhập
CREATE PROC UpdatePurchaseOrder
	@OrderID varchar(10),
	@SupplierID varchar(10)
AS
BEGIN
	UPDATE PurchaseOrder SET SupplierID = @SupplierID WHERE OrderID = @OrderID
END;
GO

-- Xoá phiếu nhập
CREATE PROC DeletePurchaseOrder
	@OrderID varchar(10)
AS
BEGIN
	UPDATE PurchaseOrder SET isDeleted = '0' WHERE OrderID = @OrderID
END;
GO

--Tải danh sách các sản phẩm vào chi tiết phiếu nhập( Tất cả sản phẩm)
CREATE PROC SelectProductsToPurchaseOrder
	@OrderID varchar(10),
	@SupplierID varchar(50)
AS
BEGIN
	SELECT P.ProductID, P.Name, P.Quantity, P.Unit
	FROM Product P, SupplierProduct SP
	WHERE isDeleted = '1' and P.ProductID not in (SELECT DPO.ProductID FROM DetailPurchaseOrder DPO WHERE DPO.OrderID = @OrderID) and P.ProductID = SP.ProductID and SP.SupplierID = @SupplierID
END;
GO

-- Tải danh sách các sản phẩm đang nhập và đã nhập vào chi tiết phiếu nhập
CREATE PROC SelectProductsToDetailOrder
	@OrderID varchar(10)
AS
BEGIN
	SELECT P.ProductID, P.Name, DPO.Quantity, P.Unit, DPO.PurchasePrice
	FROM DetailPurchaseOrder DPO, Product P
	WHERE DPO.ProductID = P.ProductID and DPO.OrderID = @OrderID
END;
GO


-- Thêm sản phẩm vào chi tiết phiếu nhập
CREATE PROC AddProductToDetailOrder
	@Order varchar(10),
	@ProductID varchar(10),
	@OrderPrice float(50),
	@Quantity int
AS
BEGIN
	INSERT INTO DetailPurchaseOrder (OrderID,ProductID,Quantity,PurchasePrice)
	VALUES (@Order,@ProductID,@Quantity,@OrderPrice)
END;
GO

-- Thêm lô sản phẩm vào kho
CREATE PROC AddProductsToInventory
	@Order varchar(10),
	@ProductID varchar(10),
	@CurrentQuantity int	
AS
BEGIN
	INSERT INTO Inventory (OrderID,ProductID,CurrentQuantity)
	VALUES (@Order,@ProductID,@CurrentQuantity)
END;
GO

-- Xoá sản phẩm khỏi danh sách chọn trong chi tiết phiếu nhập
CREATE PROC DeleteProductFromDetailOrder
	@OrderID varchar(10),
	@ProductID varchar(10)
AS
BEGIN
	DELETE FROM DetailPurchaseOrder WHERE OrderID = @OrderID and ProductID = @ProductID
END;
GO

-- Thanh toán phiếu nhập
CREATE PROC PayOrder
	@OrderID varchar(10)
AS
BEGIN
	UPDATE PurchaseOrder SET [Status] = '1' WHERE OrderID = @OrderID
END;
GO

-- set tổng giá nhập cho phiếu nhập
CREATE PROC SetTotalPriceOrder
	@OrderID varchar(10)
AS
BEGIN
	UPDATE PurchaseOrder SET TotalPrice = (SELECT SUM(PurchasePrice*Quantity) FROM DetailPurchaseOrder WHERE OrderID = @OrderID)
	WHERE OrderID = @OrderID
END;
GO

-- set Tổng số lượng cho sản phẩm từ kho khi thanh toán phiếu nhập
CREATE PROC SetQuantityProduct
AS
BEGIN
	UPDATE Product
	SET Quantity = ISNULL((SELECT SUM(CurrentQuantity)
							FROM Inventory
							WHERE Inventory.ProductID = Product.ProductID
							GROUP BY ProductID),0)
END;
GO

-- Lấy mã nhà cung cấp bằng tên nhà cung cấp
CREATE PROC GetSupplierIDByName
	@Name nvarchar(50)
AS
BEGIN
	SELECT SupplierID
	FROM Supplier
	WHERE Name = @Name
END;
GO

-- Xoá tất cả sản phẩm trong phiếu nhập
CREATE PROC ClearAllProductInDetailOrder
	@OrderID varchar(10)
AS
BEGIN
	DELETE FROM DetailPurchaseOrder WHERE OrderID = @OrderID
END;
GO

-- Lấy danh sách để xuất file text
CREATE PROC ExportTextFileOrder
	@OrderID varchar(10)
AS
BEGIN
	SELECT P.ProductID, P.Name, P.Unit, DPO.Quantity, DPO.PurchasePrice
	FROM PurchaseOrder PO, Product P, DetailPurchaseOrder DPO
	WHERE PO.OrderID = DPO.OrderID and P.ProductID = DPO.ProductID and PO.OrderID = @OrderID
END;
GO

----------------------------------------------------------------------------------------------------------------------------------------------------------

--Công Anh--


-- Tạo stored procedure để lấy hóa đơn trong khoảng thời gian
CREATE PROCEDURE GetBillsByDateRange
    @FromDate DATETIME,
    @ToDate DATETIME
AS
BEGIN
    SELECT BillID, [Date], EmployeeID, CustomerID, EstimatedPrice, ReducePrice, TotalPrice, [Status]
    FROM Bill
    WHERE [Date] BETWEEN @FromDate AND @ToDate
      AND isDeleted = 1 AND [Status] = 1; -- Chỉ lấy những hóa đơn chưa bị xóa
END;
GO

-- Tạo stored procedure để lấy một số thông tin nhân viên của hóa đơn trong khoảng thời gian
CREATE PROCEDURE GetEmployeesByDateRange
    @FromDate DATETIME,
    @ToDate DATETIME
AS
BEGIN
    SELECT 
        Bill.EmployeeID AS 'EmployeeID',
        Employee.[Name] AS 'EmployeeName',
        Bill.BillID AS 'BillID',
        Bill.[Date] AS 'Date',  
        Bill.TotalPrice AS 'TotalPrice'
    FROM 
        Bill 
    INNER JOIN 
        Employee ON Bill.EmployeeID = Employee.EmployeeID 
    WHERE 
        Bill.[Date] BETWEEN @FromDate AND @ToDate
        AND Bill.isDeleted = 1 AND Bill.[Status] = 1; -- Chỉ lấy những hóa đơn chưa bị xóa
END;
GO


--Lấy một số thông tin nhân viên của hóa đơn
CREATE PROCEDURE SelectBillInformation
AS
BEGIN
    SELECT Bill.EmployeeID,
    Employee.[Name] AS EmployeeName,
	Bill.BillID, 
	Bill.[Date],  
    Bill.TotalPrice
	FROM Bill INNER JOIN Employee ON Bill.EmployeeID = Employee.EmployeeID 
    WHERE  Bill.isDeleted = 1 AND Bill.[Status] = 1;
END;
GO


--Lấy danh sách sản phẩm 
CREATE PROCEDURE SelectAllFromProduct
AS
BEGIN
    SELECT
        Product.ProductID,
        Product.[Name],
        ProductType.[Name] AS ProductTypeName,
        Product.Quantity,
        Product.CurrentPrice,
        Product.[Description],
        Product.Unit,
        Promotion.[Name] AS PromotionName,
        Product.isDeleted
    FROM Product
    INNER JOIN ProductType ON Product.TypeID = ProductType.TypeID
	LEFT JOIN Promotion ON Product.PromotionID = Promotion.PromotionID 
	
END;
GO

-- Thêm sản phẩm
CREATE PROCEDURE InsertIntoProduct
    @ProductID varchar(10),
    @Name nvarchar(50),
    @TypeID varchar(10),
    @Quantity int,
    @CurrentPrice float(53),
    @Description nvarchar(100),
    @Unit nvarchar(20),
	@PromotionID varchar(10)
    
AS
BEGIN
    INSERT INTO Product (ProductID, [Name], TypeID, Quantity, CurrentPrice, [Description], Unit, PromotionID)
    VALUES (@ProductID, @Name, @TypeID, @Quantity, @CurrentPrice, @Description, @Unit, @PromotionID )
END;
GO
-- Cập nhật sản phẩm
CREATE PROCEDURE UpdateProduct
    @ProductID varchar(10),
    @Name nvarchar(50),
    @TypeID varchar(10),
    @Quantity int,
    @CurrentPrice float(53),
    @Description nvarchar(100),
    @Unit nvarchar(20),
	@PromotionID varchar(10)
AS
BEGIN
    UPDATE Product
    SET
        [Name] = @Name,
        TypeID = @TypeID,
        Quantity = @Quantity,
        CurrentPrice = @CurrentPrice,
        [Description] = @Description,
        Unit = @Unit,
		PromotionID = @PromotionID
        
    WHERE ProductID = @ProductID
END;
GO
-- Xóa sản phẩm 
CREATE PROCEDURE DeleteProduct
    @ProductID varchar(10)
AS
BEGIN
    UPDATE Product
    SET isDeleted = '0'
    WHERE ProductID = @ProductID
END;
GO

-- =================================================Sang
-- Lấy danh sách nhân viên
CREATE PROCEDURE SelectAllFromEmployee
AS
BEGIN
		SELECT Employee.EmployeeID, UserName, [Password], Employee.[Name], Sex, BirthDate, PhoneNumber, Email, [Address], [Role].[Name] RoleName
		FROM Employee, [Role]
		WHERE Employee.isDeleted = 1 and Employee.RoleID = [Role].RoleID;

END;
GO

-- Thêm nhân viên
CREATE PROCEDURE InsertIntoEmployee
    @EmployeeID varchar(10),
    @Name nvarchar(50),
    @Address nvarchar(50),
    @PhoneNumber varchar(50),
    @Email varchar(50),
    @Sex nvarchar(10),
    @BirthDate date,
    @Password varchar(50),
    @UserName varchar(50),
	@RoleID varchar(10)
AS
BEGIN
        INSERT INTO Employee (EmployeeID, [Name], Address, PhoneNumber, Email, Sex, BirthDate, Password, UserName, RoleID)
        VALUES (@EmployeeID, @Name, @Address, @PhoneNumber, @Email, @Sex, @BirthDate, @Password, @UserName, @RoleID);
END;
GO


-- Sửa nhân viên
CREATE PROCEDURE EditEmployee
    @EmployeeID varchar(10),
	@Name nvarchar(50),
	@Address nvarchar(50),
	@PhoneNumber varchar(50),
	@Email varchar(50),
	@Sex nvarchar(10),
	@BirthDate date,
	@Password varchar(50),
	@UserName varchar(50),
	@RoleID varchar(10)
AS
BEGIN
    UPDATE Employee
    SET
        [Name] = @Name,
        Address = @Address,
        PhoneNumber = @PhoneNumber,
        Email = @Email,
        Sex = @Sex,
        BirthDate = @BirthDate,
        Password = @Password,
		UserName = @UserName,
		RoleID = @RoleID
        
    WHERE EmployeeID = @EmployeeID
END;
GO

-- Xóa nhân viên 
CREATE PROCEDURE DeleteEmployee
    @EmployeeID varchar(10)
AS
BEGIN
    UPDATE Employee
    SET isDeleted = '0'
    WHERE EmployeeID = @EmployeeID
END;
GO

-- Tìm kiếm theo ID
CREATE PROCEDURE SearchEmployeeByID
    @SearchTerm NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT EmployeeID, [Password], [Name], Sex, BirthDate, PhoneNumber, Email, [Address], RoleID
    FROM dbo.Employee
    WHERE EmployeeID = @SearchTerm;
END;
GO

-- Tìm kiếm theo tên
CREATE PROCEDURE SearchEmployeeByName
    @SearchTerm NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT EmployeeID, [Password], [Name], Sex, BirthDate, PhoneNumber, Email, [Address], RoleID
    FROM dbo.Employee
    WHERE Name LIKE '%' + @SearchTerm + '%';
END;
GO

-- Lấy danh sách chức vụ
CREATE PROCEDURE SelectAllFromRole
AS
BEGIN
		SELECT * FROM [Role]
END;
GO

-- Thêm chức vụ
CREATE PROCEDURE InsertIntoRole
    @RoleID varchar(10),
	@Name nvarchar(50),
	@Description nvarchar(100)
AS
BEGIN
        INSERT INTO Role (RoleID, [Name], [Description])
        VALUES (@RoleID, @Name, @Description );
END;
GO

-- Sửa chức vụ
CREATE PROCEDURE EditRole
    @RoleID varchar(10),
	@Name nvarchar(50),
	@Description nvarchar(100)
AS
BEGIN
    UPDATE Role
    SET
        [Name] = @Name,
        Description = @Description
        
    WHERE RoleID = @RoleID
END;
GO

-- Xóa Chức vụ
CREATE PROCEDURE DeleteRole
    @RoleID varchar(10)
AS
BEGIN
    UPDATE Role
    SET isDeleted = '0'
    WHERE RoleID = @RoleID
END;
GO
-- Lấy các chức năng từ mã quyền
Create PROCEDURE SelectAllFunctionAndRoleID
AS
BEGIN
    Select [Role].RoleID, Functions.[Name] From Functions, RoleFunction, [Role]
	Where RoleFunction.FunctionID = Functions.FunctionID and [Role].RoleID = RoleFunction.RoleID
	and isDeleted = 1
END;
GO

-- Xóa chức năng từ quyền
Create PROCEDURE DeleteFunctionFromRoleID
    @RoleID varchar(10)
AS
BEGIN
    Delete From RoleFunction
	Where RoleFunction.RoleID = @RoleID
END;
GO

-- Thêm chức năng vào quyền
Create PROCEDURE InsertIntoRoleFunction
    @RoleID varchar(10),
	@FunctionID varchar(10)
AS
BEGIN
    Insert Into RoleFunction
	Values(@RoleID, @FunctionID)
END;
GO
-- Lấy mã quyền từ employeeID
Create PROCEDURE SelectRoleIDFromEmployeeID
    @EmployeeID varchar(10)
AS
BEGIN
    Select RoleID From Employee
	Where EmployeeID = @EmployeeID
END;
GO

CREATE PROCEDURE GetRoles
AS
BEGIN
    SELECT RoleID, [Name] FROM [Role]
	WHERE isDeleted = 1;

END;
GO
-- ===================================================End Sang

-- ========================================================Tiến
CREATE PROCEDURE [dbo].[SelectAllCustomer]
AS
BEGIN
    SELECT * FROM Customer;
END;
GO

CREATE PROCEDURE [dbo].[InsertCustomer]
    @CustomerID VARCHAR(10),
    @Name NVARCHAR(MAX),
    @PhoneNumber NVARCHAR(MAX),
    @Sex NVARCHAR(10),
    @Point INT = NULL,  -- Set a default value to allow NULL
    @isDeleted BIT
AS
BEGIN
    -- Your query to insert a new customer
    INSERT INTO customer (CustomerID, Name, PhoneNumber, Sex, Point, isDeleted)
    VALUES (@CustomerID, @Name, @PhoneNumber, @Sex, COALESCE(@Point, 0), @isDeleted);
END;
GO

CREATE PROCEDURE [dbo].[UpdateCustomer]
    @CustomerID VARCHAR(10),
    @Name NVARCHAR(MAX),
    @PhoneNumber NVARCHAR(MAX),
    @Sex NVARCHAR(10),
    @Point INT = NULL,  -- Set a default value to allow NULL
    @isDeleted BIT
AS
BEGIN
    -- Your query to update customer information by CustomerID
    UPDATE customer
    SET
        Name = @Name,
        PhoneNumber = @PhoneNumber,
        Sex = @Sex,
        Point = COALESCE(@Point, 0),
        isDeleted = @isDeleted
    WHERE
        CustomerID = @CustomerID;
END;
GO

-- Xóa khách hàng
CREATE PROCEDURE [dbo].[DeleteCustomer]
    @CustomerID VARCHAR(10)
AS
BEGIN
    -- Your query to delete a customer by CustomerID
    UPDATE customer SET IsDeleted = 0 WHERE CustomerID = @CustomerID;
END;
GO

CREATE PROCEDURE [dbo].[GetAllDetailBills]
AS
BEGIN
    SELECT
        DB.[BillID],
        DB.[ProductID],
        DB.[OrderID],
        P.[Name],
		P.[PromotionID],
        DB.[SalePrice],
        DB.[Quantity]
    FROM
        DetailBill DB
    INNER JOIN
        Product P ON DB.[ProductID] = P.[ProductID];
END;
GO

CREATE PROCEDURE [dbo].[GetDetailBill]
   @BillID varchar(10)
AS
BEGIN
    SELECT
        DB.[BillID],
        DB.[ProductID],
        P.[Name],
		P.[PromotionID],
        SUM(DB.[SalePrice]) AS TotalSalePrice,
        SUM(DB.[Quantity]) AS TotalQuantity
    FROM
        DetailBill DB
    INNER JOIN
        Product P ON DB.[ProductID] = P.[ProductID]
    WHERE
        DB.BillID = @BillID
    GROUP BY
        DB.[BillID],
        DB.[ProductID],
        P.[Name], -- Chỉ giữ lại các cột cần thiết
		P.[PromotionID]
    ORDER BY
        DB.[BillID],
        DB.[ProductID];
END;


GO

CREATE PROCEDURE [dbo].[AddDetailBill]
	@BillID varchar(10),
    @ProductID varchar(10),
    @Quantity int
AS
BEGIN
    DECLARE @RemainingQuantity int = @Quantity;
    DECLARE @PromotionID varchar(10);
    DECLARE @CurrentOrderID varchar(10);
    DECLARE @ImportDate datetime;
    DECLARE @CurrentPrice float;

	-- Lấy PromotionID và CurrentPrice từ bảng Product
	SELECT
		@PromotionID = PromotionID,
		@CurrentPrice = CurrentPrice
	FROM Product WHERE ProductID = @ProductID;

    -- Mở con trỏ để lấy danh sách các đơn hàng chưa được xử lý
    DECLARE ordersCursor CURSOR FOR
    SELECT I.OrderID, PO.importDate
    FROM Inventory I
    JOIN PurchaseOrder PO ON I.OrderID = PO.OrderID
    WHERE I.ProductID = @ProductID
    ORDER BY PO.importDate ASC;

    OPEN ordersCursor;

    -- Lấy bản ghi đầu tiên từ con trỏ
    FETCH NEXT FROM ordersCursor INTO @CurrentOrderID, @ImportDate;

    -- Bắt đầu vòng lặp, kiểm tra điều kiện để xử lý từng đơn hàng
    WHILE @RemainingQuantity > 0 AND @@FETCH_STATUS = 0
    BEGIN
        -- Kiểm tra số lượng có đủ không
        IF (SELECT CurrentQuantity FROM Inventory WHERE ProductID = @ProductID AND OrderID = @CurrentOrderID) >= @RemainingQuantity
        BEGIN
            -- Thêm PromotionID vào DetailBill
            INSERT INTO DetailBill (BillID, ProductID, OrderID, PromotionID, SalePrice, Quantity)
            VALUES (@BillID, @ProductID, @CurrentOrderID, @PromotionID, @CurrentPrice * @RemainingQuantity, @RemainingQuantity);

            -- Cập nhật Quantity từ Product và Inventory
            UPDATE Product
            SET Quantity = Quantity - @RemainingQuantity
            WHERE ProductID = @ProductID;

            UPDATE Inventory
            SET CurrentQuantity = CurrentQuantity - @RemainingQuantity
            WHERE ProductID = @ProductID AND OrderID = @CurrentOrderID;

            -- Đã cập nhật đủ số lượng, thoát khỏi vòng lặp
            BREAK;
        END
        ELSE
        BEGIN
            -- Lấy số lượng còn trong OrderID mới
            DECLARE @OrderQuantity int;
            SET @OrderQuantity = (SELECT CurrentQuantity FROM Inventory WHERE ProductID = @ProductID AND OrderID = @CurrentOrderID);

            -- Thêm PromotionID vào DetailBill
            INSERT INTO DetailBill (BillID, ProductID, OrderID, PromotionID, SalePrice, Quantity)
            VALUES (@BillID, @ProductID, @CurrentOrderID, @PromotionID, @CurrentPrice * @OrderQuantity, @OrderQuantity);

            -- Cập nhật Quantity từ Product và Inventory
            UPDATE Product
            SET Quantity = Quantity - @OrderQuantity
            WHERE ProductID = @ProductID;

            UPDATE Inventory
            SET CurrentQuantity = CurrentQuantity - @OrderQuantity
            WHERE ProductID = @ProductID AND OrderID = @CurrentOrderID;

            -- Giảm lượng còn lại
            SET @RemainingQuantity = @RemainingQuantity - @OrderQuantity;
        END

        -- Lấy bản ghi tiếp theo từ con trỏ
        FETCH NEXT FROM ordersCursor INTO @CurrentOrderID, @ImportDate;
    END

    -- Đóng và giải phóng con trỏ sau khi hoàn thành
    CLOSE ordersCursor;
    DEALLOCATE ordersCursor;
END;


GO

CREATE PROCEDURE [dbo].[UpdateDetailBill]
   @BillID varchar(10),
   @ProductID varchar(10),
   @NewQuantity int
AS
BEGIN
    -- Lấy thông tin cần thiết từ DetailBill
    DECLARE @RemainingQuantity int = @NewQuantity;
    DECLARE @CurrentOrderID varchar(10);
    DECLARE @ImportDate datetime;
    DECLARE @PromotionID varchar(10);
    DECLARE @CurrentPrice float;

    -- Lấy PromotionID và CurrentPrice từ bảng Product
    SELECT
        @PromotionID = PromotionID,
        @CurrentPrice = CurrentPrice
    FROM Product
    WHERE ProductID = @ProductID;

    -- Khai báo biến lưu tổng số lượng
    DECLARE @TotalQuantity int = 0;

    -- Lặp qua các bản ghi cần cập nhật
    WHILE @RemainingQuantity <> 0
    BEGIN
        -- Lấy OrderID và Quantity hiện tại từ DetailBill
        SELECT TOP 1
            @CurrentOrderID = OrderID,
            @TotalQuantity = Quantity
        FROM DetailBill
        WHERE BillID = @BillID
            AND ProductID = @ProductID
            AND Quantity < @NewQuantity
        ORDER BY Quantity;

        -- Kiểm tra nếu không còn bản ghi cần cập nhật
        IF @@ROWCOUNT = 0
        BEGIN
            BREAK;
        END

        -- Cập nhật Quantity trong DetailBill
        UPDATE DetailBill
        SET Quantity = @NewQuantity
        WHERE
            BillID = @BillID
            AND ProductID = @ProductID
            AND OrderID = @CurrentOrderID;

        -- Cập nhật số lượng trong Inventory và Product
        DECLARE @QuantityChange int = @NewQuantity - @TotalQuantity;

        UPDATE I
        SET I.CurrentQuantity = I.CurrentQuantity - @QuantityChange
        FROM Inventory I
        WHERE I.OrderID = @CurrentOrderID AND I.ProductID = @ProductID;

        UPDATE P
        SET P.Quantity = P.Quantity - @QuantityChange
        FROM Product P
        WHERE P.ProductID = @ProductID;

        SET @RemainingQuantity = @RemainingQuantity - @QuantityChange;
    END
END;


GO

CREATE PROCEDURE [dbo].[DeleteDetailBill]
   @BillID varchar(10),
   @ProductID varchar(10)
AS
BEGIN
    -- Lấy thông tin cần thiết từ DetailBill
    DECLARE @QuantityToDelete int;
    DECLARE @OrderIDToDelete varchar(10);

    -- Khai báo con trỏ để duyệt qua các bản ghi cần xóa
    DECLARE deleteCursor CURSOR FOR
    SELECT OrderID, Quantity
    FROM DetailBill
    WHERE BillID = @BillID AND ProductID = @ProductID;

    OPEN deleteCursor;

    FETCH NEXT FROM deleteCursor INTO @OrderIDToDelete, @QuantityToDelete;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Xóa bản ghi từ DetailBill
        DELETE FROM DetailBill
        WHERE
            BillID = @BillID
            AND ProductID = @ProductID
            AND OrderID = @OrderIDToDelete;

        -- Cập nhật số lượng trong Inventory
        UPDATE I
        SET I.CurrentQuantity = I.CurrentQuantity + @QuantityToDelete
        FROM Inventory I
        WHERE I.OrderID = @OrderIDToDelete;

        -- Cập nhật số lượng trong Product
        UPDATE P
        SET P.Quantity = P.Quantity + @QuantityToDelete
        FROM Product P
        WHERE P.ProductID = @ProductID;

        FETCH NEXT FROM deleteCursor INTO @OrderIDToDelete, @QuantityToDelete;
    END

    CLOSE deleteCursor;
    DEALLOCATE deleteCursor;
END;


GO

CREATE PROCEDURE GetProductQuantity
    @ProductID NVARCHAR(10)
AS
BEGIN
    SELECT Quantity
    FROM Product
    WHERE ProductID = @ProductID;
END;
GO


CREATE PROCEDURE UpdateBillPrice
    @BillID varchar(10)
AS
BEGIN
    -- Cập nhật EstimatedPrice
    UPDATE Bill
    SET EstimatedPrice = ISNULL((
        SELECT SUM(SalePrice)
        FROM DetailBill
        WHERE BillID = @BillID
    ), 0)
    WHERE BillID = @BillID;

    -- Cập nhật ReducePrice
    UPDATE Bill
    SET ReducePrice = ISNULL((
        SELECT SUM(CASE WHEN P.Status = N'Đang hoạt động' THEN SalePrice * P.Discount / 100 ELSE 0 END)
        FROM DetailBill D
        JOIN Promotion P ON D.PromotionID = P.PromotionID
        WHERE D.BillID = @BillID
    ), 0)
    WHERE BillID = @BillID;

    -- Cập nhật TotalPrice
    UPDATE Bill
    SET TotalPrice = EstimatedPrice - ReducePrice
    WHERE BillID = @BillID;

END;
GO


CREATE PROCEDURE PayTheBill
    @BillID varchar(10)
AS
BEGIN
    -- Cập nhật Status
    UPDATE Bill
    SET Status = 1
    WHERE BillID = @BillID;
END;
GO

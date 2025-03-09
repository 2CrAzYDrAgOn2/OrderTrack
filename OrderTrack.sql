CREATE DATABASE OrderTrack;
USE OrderTrack;

CREATE TABLE ClientTypes(
	ClientTypeID INT PRIMARY KEY IDENTITY(1,1),
	ClientType NVARCHAR(150) NOT NULL
);

CREATE TABLE Genders(
	GenderID INT PRIMARY KEY IDENTITY(1,1),
	Gender NVARCHAR(150) NOT NULL
);

CREATE TABLE Posts(
	PostID INT PRIMARY KEY IDENTITY(1,1),
	Post NVARCHAR(150) NOT NULL
);

CREATE TABLE Statuses(
	StatusID INT PRIMARY KEY IDENTITY(1,1),
	Status NVARCHAR(150) NOT NULL
);

CREATE TABLE Clients (
    ClientID INT PRIMARY KEY IDENTITY(1,1),
	FullName NVARCHAR(150) NOT NULL,
	ClientTypeID INT DEFAULT 0,
	Email NVARCHAR(100) UNIQUE,
    Phone NVARCHAR(18) UNIQUE NOT NULL,
    Address NVARCHAR(255),
	INN NVARCHAR(10) DEFAULT '',
    RegistrationDate DATETIME DEFAULT GETDATE(),
	FOREIGN KEY (ClientTypeID) REFERENCES ClientTypes(ClientTypeID)
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(150) NOT NULL,
    Phone NVARCHAR(18) UNIQUE NOT NULL,
    Email NVARCHAR(100) UNIQUE,
	GenderID INT DEFAULT 0,
	PostID INT DEFAULT 0,
	FOREIGN KEY (GenderID) REFERENCES Genders(GenderID),
	FOREIGN KEY (PostID) REFERENCES Posts(PostID)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT NOT NULL,
    EmployeeID INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount FLOAT DEFAULT 0.00,
    StatusID INT DEFAULT 0,
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID) ON DELETE CASCADE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
	FOREIGN KEY (StatusID) REFERENCES Statuses(StatusID) ON DELETE CASCADE
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(150) NOT NULL,
    Description NVARCHAR(255),
    Price FLOAT NOT NULL
);

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Price FLOAT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE
);

CREATE TABLE Registration (
    RegistrationID INT PRIMARY KEY IDENTITY(1,1),
    UserLogin NVARCHAR(50) NOT NULL,
    UserPassword NVARCHAR(50) NOT NULL,
	IsAdmin BIT DEFAULT 0
);

CREATE TRIGGER trg_InsertOrderDetailsPrice
ON OrderDetails
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE od
    SET od.Price = p.Price
    FROM OrderDetails od
    INNER JOIN inserted i ON od.OrderDetailID = i.OrderDetailID
    INNER JOIN Products p ON i.ProductID = p.ProductID;
END;

CREATE TRIGGER trg_UpdateOrderTotalAmount
ON OrderDetails
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE o
    SET o.TotalAmount = (
        SELECT COALESCE(SUM(od.Price), 0)
        FROM OrderDetails od
        WHERE od.OrderID = o.OrderID
    )
    FROM Orders o
    INNER JOIN (SELECT DISTINCT OrderID FROM inserted UNION SELECT DISTINCT OrderID FROM deleted) AS affectedOrders
    ON o.OrderID = affectedOrders.OrderID;
END;

INSERT INTO ClientTypes (ClientType) VALUES ('Физическое лицо'), ('Юридическое лицо');

INSERT INTO Genders (Gender) VALUES ('Мужской'), ('Женский');

INSERT INTO Posts (Post) VALUES ('Менеджер по продажам'), ('Администратор');

INSERT INTO Statuses (Status) VALUES ('В обработке'), ('Подтвержден'), ('Отменен'), ('Выполнен');

INSERT INTO Clients (FullName, ClientTypeID, Email, Phone, Address, INN)
VALUES 
    ('Иванов Иван Иванович', 1, 'ivanov@mail.ru', '+79991234567', 'г. Москва, ул. Ленина, д. 10', ''),
    ('ООО "Ромашка"', 2, 'romashka@mail.ru', '+79991112233', 'г. Санкт-Петербург, пр. Невский, д. 25', '0987654321');

INSERT INTO Employees (FullName, Phone, Email, GenderID, PostID)
VALUES 
    ('Петров Петр Петрович', '+79998887766', 'petrov@mail.ru', 1, 1),
    ('Сидорова Анна Сергеевна', '+79995554433', 'sidorova@mail.ru', 2, 2);

INSERT INTO Products (Name, Description, Price)
VALUES 
    ('Квартира в доме 1', 'Дом 1', 85000000.00),
    ('Квартира в доме 12', 'Дом 2', 3500000.00),
    ('Квартира в доме 13', 'Дом 3', 1500000.00);

INSERT INTO Orders (ClientID, EmployeeID, StatusID)
VALUES 
    (1, 1, 1),
    (2, 2, 2);

INSERT INTO OrderDetails (OrderID, ProductID)
VALUES 
    (1, 1),
    (1, 2),
    (2, 3);

INSERT INTO Registration (UserLogin, UserPassword, IsAdmin) VALUES
('admin', 'admin', 1),
('user', 'user', 0);

SELECT * FROM ClientTypes;
SELECT * FROM Genders;
SELECT * FROM Posts;
SELECT * FROM Statuses;
SELECT * FROM Clients;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Products;
SELECT * FROM OrderDetails;
SELECT * FROM Registration;

DROP DATABASE OrderTrack;
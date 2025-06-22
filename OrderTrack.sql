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
    RegistrationDate DATE DEFAULT GETDATE(),
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

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(150) NOT NULL,
    Description NVARCHAR(255),
    Price FLOAT NOT NULL
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    ClientID INT NOT NULL,
	OOOShnick VARCHAR(150),
    EmployeeID INT NOT NULL,
    OrderDate DATE DEFAULT GETDATE(),
    TotalAmount FLOAT DEFAULT 0.00,
    StatusID INT DEFAULT 0,
	ProductID INT NOT NULL,
    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID) ON DELETE CASCADE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
	FOREIGN KEY (StatusID) REFERENCES Statuses(StatusID) ON DELETE CASCADE,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE
);

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Price FLOAT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Materials (
    MaterialID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(150) NOT NULL,
    Description NVARCHAR(255),
    Unit NVARCHAR(50) NOT NULL,
    CurrentQuantity FLOAT DEFAULT 0
);

CREATE TABLE OrderEstimates (
    OrderEstimateID INT PRIMARY KEY IDENTITY(1,1),
	OrderID INT NOT NULL,
    OrderEstimateDate DATE DEFAULT GETDATE(),
	FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE,
);

CREATE TABLE OrderEstimateDetails (
    OrderEstimateDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderEstimateID INT NOT NULL,
    MaterialID INT NOT NULL,
    Quantity FLOAT NOT NULL,
    FOREIGN KEY (OrderEstimateID) REFERENCES OrderEstimates(OrderEstimateID) ON DELETE CASCADE,
    FOREIGN KEY (MaterialID) REFERENCES Materials(MaterialID) ON DELETE CASCADE
);

CREATE TABLE OrderMaterials (
    OrderMaterialID INT PRIMARY KEY IDENTITY(1,1),
    MaterialID INT NOT NULL,
    Quantity FLOAT NOT NULL,
	RequestDate DATETIME DEFAULT GETDATE(),
	FOREIGN KEY (MaterialID) REFERENCES Materials(MaterialID) ON DELETE CASCADE
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

CREATE OR ALTER TRIGGER trg_CheckMaterialsAndCreateRequest
ON OrderEstimateDetails
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO OrderMaterials (MaterialID, Quantity)
    SELECT 
        i.MaterialID,
        i.Quantity - m.CurrentQuantity AS НедостающееКоличество
    FROM inserted i
    JOIN Materials m ON i.MaterialID = m.MaterialID
    WHERE m.CurrentQuantity < i.Quantity;
END;

CREATE OR ALTER TRIGGER trg_UpdateMaterialQuantityOnRequest
ON OrderMaterials
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM deleted)
    BEGIN
        UPDATE m
        SET m.CurrentQuantity = m.CurrentQuantity + (i.Quantity - d.Quantity)
        FROM Materials m
        JOIN inserted i ON m.MaterialID = i.MaterialID
        JOIN deleted d ON i.OrderMaterialID = d.OrderMaterialID
        WHERE i.Quantity <> d.Quantity;
    END
END;

CREATE OR ALTER TRIGGER trg_SubtractMaterialsOnOrderCompletion
ON Orders
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN
        UPDATE m
        SET m.CurrentQuantity = m.CurrentQuantity - oed.Quantity
        FROM Materials m
        JOIN OrderEstimateDetails oed ON m.MaterialID = oed.MaterialID
        JOIN OrderEstimates oe ON oed.OrderEstimateID = oe.OrderEstimateID
        JOIN inserted i ON oe.OrderID = i.OrderID
        JOIN deleted d ON i.OrderID = d.OrderID
        WHERE i.StatusID = 2 AND d.StatusID <> 2;
    END
END;

CREATE TRIGGER tr_OnlyOneConfirmedOrderInDatabase3
ON Orders
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @ConfirmedStatusID INT;
    SELECT @ConfirmedStatusID = StatusID FROM Statuses WHERE Status = 'Подтвержден';
    IF @ConfirmedStatusID IS NULL
    BEGIN
        RAISERROR('Статус "Подтвержден" не найден в системе', 16, 1);
        RETURN;
    END
    IF EXISTS (SELECT 1 FROM inserted WHERE StatusID = @ConfirmedStatusID)
    BEGIN
        DECLARE @CurrentConfirmedOrderID INT = NULL;
        SELECT TOP 1 @CurrentConfirmedOrderID = OrderID 
        FROM Orders 
        WHERE StatusID = @ConfirmedStatusID
        AND OrderID NOT IN (SELECT OrderID FROM deleted WHERE StatusID = @ConfirmedStatusID);
        IF @CurrentConfirmedOrderID IS NOT NULL AND 
           NOT EXISTS (SELECT 1 FROM inserted WHERE OrderID = @CurrentConfirmedOrderID)
        BEGIN
            RAISERROR('В системе может быть только один подтвержденный заказ', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
    END
END

INSERT INTO ClientTypes (ClientType) VALUES ('Физическое лицо'), ('Юридическое лицо');

INSERT INTO Genders (Gender) VALUES ('Мужской'), ('Женский');

INSERT INTO Posts (Post) VALUES ('Директор'), ('Бухгалтер'), ('Подрядчик');

INSERT INTO Statuses (Status) VALUES ('В обработке'), ('Подтвержден'), ('Отменен'), ('Выполнен');

INSERT INTO Clients (FullName, ClientTypeID, Email, Phone, Address, INN) VALUES
('Иванов Иван Иванович', 1, 'ivanov@mail.ru', '+79161234567', 'г. Москва, ул. Ленина, д. 10, кв. 5', '1234567890'),
('Петров Петр Петрович', 1, 'petrov@mail.ru', '+79162345678', 'г. Москва, ул. Пушкина, д. 15, кв. 12', '2345678901'),
('ООО "СтройИнвест"', 2, 'stroyinvest@mail.ru', '+74951234567', 'г. Москва, ул. Строителей, д. 25', '3456789012'),
('Сидорова Анна Михайловна', 1, 'sidorova@mail.ru', '+79163456789', 'г. Москва, ул. Гагарина, д. 8, кв. 33', '4567890123'),
('ООО "ДомКомфорт"', 2, 'domkomfort@mail.ru', '+74952345678', 'г. Москва, ул. Мира, д. 17', '5678901234');

INSERT INTO Employees (FullName, Phone, Email, GenderID, PostID) VALUES
('Смирнов Алексей Владимирович', '+79164567890', 'smirnov@company.ru', 1, 1),
('Кузнецова Елена Сергеевна', '+79165678901', 'kuznetsova@company.ru', 2, 2),
('Васильев Дмитрий Николаевич', '+79166789012', 'vasiliev@company.ru', 1, 3),
('Николаева Ольга Игоревна', '+79167890123', 'nikolaeva@company.ru', 2, 2),
('Федоров Игорь Александрович', '+79168901234', 'fedorov@company.ru', 1, 3);

INSERT INTO Products (Name, Description, Price) VALUES
('Дом "Эконом"', 'Одноэтажный дом площадью 60 кв.м, 2 спальни, 1 санузел', 2500000),
('Дом "Комфорт"', 'Двухэтажный дом площадью 120 кв.м, 3 спальни, 2 санузла', 5000000),
('Дом "Премиум"', 'Двухэтажный дом площадью 200 кв.м с гаражом, 4 спальни, 3 санузла', 8500000),
('Коттедж "Люкс"', 'Трехэтажный коттедж площадью 300 кв.м с бассейном, 5 спален, 4 санузла', 15000000),
('Таунхаус "Стандарт"', 'Двухэтажный таунхаус площадью 90 кв.м, 2 спальни, 1 санузел', 3500000);

INSERT INTO Materials (Name, Description, Unit, CurrentQuantity) VALUES
('Кирпич', 'Кирпич строительный красный', 'шт', 10000),
('Бетон', 'Бетон марки М300', 'куб.м', 50),
('Доска обрезная', 'Доска 50х150х6000', 'шт', 500),
('Цемент', 'Цемент М500', 'мешок 50кг', 200),
('Металлопрокат', 'Арматура 12мм', 'м', 1000),
('Кровельный материал', 'Металлочерепица', 'кв.м', 500),
('Окна', 'Пластиковые окна 1.5х1.2м', 'шт', 30),
('Двери', 'Входные металлические двери', 'шт', 15),
('Сантехника', 'Унитаз, раковина, ванна', 'комплект', 20),
('Электропроводка', 'Кабель ВВГнг 3х2.5', 'м', 2000);

INSERT INTO Orders (ClientID, OOOShnick, EmployeeID, StatusID, ProductID) VALUES
(1, 'Иванов Иван Иванович', 3, 2, 1),
(3,'Петрова Анна Сергеевна', 5, 4, 3),
(2,'Кузнецов Дмитрий Олегович', 3, 1, 2),
(4,'Смирнова Екатерина Викторовна', 5, 3, 1),
(5,'Лебедев Алексей Петрович', 3, 1, 4),
(1,'Николаева Ольга Дмитриевна', 5, 1, 5),
(3,'Шмаков Артем Сергеевич', 3, 4, 2);

INSERT INTO OrderDetails (OrderID, ProductID) VALUES
(1, 1),
(2, 3),
(3, 2),
(4, 1),
(5, 4),
(6, 5),
(7, 2);

INSERT INTO OrderEstimates (OrderID) VALUES
(1), (2), (3), (5), (7);

INSERT INTO OrderEstimateDetails (OrderEstimateID, MaterialID, Quantity) VALUES
(1, 1, 5000), (1, 2, 15), (1, 3, 200), (1, 4, 50),
(2, 1, 15000), (2, 2, 40), (2, 3, 400), (2, 4, 120), (2, 5, 800), (2, 6, 200),
(3, 1, 8000), (3, 2, 25), (3, 3, 300), (3, 4, 80), (3, 6, 150),
(4, 1, 20000), (4, 2, 60), (4, 3, 600), (4, 4, 150), (4, 5, 1200), (4, 6, 300), (4, 7, 15), (4, 8, 5), (4, 9, 4), (4, 10, 500),
(5, 1, 7000), (5, 2, 20), (5, 3, 250), (5, 4, 70), (5, 6, 120);

INSERT INTO OrderMaterials (MaterialID, Quantity) VALUES
(7, 10),
(8, 5),
(9, 6),
(10, 1000);

INSERT INTO Registration (UserLogin, UserPassword, IsAdmin) VALUES
('admin', 'admin', 1),
('user', 'user', 0);

SELECT * FROM ClientTypes;
SELECT * FROM Genders;
SELECT * FROM Posts;
SELECT * FROM Statuses;
SELECT * FROM Clients;
SELECT * FROM Employees;
SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM OrderDetails;
SELECT * FROM Materials;
SELECT * FROM OrderEstimates;
SELECT * FROM OrderEstimateDetails;
SELECT * FROM OrderMaterials;
SELECT * FROM Registration;

-- 1. Отчет по заказам клиентов
SELECT 
    o.OrderID AS 'Номер заказа',
    c.FullName AS 'Клиент',
    e.FullName AS 'Менеджер',
    s.Status AS 'Статус',
    o.OrderDate AS 'Дата заказа',
    o.TotalAmount AS 'Сумма заказа'
FROM Orders o
JOIN Clients c ON o.ClientID = c.ClientID
JOIN Employees e ON o.EmployeeID = e.EmployeeID
JOIN Statuses s ON o.StatusID = s.StatusID
ORDER BY o.OrderDate DESC;

-- 2. Отчет по популярным товарам
SELECT 
    p.Name AS 'Товар',
    COUNT(od.OrderDetailID) AS 'Количество продаж',
    SUM(od.Price) AS 'Общая сумма'
FROM OrderDetails od
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY p.Name
ORDER BY COUNT(od.OrderDetailID) DESC, SUM(od.Price) DESC;

DROP DATABASE OrderTrack;

use w;
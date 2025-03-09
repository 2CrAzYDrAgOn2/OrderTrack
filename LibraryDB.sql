CREATE DATABASE LibraryDB;
USE LibraryDB;

CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(255),
    Genre NVARCHAR(50),
    PublishedYear INT,
    ISBN NVARCHAR(20) UNIQUE,
    CopiesAvailable INT DEFAULT 1 CHECK (CopiesAvailable >= 0)
);

CREATE TABLE Registration (
    RegistrationID INT PRIMARY KEY IDENTITY(1,1),
    UserLogin NVARCHAR(50) NOT NULL,
    UserPassword NVARCHAR(50) NOT NULL,
	IsAdmin BIT DEFAULT 0
);

CREATE TABLE Loans (
    LoanID INT PRIMARY KEY IDENTITY(1,1),
    RegistrationID INT NOT NULL FOREIGN KEY REFERENCES Registration(RegistrationID),
    BookID INT NOT NULL FOREIGN KEY REFERENCES Books(BookID),
    LoanDate DATE DEFAULT GETDATE(),
    ReturnDate DATE NULL,
    IsReturned BIT DEFAULT 0
);


INSERT INTO Books (Title, Author, Genre, PublishedYear, ISBN, CopiesAvailable)
VALUES 
('To Kill a Mockingbird', 'Harper Lee', 'Fiction', 1960, '978-0-06-112008-4', 3),
('1984', 'George Orwell', 'Dystopian', 1949, '978-0-452-28423-4', 5),
('The Great Gatsby', 'F. Scott Fitzgerald', 'Classic', 1925, '978-0-7432-7356-5', 2),
('Moby Dick', 'Herman Melville', 'Adventure', 1851, '978-0-14-243724-7', 1),
('Pride and Prejudice', 'Jane Austen', 'Romance', 1813, '978-0-19-953556-9', 4);

INSERT INTO Registration (UserLogin, UserPassword, IsAdmin) VALUES
('admin', 'admin', 1),
('user', 'user', 0);

INSERT INTO Loans (RegistrationID, BookID, LoanDate, ReturnDate, IsReturned)
VALUES 
(1, 1, '2023-11-01', '2023-11-10', 1),
(1, 2, '2023-11-03', NULL, 0),
(1, 3, '2023-10-15', '2023-10-25', 1),
(1, 4, '2023-11-04', NULL, 0),
(1, 5, '2023-09-20', '2023-09-30', 1);

CREATE TRIGGER trg_UpdateCopiesAvailable
ON Loans
AFTER UPDATE
AS
BEGIN
    IF UPDATE(IsReturned)
    BEGIN
        UPDATE Books
        SET CopiesAvailable = CASE 
            WHEN l.IsReturned = 1 AND i.IsReturned = 0 THEN CopiesAvailable + 1  -- Книга возвращена
            WHEN l.IsReturned = 0 AND i.IsReturned = 1 THEN CopiesAvailable - 1  -- Книга выдана
            ELSE CopiesAvailable 
        END
        FROM Books b
        INNER JOIN Inserted i ON i.BookID = b.BookID
        INNER JOIN Deleted l ON l.LoanID = i.LoanID
        WHERE i.BookID = b.BookID;
    END
END;

SELECT * FROM Books;
SELECT * FROM Loans;
SELECT * FROM Registration;

DROP DATABASE LibraryDB;
CREATE DATABASE NepoCodersDB;
USE NepoCodersDB;

-- Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) CHECK (Role IN ('Admin','Student')) NOT NULL
);

-- Resources Table
CREATE TABLE Resources (
    ResourceID INT PRIMARY KEY IDENTITY(1,1),
    ResourceName NVARCHAR(100) NOT NULL,
    Quantity INT CHECK (Quantity >= 0) NOT NULL,
    Category NVARCHAR(50) NOT NULL
);

-- Budgets Table
CREATE TABLE Budgets (
    BudgetID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Amount DECIMAL(10,2) NOT NULL,
    Period NVARCHAR(20) CHECK (Period IN ('Daily','Weekly','Monthly')) NOT NULL,
    TransactionDate DATETIME DEFAULT GETDATE(),
    Balance DECIMAL(10,2),
    Description NVARCHAR(100)
);

-- Transactions Table
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    ResourceID INT FOREIGN KEY REFERENCES Resources(ResourceID),
    DateIssued DATETIME DEFAULT GETDATE()
);
INSERT INTO Users (Username, PasswordHash, Role)
VALUES ('admin', '1234', 'Admin');

INSERT INTO Resources (ResourceName, Quantity, Category)
VALUES
('CannedGoods', 20, 'Food'),
('Coffee', 15, 'Beverage'),
('RicePack', 30, 'Food');
select * from Users;
select * from Resources;
select * from Budgets;
select * from Transactions;
-- Create and use your database
CREATE DATABASE assign;
GO
USE assign;
GO

-- Departments table
CREATE TABLE Departments (
  DepartmentID INT PRIMARY KEY,
  DepartmentName VARCHAR(100)
);

-- Employees table
CREATE TABLE Employees (
  EmployeeID INT PRIMARY KEY IDENTITY(1,1),
  FirstName VARCHAR(50),
  LastName VARCHAR(50),
  DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
  Salary DECIMAL(10,2),
  JoinDate DATE
);

-- Insert Departments
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

-- Insert Employees
INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 5000.00, '2020-01-15'),
('Jane', 'Smith', 2, 6000.00, '2019-03-22'),
('Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
('Emily', 'Davis', 4, 5500.00, '2021-11-05');

GO -- 

CREATE PROCEDURE sp_InsertEmployee
  @FirstName VARCHAR(50),
  @LastName VARCHAR(50),
  @DepartmentID INT,
  @Salary DECIMAL(10,2),
  @JoinDate DATE
AS
BEGIN
  INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
  VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO
EXEC sp_InsertEmployee 'Alice', 'Walker', 3, 6200.00, '2022-10-01';
GO
SELECT * FROM Employees;


GO

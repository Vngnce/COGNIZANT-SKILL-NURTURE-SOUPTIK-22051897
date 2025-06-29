-- Create and use your database
CREATE DATABASE assign;
GO
USE assign;
GO


-- ✅ Exercise 5: Count Employees by Department
CREATE PROCEDURE sp_CountEmployeesByDepartment
  @DepartmentID INT
AS
BEGIN
  SELECT COUNT(*) AS TotalEmployees
  FROM Employees
  WHERE DepartmentID = @DepartmentID;
END;
GO

-- Example run of Exercise 5
EXEC sp_CountEmployeesByDepartment @DepartmentID = 3;
GO
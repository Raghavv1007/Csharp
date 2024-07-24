CREATE DATABASE Employeemanagement;
GO

-- Use the database
USE Employeemanagement;
GO

-- Create the table
CREATE TABLE Employee_Details (
    Empno INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Empsal NUMERIC(10, 2) CHECK (Empsal >= 25000),
    Emptype CHAR(1) CHECK (Emptype IN ('F', 'P'))
);
GO

-- Create the stored procedure
CREATE PROCEDURE sp_AddEmployee
    @EmpName VARCHAR(50),
    @Empsal NUMERIC(10, 2),
    @Emptype CHAR(1)
AS
BEGIN
    -- Generate a new Empno
    DECLARE @Empno INT = (SELECT ISNULL(MAX(Empno), 0) + 1 FROM Employee_Details);

    -- Insert the new employee details
    INSERT INTO Employee_Details (Empno, EmpName, Empsal, Emptype)
    VALUES (@Empno, @EmpName, @Empsal, @Emptype);
END;
GO

-- Execute the procedure
EXEC sp_AddEmployee 'John Doe', 30000.00, 'F';
GO

-- Verify the data
SELECT * FROM Employee_Details;
GO
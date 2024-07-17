create database assesment01;

use Assignment2

-- Display your birthday (day of week)
DECLARE @birthday DATE = '2001-01-07';
SELECT DATENAME(weekday, @birthday) AS Birthday_Day;
 
 
--Display your age in days
DECLARE @birthday DATE = '2001-01-07';
SELECT DATEDIFF(day, @birthday, GETDATE()) AS Age_In_Days;

--Who joined before 5 years in the current month
SELECT *
FROM EMP
WHERE YEAR(HIREDATE) <= YEAR(GETDATE()) - 5
AND MONTH(HIREDATE) = MONTH(GETDATE());

SELECT *
FROM EMP
WHERE YEAR(HIREDATE) <= 1985
AND MONTH(HIREDATE) = 12;

CREATE TABLE Employee (
  empno INT,
  ename VARCHAR(255),
  sal DECIMAL(10, 2),
  doj DATE
);

BEGIN TRAN;

-- a. First insert 3 rows
INSERT INTO Employee (empno, ename, sal, doj)
VALUES
  (1, 'John', 1000.00, '2020-01-01'),
  (2, 'Mary', 2000.00, '2020-02-01'),
  (3, 'David', 3000.00, '2020-03-01');

 --second row sal with 15% increment
UPDATE Employee
SET sal = sal * 1.15
WHERE empno = 2;

SAVE TRAN before_deletion;

-- Delete first row
DELETE FROM Employee
WHERE empno = 1;


ROLLBACK TRAN  before_deletion;


COMMIT TRAN ;


SELECT * FROM Employee;


CREATE FUNCTION CalculateBonus (@deptno INT, @sal DECIMAL(10, 2))
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @bonus DECIMAL(10, 2)

    IF @deptno = 10
        SET @bonus = @sal * 0.15
    ELSE IF @deptno = 20
        SET @bonus = @sal * 0.20
    ELSE
        SET @bonus = @sal * 0.05

    RETURN @bonus
END
GO

SELECT empno, ename, sal, deptno, dbo.CalculateBonus(deptno, sal) AS bonus
FROM EMP;
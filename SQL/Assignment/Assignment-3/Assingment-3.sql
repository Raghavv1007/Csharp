--Assignment 3
use Assignment2
--que1.Retrieve a list of MANAGERS. 
select * from EMP where job='MANAGER'

--que2.Find out the names and salaries of all employees earning more than 1000 per month.
select ename 'Employee Name',sal 'Salary' from EMP where sal>1000

use Assignment2
--que1.Retrieve a list of MANAGERS. 
select * from EMP where job='MANAGER'

--que2.Find out the names and salaries of all employees earning more than 1000 per month.
select ename 'Employee Name',sal 'Salary' from EMP where sal>1000

--que3.Display the names and salaries of all employees except JAMES. 
select ename 'Employee Name',sal 'Salary' from EMP where ename != 'JAMES'

--que4.Find out the details of employees whose names begin with �S�. 
select * from EMP where ename like 'S%'

--que5.Find out the names of all employees that have �A� anywhere in their name. 
select ename 'Employee Name' from EMP where ename like '%A%'

--que6.Find out the names of all employees that have �L� as their third character in their name. 
select ename 'Employee Name' from EMP where ename like '__L%'

--que7.Compute daily salary of JONES. 
select ename 'Employee Name',sal 'Salary',sal/30 'Daily Salary' from EMP where ename = 'JONES'

--que8.Calculate the total monthly salary of all employees. 
select SUM(sal) 'Total Monthly salary of all Employees' from EMP

--que9.Print the average annual salary . 
declare @avgannualsal  float
set @avgannualsal = (select AVG(sal*12) from EMP)
print 'Average annual salary is : ' + cast(@avgannualsal as varchar(30))

--que10.Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select ename 'Employee Name',job 'Employee Job',sal 'Salary',deptno 'Employee Department Number'  
from EMP where job != 'SALESMAN' and deptno != 30

--que11.List unique departments of the EMP table. 
select distinct Emp.deptno 'Unique Departments numbers' ,DEPT.dname 'Unique Departments Names' 
from EMP join DEPT on EMP.deptno=DEPT.deptno

--que12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
--Label the columns Employee and Monthly Salary respectively.
select ename 'Employee',sal 'Monthly Salary' from EMP where sal > 1500 and deptno in (10,30)

--que13.Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename 'Name',job 'Job',sal 'Salary' from EMP
where job in ('MANAGER','ANALYST') and sal not in (1000, 3000,5000)

--que14.Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
select ename 'Name',sal 'Salary',comm 'Commission' from EMP
where comm > sal+(sal*0.1)

--que15.Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
select empno 'Employee ID',ename 'Employee Name',deptno 'Department No',mgr_id 'Manager Id' from EMP
where ename like '%L%L%' and deptno=30 or mgr_id=7782

--que16.Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 
select ename 'Employee Name',datediff(yy,hiredate,getdate()) 'Years of Experience' from EMP
where datediff(yy,hiredate,getdate()) between 30 and 40

select count(*)'Total Number of employees with experience of over 30 years and under 40 yrs are' from EMP
where datediff(yy,hiredate,getdate()) between 30 and 40

--que17.Retrieve the names of departments in ascending order and their employees in descending order. 
select d.dname 'Name Of Department',e.empno'Employee Number',e.ename 'Employee Name' from DEPT d join EMP e on d.deptno=e.deptno
order by d.dname asc,e.ename desc

--que18.Find out experience of MILLER. 
select empno 'Employee ID',ename 'Employee Name',datediff(yy,hiredate,getdate()) 'Years of Experience' from EMP
where ename = 'MILLER'
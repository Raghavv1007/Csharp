using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_4CCC4
{ 
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

            //Detail of all the employees
            Console.WriteLine("All Employees:");
            foreach (var emp in empList)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToString("dd/MM/yyyy")}, DOJ: {emp.DOJ.ToString("dd/MM/yyyy")}, City: {emp.City}");
            }

         //employees whose location is not Mumbai
            Console.WriteLine("\nEmployees not in Mumbai:");
            var notInMumbai = empList.Where(e => e.City != "Mumbai");
            foreach (var emp in notInMumbai)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB.ToString("dd/MM/yyyy")}, DOJ: {emp.DOJ.ToString("dd/MM/yyyy")}, City: {emp.City}");
            }

            // c. Display details of all the employee whose title is AsstManager
            Console.WriteLine("\nEmployees with Title AsstManager:");
            var asstManagers = empList.Where(e => e.Title == "AsstManager");
            foreach (var emp in asstManagers)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }

            // d. Display details of all the employee whose Last Name start with S
            Console.WriteLine("\nEmployees with Last Name starting with S:");
            var lastNameStartsWithS = empList.Where(e => e.LastName.StartsWith("S"));
            foreach (var emp in lastNameStartsWithS)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, FirstName: {emp.FirstName}, LastName: {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");
            }



            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
    }

    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            
            employees.Add(new Employee { EmpId = 1, EmpName = "Raghav", EmpCity = "Bangalore", EmpSalary = 40000m });
            employees.Add(new Employee { EmpId = 2, EmpName = "Abhishek", EmpCity = "Chennai", EmpSalary = 24000m });
            employees.Add(new Employee { EmpId = 3, EmpName = "Nithin", EmpCity = "Bangalore", EmpSalary = 25000m });
            employees.Add(new Employee { EmpId = 4, EmpName = "Santosh", EmpCity = "Hyderabad", EmpSalary = 30000m });

            // Display all employees data
            Console.WriteLine("All employees data:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary}");
            }

          
            Console.WriteLine("\nEmployees with salary greater than 45000:");
            foreach (var employee in employees.Where(e => e.EmpSalary > 45000m))
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary}");
            }

            
            Console.WriteLine("\nEmployees from Bangalore:");
            foreach (var employee in employees.Where(e => e.EmpCity == "Bangalore"))
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary}");
            }

          
            Console.WriteLine("\nEmployees by name in Ascending order:");
            foreach (var employee in employees.OrderBy(e => e.EmpName))
            {
                Console.WriteLine($"EmpId: {employee.EmpId}, EmpName: {employee.EmpName}, EmpCity: {employee.EmpCity}, EmpSalary: {employee.EmpSalary}");
                Console.ReadLine();
            }
        }

    }
}
   
        
        
    
  
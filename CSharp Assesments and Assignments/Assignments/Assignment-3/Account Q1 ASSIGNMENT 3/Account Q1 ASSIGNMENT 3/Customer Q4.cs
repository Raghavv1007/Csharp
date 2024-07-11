using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Q1_ASSIGNMENT_3
{
    class Customer_Q4

    {
        public class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Phone { get; set; }
            public string City { get; set; }

            // Constructor with no arguments
            public Customer()
            {
                CustomerId = 0;
                Name = "Unknown";
                Age = 0;
                Phone = "Not available";
                City = "Unknown";
            }

            // Constructor 
            public Customer(int customerId, string name, int age, string phone, string city)
            {
                CustomerId = customerId;
                Name = name;
                Age = age;
                Phone = phone;
                City = city;
            }

            // Method to display customer information
            public void DisplayCustomer()
            {
                Console.WriteLine($"Customer ID: {CustomerId}");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Phone: {Phone}");
                Console.WriteLine($"City: {City}");
            }

            // Destructor (finalizer)
            ~Customer()
            {
                Console.WriteLine($"Destructor called for customer {CustomerId} - {Name}");
                // Cleanup resources if needed
            }

            // Static method to display customer 
            public static void DisplayCustomerStatic(int customerId, string name, int age, string phone, string city)
            {
                Console.WriteLine($"Customer ID: {customerId}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"City: {city}");
            }

            // Main method 
            public static void Main()
            {
                // Create an instance of Customer using constructor with all information
                Customer customer1 = new Customer(1, "Raghav Garg", 23, "9695834408", "Delhi");

                // Display customer using instance method
                Console.WriteLine("Displaying customer using instance method:");
                customer1.DisplayCustomer();

                Console.WriteLine();

                
                Console.WriteLine("Displaying customer using static method:");
                DisplayCustomerStatic(2, "Abhay", 25, "987-654-3210", "Lucknow");

                // Demonstrate destructor
                Console.WriteLine("\nDemonstrating destructor:");
                Customer customer2 = new Customer(3, "Abhay", 32, "887-878-6767", "Banglore");
                Console.ReadLine();
               
            }
        }
    }

}


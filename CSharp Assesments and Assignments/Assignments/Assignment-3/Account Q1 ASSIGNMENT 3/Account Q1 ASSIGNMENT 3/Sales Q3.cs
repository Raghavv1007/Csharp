using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Q1_ASSIGNMENT_3
{
    class Sales_Q3



    {
        public class Saledetails
        {
            private int salesNo;
            private int productNo;
            private decimal price;
            private DateTime dateOfSale;
            private int qty;
            private decimal totalAmount;

            // Constructor to initialize sales details
            public Saledetails(int salesNo, int productNo, decimal price, DateTime dateOfSale, int qty)
            {
                this.salesNo = salesNo;
                this.productNo = productNo;
                this.price = price;
                this.dateOfSale = dateOfSale;
                this.qty = qty;

                // Calculate total amount
                Sales();
            }

            // Method to calculate total amount based on quantity and price
            public void Sales()
            {
                totalAmount = qty * price;
            }

            // Method to display sale details
            public void ShowData()
            {
                Console.WriteLine($"Sales No: {salesNo}");
                Console.WriteLine($"Product No: {productNo}");
                Console.WriteLine($"Price: {price:C}");
                Console.WriteLine($"Date of Sale: {dateOfSale.ToShortDateString()}");
                Console.WriteLine($"Quantity: {qty}");
                Console.WriteLine($"Total Amount: {totalAmount:C}");
            }

            // Main method for demonstration
            public static void Main()
            {
                // Example usage
                Saledetails sale1 = new Saledetails(2098, 78372, 50.75m, DateTime.Today, 5);
                sale1.ShowData();
                Console.ReadLine();
            }
        }

    }
}
    

    
    
 
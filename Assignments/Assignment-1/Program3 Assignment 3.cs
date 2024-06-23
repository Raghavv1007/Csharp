using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program3_Assignment_3
         
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int secondnumber = int.Parse(Console.ReadLine());

            int subtractionResult = firstnumber - secondnumber;
            Console.WriteLine($"Subtraction: { firstnumber} - {secondnumber} ={subtractionResult}");

            int additionResult = firstnumber + secondnumber;
            Console.WriteLine($"Addition: {firstnumber} + {secondnumber} = {additionResult}");

            int multiplicationResult = firstnumber * secondnumber;
            Console.WriteLine($"{firstnumber} * {secondnumber} = {multiplicationResult}");

            int division = firstnumber / secondnumber;
            Console.WriteLine($"division: {firstnumber} / {secondnumber} = { division}");


            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();

        }
    }
}





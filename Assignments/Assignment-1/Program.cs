using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {


        static void Main()
        {

            Console.WriteLine("Enter the first integer:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int secondNumber = int.Parse (Console.ReadLine());


            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The two integers are equal.");
            }
            else
            {
                Console.WriteLine("The two integers are not equal.");
            }
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }

}

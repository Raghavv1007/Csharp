using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Test_Q4
{
    class Program
    {
        
    
        
            static void Main()
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication table of {number}:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
                Console.ReadLine();
            }
        }
    }
}
    



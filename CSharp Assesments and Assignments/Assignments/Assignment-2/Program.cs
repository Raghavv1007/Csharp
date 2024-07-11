using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESMENT_2_SOLUTION
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("first integer:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("second integer:");
            int num2 = int.Parse(Console.ReadLine());


            int result = ComputeSumOrTriple(num1, num2);

            Console.WriteLine("The result is: " + result);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static int ComputeSumOrTriple(int a, int b)
        {
            if (a == b)
            {
                return 3 * (a + b);
            }
            else
            {
                return a + b;
            }
        }
    }

}    


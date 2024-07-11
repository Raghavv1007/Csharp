using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net_Test_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLargest(1, 2, 3));
            Console.WriteLine(FindLargest(1, 3, 2));
            Console.WriteLine(FindLargest(1, 1, 1)); 
            Console.WriteLine(FindLargest(1, 2, 2));
            Console.ReadLine();
        }


        static int FindLargest(int a, int b, int c)
        {
            int largest = a;

            if (b > largest)
            {
                largest = b;
            }

            if (c > largest)
            {
                largest = c;
            }

            return largest;
        }
    }
}


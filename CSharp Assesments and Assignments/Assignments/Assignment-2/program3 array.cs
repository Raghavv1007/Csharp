using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESMENT_2_SOLUTION
{
    class program3_array
    {
        static void Main()
        {
             int[] array = { 20, 30, 40, 50, 60 };
             double average = array.Average();
            
            int min = array.Min();
            int max = array.Max();

            
            Console.WriteLine("The average value of the array elements is: " + average);
            Console.WriteLine("The minimum value in the array is: " + min);
            Console.WriteLine("The maximum value in the array is: " + max);
            Console.ReadLine();
        }
    }
}


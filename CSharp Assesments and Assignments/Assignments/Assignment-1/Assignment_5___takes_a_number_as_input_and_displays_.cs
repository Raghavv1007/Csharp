using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Assignment_5___takes_a_number_as_input_and_displays_
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Enter a digit:");
                int number = int.Parse(Console.ReadLine());


                Console.WriteLine(number + " " + number + " " + number + " " + number);
                Console.WriteLine("" + number + number + number + number);
                Console.WriteLine(number + " " + number + " " + number + " " + number);
                Console.WriteLine("" + number + number + number + number);
                Console.ReadLine(); //hold Output Screen
            }

        }
    }
}


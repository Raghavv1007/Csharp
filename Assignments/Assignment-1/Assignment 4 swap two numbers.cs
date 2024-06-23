using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Assignment_4_swap_two_numbers
    {
        class Program
        {


            static void Main()
            {
                int a, b, temp;

                Console.WriteLine("Num 1 (a):");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Num 2 (b):");
                b = int.Parse(Console.ReadLine());


                temp = a;
                a = b;
                b = temp;

                Console.WriteLine($"After swapping, Num 1 (a): {a}");
                Console.WriteLine($"After swapping, Num 2 (b): {b}");

                Console.ReadLine();
            }
        }



    }



}


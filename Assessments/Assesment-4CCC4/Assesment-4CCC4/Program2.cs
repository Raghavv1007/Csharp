using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_4CCC4
{
    class Program2
    {
        public delegate int Calculator(int x, int y);

        public static int Add(int x, int y) { return x + y; }
        public static int Subtract(int x, int y) { return x - y; }
        public static int Multiply(int x, int y) { return x * y; }

        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Calculator add = Add;
            Calculator subtract = Subtract;
            Calculator multiply = Multiply;

            Console.WriteLine("Addition: " + add(num1, num2));
            Console.WriteLine("Subtraction: " + subtract(num1, num2));
            Console.WriteLine("Multiplication: " + multiply(num1, num2));
            Console.ReadLine();
        }

    }
}


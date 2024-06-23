using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Test_Q2
{
    class Program

    {
        static string ExchangeFirstLast(string input)
        {
            if (input.Length < 2)
            {
                return input;
            }

            char[] charArray = input.ToCharArray();

            char firstChar = charArray[0];
            char lastChar = charArray[input.Length - 1];

            charArray[0] = lastChar;
            charArray[input.Length - 1] = firstChar;

            string result = new string(charArray);

            return result;




        }


        static void Main()
        {
            Console.WriteLine(ExchangeFirstLast("abcd"));
            Console.WriteLine(ExchangeFirstLast("a"));
            Console.WriteLine(ExchangeFirstLast("xy"));
            Console.ReadLine();
        }
    }
}

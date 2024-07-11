using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Test_1_Q1
{
    class Program
    {
        static void Main()
        {
            string result1 = RemoveCharacter("Python", 1);
            string result2 = RemoveCharacter("Python", 0);
            string result3 = RemoveCharacter("Python", 4);


            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();

        }

        static string RemoveCharacter(string str, int position)
        {
            if(position < 0 || position >= str.Length)
            {
                throw new ArgumentOutOfRangeException("position", "Position is out of range.");

            }

            string result = str.Remove(position, 1); 

            return result;
        }
        
        
    }
}

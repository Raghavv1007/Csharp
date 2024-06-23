using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESMENT_2_SOLUTION
{
    class String_Q3
    
       
    {
        static void Main()
        {
            Console.Write(" first word: ");
            string word1 = Console.ReadLine();

            Console.Write(" second word: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The two words are the same.");
            }
            else
            {
                Console.WriteLine("The two words are not the same.");
                Console.ReadLine();
            }
        }
    }
}


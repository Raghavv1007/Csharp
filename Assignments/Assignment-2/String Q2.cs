using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESMENT_2_SOLUTION
{
    class String_Q2
    {
     
    
        static void Main()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string reversedWord = new string(arr);

            Console.WriteLine("The reverse of the word is: " + reversedWord);
            Console.ReadLine();
        }
    }
}


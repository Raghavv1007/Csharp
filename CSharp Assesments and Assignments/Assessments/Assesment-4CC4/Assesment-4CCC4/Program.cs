using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assesment_4CCC4
{
    class Program
    {
        static void Main()
        {
            string filePath = "test.txt";
            string appendedText = "Raghav Garg.";

            // Append text to the file
            using (StreamWriter writer = new StreamWriter)
            {
                writer.WriteLine(appendedText);
            }

            Console.WriteLine("Raghav Garg.");
            Console.ReadLine();
        }
    }
}

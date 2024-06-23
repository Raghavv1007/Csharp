using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESMENT_2_SOLUTION
{
    class Program2
    {

        static void Main()
        {
            Console.Write("Enter a day number (1-7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string dayName = "";

            switch (dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wenesday";
                    break;
                case 4:
                    dayName = "Thrusday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }

            Console.WriteLine(dayName);
            Console.ReadLine();
        }

    }
}
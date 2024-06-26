using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2CC2
{
    class Program
    {
        // Abstract class 
        public abstract class Student
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public double Grade { get; set; }

            public abstract bool IsPassed(double grade);
        }

        // Undergraduate
        public class Undergraduate : Student
        {
            public override bool IsPassed(double grade)
            {
                return grade > 70.0;
            }
        }

        // Graduate
        public class Graduate : Student
        {
            public override bool IsPassed(double grade)
            {
                return grade > 80.0;
            }
        }

            static void Main(string[] args)
            {
                Undergraduate ug = new Undergraduate { Name = "Raghav", StudentId = 1035475, Grade = 85.0 };
                Graduate g = new Graduate { Name = "Nithin", StudentId = 1035476, Grade = 65.0 };

                Console.WriteLine($"{ug.Name} is {(ug.IsPassed(ug.Grade) ? "passed" : "not passed")}");
                Console.WriteLine($"{g.Name} is {(g.IsPassed(g.Grade) ? "passed" : "not passed")}");
                Console.ReadLine();
            }
        

        
        
        
    }
}

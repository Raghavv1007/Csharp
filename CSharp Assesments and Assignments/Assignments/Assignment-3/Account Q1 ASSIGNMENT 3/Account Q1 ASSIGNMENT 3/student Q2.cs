using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Q1_ASSIGNMENT_3
{
    class student_Q2
       


    {
        public class Student_Marks_Q2
        {
            private int rollNo;
            private string name;
            private string className;
            private string semester;
            private string branch;
            private int[] marks = new int[5]; // Marks for 5 subjects

            // Constructor to initialize student details
            public Student_Marks_Q2(int rollNo, string name, string className, string semester, string branch)
            {
                this.rollNo = rollNo;
                this.name = name;
                this.className = className;
                this.semester = semester;
                this.branch = branch;
            }

            // Method to input marks for all 5 subjects
            public void GetMarks(int[] subjectMarks)
            {
                if (subjectMarks.Length == 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        marks[i] = subjectMarks[i];
                    }
                }
                else
                {
                    Console.WriteLine("Error: Expected marks for 5 subjects.");
                }
            }

            // Method to calculate average marks and display result
            public void DisplayResult()
            {
                bool failed = false;
                double average = CalculateAverage();

                // Check if any subject has marks less than 35
                foreach (int mark in marks)
                {
                    if (mark < 35)
                    {
                        failed = true;
                        break;
                    }
                }

                // Check average marks criteria
                if (average > 50)
                {
                    Console.WriteLine("Result: Passed");
                }
                else if (average >= 35 && average < 50)
                {
                    Console.WriteLine("Result: Failed (Average is less than 50)");
                }
                else if (failed)
                {
                    Console.WriteLine("Result: Failed (One or more subjects have less than 35 marks)");
                }
                else
                {
                    Console.WriteLine("Result: Failed (Average is less than 35)");
                }
            }

            // Method to calculate average marks
            private double CalculateAverage()
            {
                int sum = 0;
                foreach (int mark in marks)
                {
                    sum += mark;
                }
                return (double)sum / marks.Length;
            }

            // Method to display student data
            public void DisplayData()
            {
                Console.WriteLine($"Roll No: {rollNo}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Class: {className}");
                Console.WriteLine($"Semester: {semester}");
                Console.WriteLine($"Branch: {branch}");
                Console.WriteLine("Marks:");
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine($"Subject {i + 1}: {marks[i]}");
                    
                }
            }

            // Example of usage in Main method
            public static void Main()
            {
                // Create a student object
                Student_Marks_Q2 student1 = new Student_Marks_Q2(15, "Raghav Garg", "10th", "June 2024", "Science");

                // Set marks for subjects
                int[] marks = { 65, 72, 50, 40, 55 };
                student1.GetMarks(marks);

                // Display student data
                student1.DisplayData();

                // Display result based on marks
                student1.DisplayResult();
                Console.ReadLine();
            }
        }
    }

    
}


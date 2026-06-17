using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();
        List<int> g1 = new List<int>();
        List<int> g2 = new List<int>();
        List<int> g3 = new List<int>();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\n===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Compute Average Grade");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.WriteLine("==========================");

            Console.Write("Choose an option: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                Console.Write("Enter grade 1: ");
                int grade1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter grade 2: ");
                int grade2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter grade 3: ");
                int grade3 = Convert.ToInt32(Console.ReadLine());

                names.Add(name);
                g1.Add(grade1);
                g2.Add(grade2);
                g3.Add(grade3);

                Console.WriteLine("Student added successfully!");
            }

            else if (choice == 2)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    double average = (g1[i] + g2[i] + g3[i]) / 3.0;

                    Console.WriteLine("\nName: " + names[i]);
                    Console.WriteLine("Grades: " + g1[i] + ", " + g2[i] + ", " + g3[i]);
                    Console.WriteLine("Average: " + average.ToString("F2"));
                }
            }

            else if (choice == 3)
            {
                double total = 0;

                for (int i = 0; i < names.Count; i++)
                {
                    total = total + ((g1[i] + g2[i] + g3[i]) / 3.0);
                }

                double classAverage = total / names.Count;

                Console.WriteLine("\n===== CLASS AVERAGE =====");
                Console.WriteLine("Overall Average Grade: " + classAverage.ToString("F2"));
            }

            else if (choice == 4)
            {
                int highestGrade = 0;
                string topStudent = "";

                for (int i = 0; i < names.Count; i++)
                {
                    if (g1[i] > highestGrade)
                    {
                        highestGrade = g1[i];
                        topStudent = names[i];
                    }

                    if (g2[i] > highestGrade)
                    {
                        highestGrade = g2[i];
                        topStudent = names[i];
                    }

                    if (g3[i] > highestGrade)
                    {
                        highestGrade = g3[i];
                        topStudent = names[i];
                    }
                }

                Console.WriteLine("\n===== HIGHEST GRADE =====");
                Console.WriteLine("Top Student: " + topStudent);
                Console.WriteLine("Highest Grade: " + highestGrade);
            }

            else if (choice == 5)
            {
                Console.WriteLine("Exiting program...");
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid option!");
            }
        }
    }
}
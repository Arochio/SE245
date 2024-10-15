/*
Cooper Graves
SE245
10/10/2024
Lab 2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            String stuFirstName, stuLastName, gradesConcat, newStudent, currentGrade, letterGrade;
            Double currentAverage;
            List<String> names = [];
            List<String> grades = [];
            List<Double> averages = [];
            do {
                Console.Write("Enter the student's first name:");
                stuFirstName = Console.ReadLine();
                Console.Write("Enter the student's Last name:");
                stuLastName = Console.ReadLine();
                names.Add((stuFirstName + stuLastName));
                currentAverage = 0;
                gradesConcat = "";
                for (int i = 0; i < 5; i++) {
                    Console.Write("Enter grade #" + (i+1) + ": ");
                    currentGrade = Console.ReadLine();
                    gradesConcat += currentGrade + "    ";
                    currentAverage += Double.Parse(currentGrade);
                }
                grades.Add(gradesConcat);
                averages.Add(currentAverage);
                Console.Write("Do you want to add another student? [yes/no]: ");
                newStudent = Console.ReadLine().ToLower();
            } while (newStudent == "yes");
            foreach (string i in names) {
                int ii = 0;
                averages[ii] = (averages[ii] / 5);
                if (averages[ii] >= 90) {
                    letterGrade = "A";
                }
                else if (averages[ii] >= 80) {
                    letterGrade = "B";
                }
                else if (averages[ii] >= 70) {
                    letterGrade = "C";
                }
                else if (averages[ii] >= 60) {
                    letterGrade = "D";
                }
                else {
                    letterGrade = "F";
                }
                Console.WriteLine(names[ii]);
                Console.WriteLine(grades[ii]);
                Console.WriteLine(averages[ii]);
                Console.WriteLine(letterGrade);
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                ii += 1;
            }
        }
    }
}
/*
Cooper Graves
SE245
10/17/2024
Lab 3
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Lab
{
    class Program
    {
        static void labAvg(List<String> gradesRef, List<Double> labAveragesRef) {
            List<String> splitGrades = [];

            for (int j = 0; j < gradesRef.Count; j++) {

                for (int i = 0; i < 5; i++) {
                    splitGrades = gradesRef[j].Split(',',' ').ToList();
                    // splitGrades.RemoveAt(0);
                    double tempAvgs = 0;
                    labAveragesRef[i] += Convert.ToDouble(splitGrades[i]);

                }
                
            }
            for (int i = 0; i < 5; i++) {
                labAveragesRef[i] = labAveragesRef[i] / gradesRef.Count;
            }
        }
        static String letterGrd(Double numGrade) {
            String letGrade;
            if (numGrade >= 90) {
                letGrade = "A";
            }
            else if (numGrade >= 80) {
                letGrade = "B";
            }
            else if (numGrade >= 70) {
                letGrade = "C";
            }
            else if (numGrade >= 60) {
                letGrade = "D";
            }
            else {
                letGrade = "F";
            }
            return letGrade;
        }
        static void printRslts(List<String> namesRef, List<String> gradesRef, List<String> stuAvgsRef, List<String> letterGradesRef, List<Double> labAverages) { 
            for (int i = 0; i < namesRef.Count; i++) {
                stuAvgsRef[i] = Convert.ToString(Double.Parse(stuAvgsRef[i]) / 5);
                Console.WriteLine("\nStudent: " + namesRef[i]);
                Console.WriteLine("Lab grades: " + gradesRef[i]);
                Console.WriteLine("Student\'s average grade: " + stuAvgsRef[i] + "(" + letterGradesRef[i] + ")\n");
            }
            
        }
        static void Main(string[] args)
        {
            String stuFirstName, stuLastName, gradesConcat, newStudent, currentGrade, letterGrade = "", lGradeTemp;
            Double currentAverage;
            List<String> names = [];
            List<String> grades = [];
            List<String> letterGrades = [];
            List<String> stuAvgs = [];
            List<Double> labAverages = [0,0,0,0,0];
            List<String> avgsOutput = [];
            do {
                Console.Write("Enter the student's first name: ");
                stuFirstName = Console.ReadLine();
                Console.Write("Enter the student's Last name: ");
                stuLastName = Console.ReadLine();
                names.Add((stuFirstName + " " + stuLastName));
                currentAverage = 0;
                gradesConcat = "";

                for (int i = 0; i < 5; i++) {
                    Console.Write("Enter grade #" + (i+1) + ": ");
                    currentGrade = Console.ReadLine();
                    gradesConcat += ("," + currentGrade);
                    currentAverage += Double.Parse(currentGrade);
                }

                gradesConcat = gradesConcat.TrimStart(',');

                grades.Add(gradesConcat);
                stuAvgs.Add(Convert.ToString(currentAverage));
                Console.Write("Do you want to add another student? [yes/no]: ");
                newStudent = Console.ReadLine().ToLower();

            } while (newStudent == "yes");

            for (int i = 0; i < stuAvgs.Count; i++) {
                lGradeTemp = letterGrd(Double.Parse(stuAvgs[i]));
                letterGrades.Add(lGradeTemp);
            }

            labAvg(grades, labAverages);
            printRslts(names, grades, stuAvgs, letterGrades, labAverages);
            for (int i = 0; i < labAverages.Count; i++) {
                Console.WriteLine("Lab #" + (i+1) + ": " + labAverages[i]);
            }
            
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
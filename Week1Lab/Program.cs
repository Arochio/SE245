/*
Cooper Graves
SE245
10/3/2024
Lab 1
*/

// Importing libraries for later use in the code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Variables
            String studentName, gradeOne, gradeTwo, gradeThree, gradeFour, letterGrade;
            Int32 gradeOneInt, gradeTwoInt, gradeThreeInt, gradeFourInt;
            Double averageGrade;

            //Prompt user for name and gather input
            Console.Write("Welcome!\nPlease enter your name: ");
            studentName = Console.ReadLine();

            //Greet user and gather inputs for 4 grades in whole number form, as Strings
            Console.Write($"Nice to meet you {studentName}!\nPlease Enter your first grade as a whole number (ex: 100): ");
            gradeOne = Console.ReadLine();
            Console.Write("Please Enter your second grade as a whole number: ");
            gradeTwo = Console.ReadLine();
            Console.Write("Please Enter your Third grade as a whole number: ");
            gradeThree = Console.ReadLine();
            Console.Write("Please Enter your Fourth grade as a whole number: ");
            gradeFour = Console.ReadLine();

            //Parse grades from strings to Ints
            gradeOneInt = Int32.Parse(gradeOne);
            gradeTwoInt = Int32.Parse(gradeTwo);
            gradeThreeInt = Int32.Parse(gradeThree);
            gradeFourInt = Int32.Parse(gradeFour);

            //Calculate Grade Average
            averageGrade = (gradeOneInt + gradeTwoInt + gradeThreeInt + gradeFourInt) / 4;

            //Determine Letter Grade from Average
            if (averageGrade >= 90) {
                letterGrade = "A";
            }
            else if (averageGrade >= 80) {
                letterGrade = "B";
            }
            else if (averageGrade >= 70) {
                letterGrade = "C";
            }
            else if (averageGrade >= 60) {
                letterGrade = "D";
            }
            else {
                letterGrade = "F";
            }

            //Output results to the user
            Console.WriteLine($"You entered: {gradeOne}%, {gradeTwo}%, {gradeThree}%, and {gradeFour}%");
            Console.WriteLine($"{studentName}, your average grade is {averageGrade}% which is a(n) {letterGrade}");
        }
    }
}
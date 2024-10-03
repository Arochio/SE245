// Importing libraries for later use in the code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing variables in String, Int32, and Double format
            String strFirst, strOperand, strNum2, strNum1;
            Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            Double dblResult = 0;

            //Output welcome message to user
            Console.WriteLine("Hello There!");

            //Prompt user for their name and gather input
            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine();

            //Greet user using strFirst gathered above
            Console.WriteLine("Hello " + strFirst + "! Let's do some math!");

            //Prompt user for the first number and gather input
            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            //Prompt user for their choice of operation and gather input
            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine().ToUpper();

            //Prompt user for the second number and gather input
            Console.Write("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            //Modify gathered inputs into Int32 format from String
            intNum1 = Int32.Parse(strNum1);
            intNum2 = Convert.ToInt32(strNum2);

            //Use switch to determine the proper operation based on user input
            switch (strOperand)
            {
                case "PLUS": //Operation code for Addition with output
                    intResult = intNum1 + intNum2;
                    dblResult = (Double)intResult;
                    Console.WriteLine($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "MINUS": //Operation code for Subtraction with output
                    intResult = intNum1 - intNum2;
                    dblResult = (Double)intResult;
                    Console.WriteLine($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "MULTIPLY": //Operation code for Multiplication with output
                    intResult = intNum1 * intNum2;
                    dblResult = (Double)intResult;
                    Console.WriteLine($"\n\nThe product of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                case "DIVIDE": //Operation code for Division with output
                    dblResult = (Double)intNum1 / (Double)intNum2; //result is stored as a double in case of decimals
                    Console.WriteLine($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
                    break;
                default: //This is reached if there is an invalid choice of operations, will not do any math
                    dblResult = 0;
                    Console.WriteLine("Something bad happened!");
                    break;
            }
            //Prompt user for any key input to end the program
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}
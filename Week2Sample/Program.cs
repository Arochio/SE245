//import libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Sample {
    class Program {
        static void Main (string[] args) {
            //Declare vars
            String strFirst, strNum, strCntr;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false;

            Console.WriteLine ("Averager Program: How many week's earning are you going to average?");
            strCntr = Console.ReadLine (); //Take user input for number of weeks (iterations) to run
            intCntr = Int32.Parse (strCntr); //parse user input into an Int32
            Double[] dblEarnings = new Double[intCntr]; //never used

            //output a title
            Console.WriteLine ("Averager Program: Enter weekly earnings.\n\n");

            for (int intCounter = 0; intCounter < intCntr; intCounter++) { 
            //creates an iterative int, while the int is less than the int value of the user input (# of weeks) increment by 1 each loop
                do {
                    Console.Write ("Please enter payroll #" + (intCounter + 1) + ": "); //accounts for the +1 to offset the index
                    strNum = Console.ReadLine ();
                    blnResult = Double.TryParse (strNum, out dblNum); //determine if string can be parsed as a double and save to bool variable

                    if (blnResult == false) { //if parse failed
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051.00.");
                    }
                    else {
                        dblEarnings[intCounter] = dblNum; //stores individual week's values
                    }
                } while (blnResult == false); //runs while loop once, then checks to see if the input entered in the loop is valid or not, if invalid it will loop again
                dblTotal += dblNum; //add dblNum to the running total
            }

            dblResult = (dblTotal / intCntr); //find the average
            Console.WriteLine ("the average of the weekly earnings entered is: $" + dblResult); //output the resulting average

            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
            //allows user to end the program by pressing a key
        }
    }
}
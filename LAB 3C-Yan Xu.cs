/* LAB 3C - C# - Write your own program-Yan Xu
 * In this assignment you will use your current knowledge of variables and methods to create three programs.  
 * You must create methods in addition to the Main() in the console application.
 * 1. Write a program that calculates tuition over a five year period. 
 *    Tuition starts at $6000 and each year it increases by 2%. 
 *    You will display to the screen the following: "For year n your tuition will be x."
 * 2. Write a program that asks the user for the number of feet to be converted into inches. 
 *    Calculate the number of inches. Display to the user: "n feet is x inches."
 * 3. Write a program that finds the greater of two number entered by the user. 
 *    Display to the screen: "n greater than x."
 */

using System;

namespace LAB3C
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int ask = 1; ; ask++)
            {
                Console.WriteLine("\n Please choose the service you want to start," +
                   "\n Type 1 for Tuition Calculator." +
                   "\n Type 2 for Feet to Inches Calculator." +
                   "\n Type 3 for Greater Number Finder."+
                   "\n Type any other number to exit.");

                int response = int.Parse(Console.ReadLine());

                if (response == 1) TuitionCaculator();
                else if (response == 2) FeetToInches();
                else if (response == 3) FindGreater();
                else break;
            }
                           
        }

        static void TuitionCaculator()
        {
            double initialFee = 6000.00;
            double rate = 1.02;
          

            for (int year=1;year<=5;year++)
            {
                rate += 0.02;
            }
            double newFee = initialFee * rate;
            Console.WriteLine($"For year 5 your tuition will be ${newFee}");
        }

        static void FeetToInches()
        {
            Console.WriteLine("How many feet do you want to covert to inches?");
            int feet = int.Parse(Console.ReadLine());

            int inches = feet * 12;

            Console.WriteLine($"{feet} feet are equal to {inches}inhces.");

        }

        static void FindGreater()
        {
            Console.WriteLine("Please enter two numbers to compare:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            
            if(firstNumber>secondNumber)
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
            }
            else if(firstNumber<secondNumber)
            {
                Console.WriteLine($"{secondNumber} is greater than {firstNumber}");
            }
            else 
            {
                Console.WriteLine($"{firstNumber} is equal to {secondNumber}");
            }

        }
    }
}

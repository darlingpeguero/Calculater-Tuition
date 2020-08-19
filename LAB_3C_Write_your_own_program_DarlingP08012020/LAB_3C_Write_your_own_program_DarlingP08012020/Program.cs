using System;

namespace LAB_3C_Write_your_own_program_DarlingP08012020
{

    //Class:          ERAU ISTA220 Programming Fundamentals
    //Student:        Darling Peguero
    //Instructor:     Christine E Lee, Instructor
    //Date:           08/01/2020

    /****************************************************************************************
    LAB 3C - C# - Write your own program
    1. Write a program that calculates tuition over a five-year period. Tuition starts at $6000 and each year it increases by 2%. You will display to the screen the following: For year n your tuition will be x
    2. Write a program that asks the user for the number of feet to be converted into inches. Calculate the number of inches. Display to the user: n feet is x inches
    3. Write a program that finds the greater of two number entered by the user. Display to the screen: n greater than x

    Revision:

    Revision Date:
    *****************************************************************************************/

    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("WELCOME! Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($"Hello {name}! What would you like to do today?");

            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }


        private static bool MainMenu()
        {

            Console.WriteLine("       Input 1. if you would like to calculate tuition over a five year period.");
            Console.WriteLine("       Input 2. if you would like to convert feet into inches.");
            Console.WriteLine("       Input 3. if you would like to find the greater of two numbers.");
            Console.WriteLine("       Input 4. if you would like to Exit.");

            var input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Great! you would like to calculate tuition over a five year period.");
                Console.WriteLine("Here it is:");
                tuition();
                return true;
            }
            else if (input == "2")
            {
                Console.WriteLine("You have selected to convert feet into inches, here we go!");
                feetInches();
                return true;
            }
            else if (input == "3")
            {
                Console.WriteLine("Awesome! you would like to know which is greater of two numbers.");
                greater();
                return true;
            }
            else if (input == "4")
            {

                Exit();
                return false;
            }
            else
            {
                Console.WriteLine($"{input} is and invalid input, please try again!");
                return true;
            }

        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Are you sure?");
            Console.WriteLine("Y or N?");
            string result = Console.ReadLine();

            if (result == "Y")
            {
                Console.Clear();
                Console.WriteLine("Thank you! Goodbye!");
            }
            else if (result == "y")
            {
                Console.Clear();
                Console.WriteLine("Thank you! Goodbye!");
            }
            else if (result == "N")
            {
                MainMenu();
            }
            else if (result == "n")
            {
                MainMenu();
            }
        }



        static void tuition()
        {
            double tuitionStart = 6000.00;

            double increases = 0.02;


            for (int year = 1; year <= 5; year++)
            {
                if (year == 1)
                {

                    Console.WriteLine($"For Year {year} your tuition will be: {tuitionStart}");
                }
                else
                {
                    double fee = tuitionStart + (tuitionStart * increases * year);
                    Console.WriteLine($"For Year {year} your tuition will be: {fee}");
                }

            }
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadLine();

            MainMenu();
        }


        static void feetInches()
        {
            try
            {
                Console.Write("How many Feet would you like to convert into inches: ");
                double feet = Convert.ToDouble(Console.ReadLine());

                double result = feet * 12;
                Console.WriteLine($"conversion of {feet} feet is {result} inches");
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid Input, you must input a number. Please try again.");
                double feet = Convert.ToDouble(Console.ReadLine());

                double result = feet * 12;
                Console.WriteLine($"conversion of {feet} feet is {result} inches");
            }
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadLine();
            MainMenu();
        }

        static void greater()
        {
            Console.Write("Enter number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            try
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"{num1} is greater than {num2}");
                }
                else
                {
                    Console.WriteLine($"{num2} is greater than {num1}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input, you must input a number. Please try again.");
            }
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadLine();
            MainMenu();
        }
    }
}

using System;

namespace Lab2RoomCalculatorAO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.Write("Welcome to the Room Calculator! ");

            bool runAgain = true;

            while (runAgain == true)
            {
                {
                    Console.WriteLine("Enter the length of your room ");
                    string length = Console.ReadLine();
                    double length1 = double.Parse(length);
                    Console.WriteLine("Enter the width of your room ");
                    string width = Console.ReadLine();
                    double width1 = double.Parse(width);

                    double area = length1 * width1;
                    double perimeter = (length1 * 2) + (width1 * 2);

                    Console.WriteLine("The area of your room is " + area + " and the perimeter of your room is " + perimeter + ".");

                    Console.WriteLine("You need " + perimeter / 5 + " paint cans. ");
                    Console.WriteLine("You need " + area / 5 + " carpet tiles. ");
                   
                    Console.WriteLine("Would you like to measure another room? y/n ");
                    string input2 = Console.ReadLine();

                    if (input2 == "n")
                    {
                        break;

                    }
                    else if (input2 == "y")
                    {
                        Console.WriteLine("Great, restarting application ");
                    }
                    else
                    {
                        break;
                    }

                }

            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        double square = squareNumber(userNumber);
        DisplayResult(userName, square);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }


        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name; 
        }


        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number; 
        }


        static double squareNumber(int number)
        {
            double square = Math.Pow(number, 2);
            return square;
        }

        static void DisplayResult(string name, double square)
        {
            Console.WriteLine($"{name}, the square of your number is:{square}");
        }

    }
}
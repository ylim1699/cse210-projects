using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        bool playAgain = true;
    
    while (playAgain)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        //place holder that indicates that a guess hasn't been made yet because -1 is not in range of 1 and 101
        int guess = -1;

        int guessCount = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            guessCount++;
            
            if (guess > number)
            {
                Console.Write("Lower, ");
            }
            else if (guess < number)
            {
                Console.Write("Higher, ");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");

            }
        }

            Console.WriteLine("Do you want to play again? (y/n): ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "n" && answer !="y")
           {
            Console.WriteLine("Do you want to play again? (y/n): ");
            answer = Console.ReadLine().ToLower();
           }
            else if (answer == "y")
            {
                Console.WriteLine("Awesome!");
            }
            else if (answer == "n")
            {
                Console.WriteLine("Thanks for playing!");
                playAgain = false;
            }        
    }
    }
}
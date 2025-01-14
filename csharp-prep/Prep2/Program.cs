using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        int grade = int.Parse(Console.ReadLine());

        string letter = " ";
        string plusMinus = " ";

// function for grade letter
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

// function for + - in grade letter
        if (grade >= 90)
        {
            plusMinus = "";
        }
        else if (grade <=60)
        {
            plusMinus = "";
        }
        else if (grade % 10 >= 7)
        {
            plusMinus = "+";
        }
        else if (grade % 10 <=3)
        {
            plusMinus = "-";
        }


        Console.WriteLine($"Your letter grade is {plusMinus}{letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You're passing your class!");
        }
        else
        {
            Console.WriteLine("You can do better...");
        }
    }
}
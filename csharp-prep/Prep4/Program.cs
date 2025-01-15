using System;

//any file that uses lists or any other standard collection must refer to that 
//library at the top of the file. Excepet some NET SDK automatically includes it.
//so declaration below isn't needed. 
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

       List<int> numbers = new List<int>();

       for (int i=0; i < 8; i++)
       {
            Console.WriteLine("Enter a number:");
            numbers.Add(int.Parse(Console.ReadLine()));  
       }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number; 
        }

        int smallestPos = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPos)
            {
                smallestPos = number;
            }
        }

        if (smallestPos == int.MaxValue)
        {
            Console.WriteLine("no postives were found");
        }
        else 
        {
            Console.WriteLine($"smallest positive number is: {smallestPos}");
        }

        Console.WriteLine($"The sum is: {sum}");

        int average = sum / 8;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");

    }
}
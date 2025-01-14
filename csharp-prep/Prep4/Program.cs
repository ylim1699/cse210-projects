using System;

//any file that uses lists or any other standard collection must refer to that 
//library at the top of the file. Excepet some NET SDK automatically includes it.
//so declaration below isn't needed. 
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>{10,11,12};
        numbers.Add(13);
        numbers.Add(14);
        numbers.Add(15);
        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[4]);
        Console.WriteLine(numbers[5]);

        List<string> words = new List<string>();
        words.Add("hello");
        words.Add("hola");
        words.Add("anyong");
        Console.WriteLine(words[0]);
        Console.WriteLine(words[1]);
        Console.WriteLine(words[2]);

        List<string> wordsToGreet = new List<string>{"hi","bye","nice to meet you"};
        Console.WriteLine(wordsToGreet[0]);
        Console.WriteLine(wordsToGreet[1]);
        Console.WriteLine(wordsToGreet[2]);

        Console.WriteLine(wordsToGreet.Count());

        foreach (string word in wordsToGreet)
        {
            Console.WriteLine(word);
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }











        
    }
}
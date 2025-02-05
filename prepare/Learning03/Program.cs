using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetTop());
            
        Console.WriteLine(f1.GetFractionString());
            
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetTop());
            

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetDecimalValue());

    }
}
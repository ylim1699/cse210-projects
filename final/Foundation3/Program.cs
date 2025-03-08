using System;

class Program
{
    static void Main(string[] args)
    {
        EventManager manager = new EventManager();
        manager.LDisplay1();
        Console.WriteLine("");
        manager.LDisplay2();
        Console.WriteLine("");
        manager.LDisplay3();
        Console.WriteLine("");

        manager.RDisplay1();
        Console.WriteLine("");
        manager.RDisplay2();
        Console.WriteLine("");
        manager.RDisplay3();
        Console.WriteLine("");

        manager.ODisplay1();
        Console.WriteLine("");
        manager.ODisplay2();
        Console.WriteLine("");
        manager.ODisplay3();
        Console.WriteLine("");
    }
}
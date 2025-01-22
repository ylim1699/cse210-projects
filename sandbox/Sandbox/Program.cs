using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Movie movie1 = new Movie();
        Movie movie2 = new Movie();

        movie1._title = "All of us are dead";
        movie1._year = 2022;
        movie1._runTime = 72;
        movie1._rating = "PG-13";

        movie1.DisplayTitle();
        movie1.DisplayInfo();
        Console.WriteLine("");

        movie2._title = "Train to Busan";
        movie2._year = 2018;
        movie2._runTime = 80;
        movie2._rating = "PG-13";

        movie2.DisplayTitle(); 
        movie2.DisplayInfo();

        ManyMovie owner = new ManyMovie();
        owner._name = "Yujin Lim";

        Console.WriteLine(owner._movie1._title);
        
    }

}
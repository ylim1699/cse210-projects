using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();

        p1.SetName("Jerry");
        p1.SetAge(23);

        p1.Display();

        string name = p1.GetName();
        Console.WriteLine($"The person's name was {name}");

        // Person p2 = new Person("marry", 18);
        // p2.Display();


    }
}

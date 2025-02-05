public class Entry
{
    public string _date;
    public string _author;
    public string _promptQuestion;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"Author:{_author}");
        Console.WriteLine($"PromptQuestion:{_promptQuestion}");
        Console.WriteLine($"Response - {_response}");
        Console.WriteLine("");
    }
}
public class Entry
{
    public string _date;
    public string _author;
    public string _promptQuestion;
    public string _response;

    public Entry(string date, string author, string promptQuestion, string response)
    {
        _date = date;
        _author = author;
        _promptQuestion = promptQuestion;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"Author:{_author}");
        Console.WriteLine($"PromptQuestion:{_promptQuestion}");
        Console.WriteLine($"Response - {_response}");
    }
}
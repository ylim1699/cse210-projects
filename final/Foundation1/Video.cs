using System.ComponentModel.DataAnnotations;

public class Video {
    
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void Display()
    {
        Console.Write($"Title: {_title} | ");
        Console.Write($"Author: {_author} | ");
        Console.WriteLine($"Video length: {_length} seconds.");

        foreach(Comment comment in _comments)
        {
            Console.WriteLine("----------------");
            comment.Display();
        }
        Console.WriteLine("==================");
        Console.WriteLine("");
    }
}
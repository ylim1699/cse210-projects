using System.ComponentModel;

public class Entry
{

    public List<string> _combinedStrings = new List<string>();
    static public DateTime theCurrentTime = DateTime.Now;
    public string _date = theCurrentTime.ToShortDateString();
    public string _author;
    public string _promptQuestion;
    public string _response;
    public string GetFromUser()
    {
        string combined = $"Journal- Date: {_date}, Name: {_author}, prompt: {_promptQuestion}: \n-{_response}\n";
       
        return combined;
    }
    public void Display()
    {
        foreach (string entry in _combinedStrings)
        {
            Console.WriteLine(entry);
        }
    }
    public void DeleteDisplay()
    {
        _combinedStrings.Clear();
    }
}
    

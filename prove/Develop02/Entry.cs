using System.ComponentModel;

public class Entry
{
    static public DateTime theCurrentTime = DateTime.Now;
    public string _date = theCurrentTime.ToShortDateString();
    public string _author;
    public string _promptQuestion;
    public string _response;
    public List<string> _combinedStrings = new List<string>();

    public string GetFromUser()
    {
        List<string> combinedStrings = new List<string>();
        
        string combined = $"Journal- Date: {_date}, Name: {_author}, {_promptQuestion}: \n-{_response}.\n";
        combinedStrings.Add(combined);

       return combined;
    }

    public void Display()
    {
        foreach (string combinedEntry in _combinedStrings)
        {
            Console.WriteLine(combinedEntry);
        }
    }



}
    // store temporal
    // display

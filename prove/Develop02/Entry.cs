using System.ComponentModel;

public class Entry
{
    static public DateTime theCurrentTime = DateTime.Now;
    public string _date = theCurrentTime.ToShortDateString();
    public string _author;
    public string _promptQuestion;
    public string _response;
    public string GetFromUser()
    {
        string combined = $"Journal- Date: {_date}, Name: {_author}, {_promptQuestion}: \n-{_response}.\n";
       
        return combined;
    }




}
    // store temporal
    // display

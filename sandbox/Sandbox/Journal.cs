public class Journal 
{
    public List<Entry> _entries = new List<Entry>();
    public string _filename;
    public string _savedEntries;

    public void AddList(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        Console.WriteLine(_savedEntries);
        foreach (Entry entry in _entries)
        {
             entry.Display();
        }  
    }

    public void SaveToFile(List<Entry> _entries)
    {
        Console.WriteLine("Saving to file...");
        string filename = _filename;

        using (StreamWriter outputFile = new StreamWriter(filename, append: true))
        {
            outputFile.WriteLine(_savedEntries);
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date:{entry._date}\nAuthor:{entry._author}");
                outputFile.WriteLine($"PromptQuestion:{entry._promptQuestion}\n- {entry._response}\n");
            }
        }
    }

    public void LoadFromFile()
    {
        _entries.Clear();
        _savedEntries="";
        string content = File.ReadAllText(_filename);
        _savedEntries += content;   
    }

    public void DeleteFileEntries()
    {
        using (StreamWriter writer = new StreamWriter(_filename, false))
        {
        }
        Console.WriteLine("");
        Console.WriteLine("File contents have been deleted.");
        Console.WriteLine("");
    }
}
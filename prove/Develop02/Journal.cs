public class Journal 
{
    public List<Entry> _entries = new List<Entry>();
    public string _filename;

    public void AddList(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
             entry.Display();
        }  
    }

    public void SaveToFile(List<Entry> _entries)
    {
        Console.WriteLine("Saving to file...");
        string filename = _filename;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._author},{entry._promptQuestion},{entry._response}");
            }
        }
    }

    public void LoadFromFile()
    {
        _entries.Clear();
        string[] savedEntries = System.IO.File.ReadAllLines(_filename);

        foreach (string entry in savedEntries)
        {
            string[] parts = entry.Split(',');
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._author = parts[1];
            newEntry._promptQuestion = parts[2];
            newEntry._response = parts[3];
            _entries.Add(newEntry);
        }
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

                
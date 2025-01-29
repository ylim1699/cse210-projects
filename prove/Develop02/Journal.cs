using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

public class Journal 
{ 
    public string _filename;
    Entry entry = new Entry();

    public void SaveToFile(List<string> _combinedStrings)
    {
        Console.WriteLine("Saving to file...");
        string filename = _filename;

        using (StreamWriter outputFile = new StreamWriter(filename, append: true))
        {
            foreach (string entry in _combinedStrings)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
    public void LoadFromFile()
    {
        entry._combinedStrings.Clear();
        string content = File.ReadAllText(_filename);
        entry._combinedStrings.Add(content);
        Console.WriteLine("");
    }
    
    public void DeleteJournalEntries()
    {
        File.WriteAllText(_filename, string.Empty);
    } 
}
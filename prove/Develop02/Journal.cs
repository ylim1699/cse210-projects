using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

public class Journal 
{ 

    public string _filename;
    public List<string> _combinedStrings = new List<string>();

    public void Display()
    {
        foreach (string combinedEntry in _combinedStrings)
        {
            Console.WriteLine(combinedEntry);
        }
    }

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
        string filename = _filename;
        string content = File.ReadAllText(filename);
        Console.WriteLine("");
        Console.WriteLine(content);
    }
    // save
    // load
}
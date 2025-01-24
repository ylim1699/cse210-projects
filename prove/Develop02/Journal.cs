using System;
using System.Collections.Generic;
using System.IO;
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
        string filename = _filename;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in _combinedStrings)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    // save
    // load
}
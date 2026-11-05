using System;
using System.Collections.Generic;
using System.IO;

// Journal class
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // AddEntry() method
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    //DisplayAll() method
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // SaveToFile()
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
}
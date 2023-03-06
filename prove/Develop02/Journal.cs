using System;
using System.IO;

public class Journal
{   
    List<Entry> entries = new List<Entry>();
    PromptGenerator prompt = new PromptGenerator();

    public void CreateJournalEntry()
    {
        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._prompt = prompt.GetRandomPrompt();
        Console.WriteLine(entry._prompt);
        Console.Write("> ");
        entry._response = Console.ReadLine();
        entries.Add(entry);
    }

    public void DisplayJournalEntries()
    {
        foreach(Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToCSV()
    {
        string fileName;

        Console.WriteLine("What is the file name?");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            outputFile.WriteLine(entry.GetEntryAsCSV());
        }
    }

    public void LoadFromCSV()
    {
        string fileName;
        Entry entry = new Entry();
        Console.WriteLine("What is the file name?");
        fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            entries.Add(entry);
        }
    }
    
}
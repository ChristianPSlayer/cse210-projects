using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    //Create a list Entry type
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);//add 
    }
    public void DisplayAll()
    {
        Console.WriteLine("-------MY diary------");
        foreach (Entry entry in _entries) 
        {
            entry.Display();
        }

        Console.WriteLine("--------------------");
    }

    public void SaveToFile(string file)
    {
        //using create a tunnel to the archive
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                //using '|' separate for identify where end one
                outputFile.WriteLine($"{entry._date} | {entry._prompText} | {entry._entryText}");
            }
        }
        Console.WriteLine("Save!!!");
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();//deleting for no duplicate

    //read all lines of the archive
    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
        {

            //split '|' cut the line in pieces
            string[] parts = line.Split("|");
            //add dates into the  newEntry
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._prompText = parts[1];
            newEntry._entryText = parts[2];                     

            _entries.Add(newEntry);

        }
    Console.WriteLine("sucessfull load");



    }
}
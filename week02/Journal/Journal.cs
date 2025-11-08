using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    // Adds each new entry to a list of entries
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    // Iterates through each entry in the list and displays them in the console
    {

        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine();
        }

    }

    public void SaveToFile(string file)
    // Iterates through the list of entries and writes them to a file
    {
        Console.WriteLine("Saving journal to file...");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry}|");
            }
        }
        Console.WriteLine("Journal saved. \n");
    }

    public void LoadFromFile(string file)
    // Reads from a file specified by the user
    {
        Console.WriteLine("Reading from file...");
        string[] lines = System.IO.File.ReadAllLines(file);

        // Checks if file is empty. If not, reads each line, splits each entry after the "|" symbol and stores them in an array, then displays them in the console
        if (lines.Length > 0)
        {
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string entry = parts[0].Trim();

                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine("No entries found."); // Returns this message if the file is empty
        }    

    }
}
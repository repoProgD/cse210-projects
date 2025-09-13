using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void addEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }
    public void DisplayAll()  // Display all entries on the screen(terminal)
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine(); // writes a blank line
        }
    }

    public void SaveToFile(List<Entry> entries)
    {
        Console.WriteLine("Enter the filename to save: ");
        string filename = Console.ReadLine();

        // using -> works like withopen in Python
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // this part is pretty much the same as in Java
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("Enter the filename to load your file: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        
        }
    }
}
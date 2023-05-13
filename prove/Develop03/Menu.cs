public class Menu
{
    Journal j = new Journal();
    
    
    public void DisplayJournal()
    {
        foreach (Entry entry in j._entries)
        {
            Console.WriteLine($"Date: {entry._date}\nLocation: {entry._location}\nEmotion: {entry._emotion}\nPrompt: {entry.prompt}\n{entry._text}");
        }
    }

    public void NewEntry()
    {
        Entry _entry = new Entry();
        Console.WriteLine("Where are you writing this entry? ");
        _entry._location = Console.ReadLine();
        Console.WriteLine("How are you feeling when you are writing this?");
        _entry._emotion = Console.ReadLine();
        Console.WriteLine(_entry.prompt);
        Console.WriteLine("Please write your entry:");
        _entry._text = Console.ReadLine();
        j._entries.Add(_entry);
    }

    public void SaveToFile()
    { 

        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach( Entry entry in j._entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._location},{entry._emotion},{entry.prompt},{entry._text}");
            }
        
        }
    }

    public void LoadFromFile()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string date = parts[0];
                string location = parts[1];
                string emotion = parts[2];
                string prompt = parts[3];
                string text = parts[4];
                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._location = location;
                newEntry._emotion = emotion;
                newEntry.prompt = prompt;
                newEntry._text = text;
                j._entries.Add(newEntry);
                
            }
    }

    


}
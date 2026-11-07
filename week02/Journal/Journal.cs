using System.Configuration.Assemblies;
using System.Text.Json;

public class Journal
{    
    string fileName;
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
         entry.Display();
        }
    }

    // recibir entrys / pero como y de donde?
    public void saveToFile()
    {
        //creo archivo y lo guardo
        Console.Write("Choose a file name: ");
        fileName = Console.ReadLine();
       
        if(fileName != "")
        {   
            using var writer = new StreamWriter(fileName);
            foreach(Entry entry in _entries)
            {
                writer.Write(entry.getInformation());  
            }
        }
        else
        {
            Console.WriteLine("Need a name to save the file");
        }
    }
    public void LoadFromFile()
    {
           Console.Write("What is the file name? ");
           fileName = Console.ReadLine();

        try
        {
            using var reader = new StreamReader(fileName);
            string linea = "";
           
           CleanList();
           
           while ((linea = reader.ReadLine()) != null)
           {    
            Entry getEntry = new Entry();
           
            string [] colums = linea.Split("-");
            string date = colums[0];
            string promptText = colums[1];
            string entryText = colums[2];

            getEntry._date = date;
            getEntry._promptText = promptText;
            getEntry._entryText = entryText;
            AddEntry(getEntry);     
        }
        }
        catch(FileNotFoundException fileNotFound)
        {
            Console.WriteLine($"Could not find file: {fileNotFound}");
        }
        catch(ArgumentException argumentException)
        {
            Console.WriteLine($"The value cannot be an empty string: {argumentException}");
        }
    }
    public void CleanList()
    {
        int entriesLen = _entries.Count;
      
        //bucle
        for(int i = 0; i < entriesLen; i++)
        {
            _entries.Remove(_entries[0]);
        }
    }
}
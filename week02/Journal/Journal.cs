using System.Configuration.Assemblies;


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
        using var writer = new StreamWriter(fileName);

        //NO FUNCIONA: si dejo en blanco 'fileName' da error
        if(fileName != null)
        {   
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
    public void CleanList()
    {
        int entriesLen = _entries.Count;
      
        //alamceno el len en otra variable y lo uso
        //porque si uso la misma lista y remuevo un elemento
        // el len cambia y se modifica la ejecucion del
        //bucle
        for(int i = 0; i < entriesLen; i++)
        {
            _entries.Remove(_entries[0]);
        }
        //ANOTARLO EN LA LIBRETA Y DESMENUSAR PARA APRENDER ESTE DETALLE
        //2do error: como remuevo el entry intento acceder
        //a la posicion 1, pero como lo removi, esa pocision
        //ya no existe en la lista.. 
        //SOLUCION: PONER UN 'ZERO' , siempre se remueve del final
        //hasta el princiopio,ZERO seria el ultimo numero a remover

        
    }
}
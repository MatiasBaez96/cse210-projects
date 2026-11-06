public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    public void Display()
    {
     Console.WriteLine($"date:{_date} - {_promptText} - {_entryText}");
    }

    public string getInformation()
    {  
       string information =  $"date:{_date} - {_promptText} - {_entryText}\n";
       return information;
      
    }
}
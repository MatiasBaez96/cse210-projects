using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;

public class Menu
{   
    bool oneTime = true;
    bool running = true;
    public void RunSystem()
    {   
        PrompTGenerator getPromt =  new PrompTGenerator();
        
        Journal journalObj = new Journal();

        while (running)
        {    
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the fallowing choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string answer = Console.ReadLine();
            int answerInt= int.Parse(answer);

        
            if(answerInt == 1)
            {
               //Usar entry class solo para user
               Entry getEntry = new Entry();
               string prompt = getPromt.GetRandomPrompt();
               Console.WriteLine(prompt);
               Console.Write(">");
               answer = Console.ReadLine();

               DateTime time = DateTime.Now;
               getEntry._date = time.ToString();
               getEntry._promptText = prompt;
               getEntry._entryText = answer;
               
               journalObj.AddEntry(getEntry);
            }

            else if(answerInt == 2)
            {
                journalObj.DisplayAll();
            }
            
            else if( answerInt == 3)
            {
                journalObj.saveToFile();
            }
            else if(answerInt == 4){
                // si cargo sin existir archivo
                //solo doy mensaje y vuelvo
                //<"ningun archivo guardado">
                oneTime = false;
                journalObj.LoadFromFile();
                
            }
            else if(answerInt == 5)
            {
                running = false;
            }
            else
            {
               Console.WriteLine("You must select one of the options"); 
            }
            
        }
    }
}
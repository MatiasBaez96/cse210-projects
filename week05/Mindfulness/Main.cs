public class Main
{
    public void Run()
    {   
        Activity activity =  new Activity();//QUITAR
        BreathingActivity breathingActivity = new BreathingActivity();

        bool run = true;
        string response;

        while(run)
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:"); 
            Console.WriteLine("  1. Start breathing activity"); 
            Console.WriteLine("  2. Start reflecting activity"); 
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu: "); 

            response = Console.ReadLine();

            if(response == "1")
            {
                breathingActivity.Run();
            }
            else if(response == "2")
            {
                
            }
            else if(response == "3")
            {
                
            }
            else if(response == "4")
            {

            }
            else
            {
                
            }
        }
    }
}
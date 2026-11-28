public class Main
{
    public void Run()
    {   

        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        bool isRunning = true;
        string response;

        while(isRunning)
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:"); 
            Console.WriteLine("  1. Start breathing activity"); 
            Console.WriteLine("  2. Start reflecting activity"); 
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: "); 

            response = Console.ReadLine();

            if(response == "1")
            {
                breathingActivity.Run();
            }
            else if(response == "2")
            {
                reflectingActivity.Run();
            }
            else if(response == "3")
            {
                
            }
            else if(response == "4")
            {
              isRunning = false;
            }
            else
            {
                
            }
        }
    }
}
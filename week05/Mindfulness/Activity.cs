using System.Net.NetworkInformation;

public class Activity
{  
    private string _name;
    private string _description;
    private List<string> _animationStrings = new()
    {
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\",
        "|"
    };

    protected int _duration; 
    protected int _countdown = 4; 
    protected int _spinnerDuration = 5;
    
    
    public Activity(string name, string description)
    {
       _name = name; 
       _description = description;  
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for you session? ");  
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    }
    public void ShowSpinner(int seconds)
    {   
        foreach(string animation in _animationStrings)
        {              
            Console.Write(animation);
            Thread.Sleep(1000);//va despues de qe se imprima caracter
            Console.Write("\b \b");
        }
    }
     public void ShowCountDown(int seconds)
    {    
       for(int i = seconds; i > 0; i--)
       {
         Console.Write(i);
         Thread.Sleep(1000);
         Console.Write("\b \b");
        }                      
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
    }

    public void FinishActivity()
   {
    Console.WriteLine("");
    Console.WriteLine("Well done!!");    
   }
}
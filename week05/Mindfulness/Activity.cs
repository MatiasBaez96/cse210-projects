using System.Net.NetworkInformation;

public class Activity
{  
    protected string _name;
    protected string _description;
    protected int _duration; 
    protected int _countdown; 
    protected int _spinnerDuration;
    
    private List<string> _animationStrings = new();
    public Activity()
    { 
      _spinnerDuration = 6;   

      _animationStrings.Add("|");
      _animationStrings.Add("/");
      _animationStrings.Add("-");
      _animationStrings.Add("\\");
      _animationStrings.Add("|");
      _animationStrings.Add("/");
      _animationStrings.Add("-");
      _animationStrings.Add("\\");
      _animationStrings.Add("|");
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
}
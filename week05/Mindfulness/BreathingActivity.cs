using System.Net;

public class BreathingActivity: Activity
{   
    private bool _isAlternate = false;
    
   
   //<Better aproach>
   // name and description:
      // values that don't change:
      // don't request them from main when creating the object
      // pass them directly through this constructor
    public BreathingActivity()
      : base("Breathing Activity", 
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing") 
    { 
      
    }   

  // next step:
  // organize the Run() logic into different functions
  /*
      .Run() does 5 different things
      .Split it into:
      DisplayStartingMessage();
      AskForDuration();
      GetReady();
      BreatheCycles();
      FinishActivity();
  */
    public void Run()
    {
       bool isRunning = true;
       
       while(isRunning)
       {
        DisplayStartingMessage();
        
          string response = AskForDuration();
          try
            {
              _duration = int.Parse(response);
              isRunning = false;
              GetReady();
              ShowSpinner(_spinnerDuration); 
              BreatheCycles();           
              FinishActivity();  
              ShowSpinner(_spinnerDuration);
              DisplayEndingMessage();
              ShowSpinner(_spinnerDuration);
            }

            catch (FormatException)
            {
              Console.Clear();
              Console.WriteLine("You must insert a number");
              ShowSpinner(_spinnerDuration);
            }          
        }
       }  
  private String AskForDuration()
  { 
    string response;
    response = Console.ReadLine();
    return response;
  }

  
  public void BreatheCycles()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    string breathingText = "";
    while(DateTime.Now < endTime)
    {
      _isAlternate  =! _isAlternate ;

      if(_isAlternate )
        {
          breathingText = "Breath in...";
          Console.WriteLine("");
        }
      else
        {
           breathingText = "Breath out...";           
        }
             
        Console.Write(breathingText);
        ShowCountDown(_countdown);   
        Console.WriteLine("");  
    }
  }

  // private void FinishActivity()
  // {
  //   Console.WriteLine("");
  //   Console.WriteLine("Well done!!");
  //   ShowSpinner(_spinnerDuration);
  //   DisplayEndingMessage();
  //   ShowSpinner(_spinnerDuration);      
  // }
}

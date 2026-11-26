public class BreathingActivity: Activity
{   
    private bool _isAlternate ;
    
    //Cambiar asignacion de variables en Constructores 'base' y 'subclase'
    public BreathingActivity(): base() 
    { 
      _name = "Breathing Activity";
      _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";  
      _countdown = 4;
      _isAlternate  = false;
    }   

    //siguiente paso:
    //organizar logica Run() en diferentes funciones
    public void Run()
    {
       bool isRunning = true;
       string response;
       
       while(isRunning)
       {
        DisplayStartingMessage();
        response = Console.ReadLine();
     
          try
            {
              _duration = int.Parse(response);
              DateTime startTime = DateTime.Now;
              DateTime endTime = startTime.AddSeconds(_duration);
              isRunning = false;

              Console.Clear();
              Console.WriteLine("Get Ready...");
              
              ShowSpinner(_spinnerDuration);
              
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

              Console.WriteLine("");
              Console.WriteLine("Well done!!");
              ShowSpinner(_spinnerDuration);
              DisplayEndingMessage();
              ShowSpinner(_spinnerDuration);      
            }
            
          catch(FormatException){}          
        }
       }  
}

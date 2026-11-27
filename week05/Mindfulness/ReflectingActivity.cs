using System.Data;

public class ReflectingActivity: Activity
{
    /*
        Similarly, the Reflecting 
        Activity should store a list of questions and a 
        list of prompts to draw from.
    */
    private List<string> _prompts = new()
    {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new()
    {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
    };

     public ReflectingActivity()
     : base("Reflecting Activity",
      "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    } 
    public void Run()
    {
      bool isRunning = true;
      while (isRunning)
      {
        
        DisplayStartingMessage();
        string response = AskForDuration();
        
        try
         {
            _duration = int.Parse(response);
             isRunning = false;
            GetReady();
            ShowSpinner(_spinnerDuration);
            DisplayPrompt(); 
            FinishActivity();
            ShowSpinner(_spinnerDuration);
            DisplayEndingMessage();       
         }
        catch (FormatException)
        {
         Console.Clear();
         Console.WriteLine("You must insert a number");
         ShowSpinner(_spinnerDuration);
        }
      }
    }
    private string GetRandomPrompt()
    {
      Random random = new Random();
      int randomNumber = random.Next(0, _prompts.Count);
      return _prompts[random.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
      Random random = new Random();
      int randomNumber = random.Next(0, _prompts.Count);
      return _questions[random.Next(_questions.Count)];
    }
    private void DisplayPrompt()
    {
      Console.WriteLine("Consider the fallowing prompt:");
      Console.WriteLine("");
      Console.WriteLine($"--- {GetRandomPrompt()} ---");
      Console.WriteLine("");
      Console.WriteLine("When you have something in mind, press enter to continue.");
      Console.ReadLine();
      Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
      Console.Write("You may begin in: ");
      ShowCountDown(_countdown);
      DisplayQuestions();
    }
    private void DisplayQuestions()
    {
      //Preguntas repetidas tambien se imprimen o saltean?
      Console.Clear();
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(_duration);
      while(DateTime.Now < endTime)
      {
        Console.Write($"> {GetRandomQuestion()}");
        ShowCountDown(_countdown);//CAMBIAR<Acomodar correctamente>
        Console.WriteLine("");
      }  
    }
    private string AskForDuration()
    {
      string response = Console.ReadLine();
      return response;
    }
}
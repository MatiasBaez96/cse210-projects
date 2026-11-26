public class ReflectingActivity: Activity
{
    /*
        Similarly, the Reflecting 
        Activity should store a list of questions and a 
        list of prompts to draw from.
    */
    protected List<string> _prompts;
    private List<string> _questions;

     public ReflectingActivity(string name, string description, int duration)
    {
        
    } 
    public void Run()
    {
        
    }
      public string GetRandomPrompt()
    {
       return ""; 
    }
      public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {
        
    }
    public void DisplayQuestions()
    {
        
    }
}
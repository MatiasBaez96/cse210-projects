public class PrompTGenerator
{       string prompt1 = "Who was the most interesting person i interact with today?";
        string prompt2 = "What was the best part of my day?";
        string prompt3 = "How did i se the hand of the Lord in my life today?";
        string prompt4 = "What waas the strongest emotion i felt today?";
        string prompt5 = "If i had one thing i could do over today, what would it be?";
        List<string> _prompts;
    
    public string GetRandomPrompt()
    {  
        _prompts = new List<string>{prompt1,prompt2,prompt3,prompt4,prompt5};
       
        Random randomObj = new Random();
        int number = randomObj.Next(1,5);
        string randomPrompt = _prompts[number];

        return randomPrompt;
    }
}
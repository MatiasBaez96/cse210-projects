public class PrompTGenerator
{       string prompt1 = "Who was the most interesting person i interact with today?";
        string prompt2 = "What was the best part of my day?";
        string prompt3 = "How did i see the hand of the Lord in my life today?";
        string prompt4 = "What was the strongest emotion i felt today?";
        string prompt5 = "If i had one thing i could do over today, what would it be?";
        string prompt6 = "What did i learn today that i didn't know yesterday?";
        string prompt7 = "What was the biggest challenge i faced today and how did i handle it?";
        string prompt8 = "Who did i help or serve today?";
        string prompt9 = "What am i most grateful for today?";
        string prompt10 = "What is one small victory i had today?";
        string prompt11 = "How did i feel the Spirit today?";
        string prompt12 = "What made me laugh or smile today?";
        string prompt13 = "What is one thing i want to remember about today?";
        string prompt14 = "How did i show kindness to someone today?";
        string prompt15 = "What is one goal i want to focus on tomorrow?";
        string prompt16 = "What was the most peaceful moment of my day?";
        string prompt17 = "Who do i need to reach out to or reconnect with?";
        string prompt18 = "What is one thing i did today that i'm proud of?";
        string prompt19 = "What did i do today that brought me closer to my goals?";
        string prompt20 = "What is one blessing i noticed today that i usually overlook?";
        List<string> _prompts;
    
    public string GetRandomPrompt()
    {  
        _prompts = new List<string>{  
            prompt1, prompt2, prompt3, prompt4, prompt5,
            prompt6, prompt7, prompt8, prompt9, prompt10,
            prompt11, prompt12, prompt13, prompt14, prompt15,
            prompt16, prompt17, prompt18, prompt19, prompt20
        };
       
        Random randomObj = new Random();
        int number = randomObj.Next(1,_prompts.Count);
        string randomPrompt = _prompts[number];

        return randomPrompt;
    }
}
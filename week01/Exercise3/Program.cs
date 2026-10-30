using System;

class Program
{   
    static void Main(string[] args)
    {
    
    Random randomObj = new Random();
    int randomNumber = randomObj.Next(1,101);
    int count = 0; 
    int a;

    string guess;
    bool running = true;
    
    while(running)
    {            
        Console.Write("What's your guess? ");
        guess = Console.ReadLine();   
        a = int.Parse(guess);
        count++;

        if(a > randomNumber)
        {
        Console.WriteLine("Lower");
        }
        else if(a < randomNumber)
        {
        Console.WriteLine("Higher");
        }
        else
        {
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"Number of guesses: {count}");
        
        Console.Write("Wanna play again? ");
        string answer = Console.ReadLine();

                if(answer.ToLower() == "yes"){
                    randomNumber = randomObj.Next(1,101);
                    count = 0;
                }
                else{
                    running = false;
                }
           } 
        }
 }

}
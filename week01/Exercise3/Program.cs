using System;

class Program
{   
    static void Main(string[] args)
    {
    
    Random random_OBJ = new Random();
    int random_number = random_OBJ.Next(1,10);
    int count = 0; 
    int a;

    string guess;
    bool running = true;
    
    while(running)
    {       
        Console.WriteLine("");      
        Console.Write("What's your guess? ");
        guess = Console.ReadLine();   
        a = int.Parse(guess);
        count++;

        if(a > random_number)
        {
        Console.WriteLine("Lower");
        }
        else if(a < random_number)
        {
        Console.WriteLine("Higther");
        }
        else
        {
        
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"Number of guesses: {count}");
        
        Console.Write("Wanna play again? ");
        string answer = Console.ReadLine();

                if(answer.ToLower() == "yes"){
                    random_number = random_OBJ.Next(1,10);
                }
                else if(answer.ToLower() == "no"){
                    running = false;
                }
           } 
        }
 }

}
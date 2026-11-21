//Creativity: Added an option so the user can enter a scripture manually

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        bool manualMode = false;
        List<(string book, int chapter, int verse, string text)> scriptures = new()
        {
            ("1 Nefi", 3, 7,
             "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he hath commanded them."),

            ("2 Nefi", 2, 25,
             "Adam fell that men might be; and men are, that they might have joy."),

            ("Mosiah", 2, 17,
             "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),

            ("Alma", 32, 21,
             "And now as I said concerning faith faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),

            ("Alma", 37, 37,
             "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day."),

            ("Helaman", 5, 12,
             "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."),

            ("Ether", 12, 27,
             "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."),

            ("Moroni", 10, 4,
             "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.")
        };

        // Elijo una escritura desde el inicio
        // Hasta qe el programa termine
        Random random = new Random();
        var chosen = scriptures[random.Next(scriptures.Count)];

        Reference referenceObj = new(chosen.book, chosen.chapter, chosen.verse);
        Scripture scriptureObj = new(referenceObj, chosen.text);

        Console.Clear();
        Console.Write(scriptureObj.GetDisplayText());

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Press Enter to continue or press \"exit\" to finish");
            Console.WriteLine("2. Type \"2\" to enter your own scripture");
            Console.WriteLine();
            
            //Agrego opcion para ingresar toda la informacion manual
            string response = Console.ReadLine();
            if(response == "")
            {                                
                scriptureObj.HideRandomWords(3); 
            }
            if (response.ToLower() == "exit" || scriptureObj.IsCompletelyHidden())
            {
                running = false;
            }

            Console.Clear();
            Console.Write(scriptureObj.GetDisplayText());       

            if(response == "2")
            {   
                Console.Clear();
                running = false;
                manualMode = true;     
            }
        }
    
        while(manualMode)
        {     
            Console.Write("Book: ");
            string book = Console.ReadLine();
            Console.Write("Chapter: ");
            string chapter = Console.ReadLine();
            Console.Write("Verse: ");
            string verse = Console.ReadLine();
            Console.Write("Text: ");
            string text = Console.ReadLine();  
                    
                try
                {
                    int chapterInt = int.Parse(chapter);
                    int verseInt = int.Parse(verse);
                    Reference referenceObjManual = new(book, chapterInt, verseInt);
                    Scripture scriptureObjManual = new(referenceObjManual, text);

                    bool runningScripture = true;
                    while(runningScripture)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. Press Enter to continue or press \"exit\" to finish");
                        Console.WriteLine();
                        string response = Console.ReadLine();

                            if(response == "")
                            {                                
                                scriptureObjManual.HideRandomWords(3); 
                            }
                            if(response.ToLower() == "exit" || scriptureObjManual.IsCompletelyHidden())
                            {           
                               runningScripture = false;
                               manualMode = false;                  
                            }
        
                            Console.Clear();
                            Console.Write(scriptureObjManual.GetDisplayText());
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Chapter and verse must be numbers.");
                    }  
                }
    }
}
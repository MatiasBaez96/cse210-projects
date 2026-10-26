using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine($"your name is {last_name}, {name} {last_name}");
    }
}

// Diferencia:
// python es un interprete qe ejecuta los comandos ni bien se los ejecuta
// C3 copila todo el programa antes de ejecutarlo 
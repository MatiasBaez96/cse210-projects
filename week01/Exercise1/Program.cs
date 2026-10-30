using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"your name is {lastName}, {name} {lastName}.");
    }
}

// Diferencia:
// python es un interprete qe ejecuta los comandos ni bien se los ejecuta
// C# copila todo el programa antes de ejecutarlo 
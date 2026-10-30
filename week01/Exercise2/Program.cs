using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Your Score: ");
        string score = Console.ReadLine();
        int gradeInt = int.Parse(score);

        // SECCION 1
        string letter;
        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >= 80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // SECCION 2
        int lastDigit = gradeInt % 10;
        string sign;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
          
        if (gradeInt >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}


/*
Añade a tu código la posibilidad de incluir un "+" o un "-" junto 
a la nota de la letra, como B+ o A-. Para cada nota, sabrás que es un 
"+" si el último dígito es >= 7. Sabrás que es menos si el último dígito
 es < 3 y si no, no tiene signo.

Después de tu lógica para determinar la letra de calificación, añade otra
 sección para determinar el firma. Guarda este signo en una variable. Luego,
  muestra tanto la letra de calificación como el cartel en una declaración impresa.

Consejo: Para obtener el último dígito, podrías dividir el número entre 10 y
 obtener el resto. Podrías revisar los operadores matemáticos estándar y encontrar
  el que hace división y Te da el resto.
*/
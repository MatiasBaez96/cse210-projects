using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment assigment1 = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assigment1.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssigment writingAssigment = new WritingAssigment("Mary Waters", "European History", "The Causes of the War II");

        Console.WriteLine(writingAssigment.GetSummary());
        Console.WriteLine(writingAssigment.GetWritingInformation());
       
       
    }
}
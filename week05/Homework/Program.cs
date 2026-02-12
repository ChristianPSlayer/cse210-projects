using System;

using Homework;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Christian Pena", "Multiplication");
        Console.WriteLine(a1.GetSummary());


        Console.WriteLine("Writing Assignment");
        MathAssignment a2 = new MathAssignment("Luis Sejas", "Fractions", "8.2", "1-10");
        Console.WriteLine(a2.GetSummary()); //inheritance

        Console.WriteLine(a2.GetHomeworkList());

        Console.WriteLine("Math Assignment");
        WritingAssignment a3 = new WritingAssignment("Luenia Loganes", "American History", "The Causes of the American Revolution");
        Console.WriteLine(a3.GetSummary()); //inheritance
        Console.WriteLine(a3.GetWritingInformation());

    }
}
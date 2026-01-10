using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
/*
        string valueInText = "42";
        int number = int.Parse(valueInText);
        Console.WriteLine(number);

        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int anyNumber = int.Parse(userInput);
        Console.WriteLine(anyNumber);
*/
        Console.WriteLine("What is your grade porcentaje?");
        string answer = Console.ReadLine();
        int score = int.Parse(answer);
        
        string letter = "";
       
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (score >= 70)
        {
           Console.WriteLine("Great You Pass!");
        }
        else
        {
            Console.WriteLine("Sorry you must improve");
        }
    }
}
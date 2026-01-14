using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();

        string nameUser = PromptUserName();
        Console.WriteLine($"Nice too meet you {nameUser}");

        int NumberUser = PromptUserNumber();
       
        Console.WriteLine($"Hello Brother {nameUser} , the square of your number is: {SquareNumber(NumberUser)}");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Hello Welcome to the Program!!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("what is your name?");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number");
        string text = Console.ReadLine();
        int number = int.Parse(text);
        return number;
    }
    static int SquareNumber(int num)

    {
        int squeare = num * num;   
        return squeare;    
    }
}
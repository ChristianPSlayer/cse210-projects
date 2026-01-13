using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();

        Console.WriteLine("Can you enter some integer numbers");
        Console.WriteLine("Write 0 for finish the program");

        while (true)
        {
            Console.Write("Enter a Number: ");
            string text = Console.ReadLine();
            int num = int.Parse(text);

            if (num == 0)
            {
                break;
            }
            number.Add(num);
        }
        Console.WriteLine("-----Number List--------");
        Console.WriteLine($"You have saved {number.Count} numeros");
        int sumTotal = 0;
        int Higher = int.MinValue;

        foreach (int n in number)
        {

            if (n > Higher)
            {
                Higher = n;
            }

            Console.WriteLine(n);
            sumTotal = sumTotal + n;

        }
        if (number.Count > 0)
        {
            double average = (double)sumTotal / number.Count;
            Console.WriteLine($"The average is: {average}");
        }





        Console.WriteLine($"The sum total is: {sumTotal}");
        Console.WriteLine($"The highest number is: {Higher}");
    }
}
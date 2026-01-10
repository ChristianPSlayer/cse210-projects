using System;

class Program

{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
       
        string playagain = "yes";
       
        
        while (playagain == "yes") 
        {
             int number = randomGenerator.Next(1, 11);
            
            int magicNumber = -1;
            int attempts = 0;


            while (magicNumber != number)
            {

                Console.WriteLine("Can you guess the magic number");
                magicNumber = int.Parse(Console.ReadLine());
                attempts++;


                if (magicNumber < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You got it");
                    Console.WriteLine($"It took you {attempts} times");
                }

            }


        Console.Write("Do you want to play again");
        playagain = Console.ReadLine().ToLower();

        }
        Console.WriteLine("Good Bye");
    }
    
}
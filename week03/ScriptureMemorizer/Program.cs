using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        Reference miRef = new Reference("Juan", 3, 16);

        Scripture myScripture = new Scripture(miRef, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth\n in him should not perish, but have everlasting life.");
       
        while (input.ToLower() != "quit" && !myScripture.isCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());
             Console.WriteLine("Press enter to hide the words!! o write 'quit' for exit.");
            
            input = Console.ReadLine();
            if(input.ToLower() != "quit")
            {
                myScripture.HideRandomWords(2);
            } 
        }
        Console.WriteLine("All the words are hidden!! Congratulations!!");
    }
}

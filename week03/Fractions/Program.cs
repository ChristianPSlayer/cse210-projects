using System;

class Program
{
    static void Main(string[] args)
    {
        Reference miRef = new Reference("Juan", 3 , 16);

        Scripture myScripture = new Scripture(miRef , "For God so loved the world, that he gave his only begotten Son, that whosoever believeth\n in him should not perish, but have everlasting life.");
        Console.WriteLine(myScripture.GetDisplayText());
    }
}
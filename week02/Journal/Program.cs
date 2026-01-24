

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        // Variable para controlar el bucle
        bool running = true;

        Console.WriteLine("Bienvenido al Programa de Diario.");

        while (running)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Show daily");
            Console.WriteLine("3.  Upload from file");
            Console.WriteLine("4. Save file");
            Console.WriteLine("5. exit");
            Console.Write("> ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                
                string prompt = promptGenerator.GetRamdomPrompt();
                Console.WriteLine($"\n{prompt}");
                
                
                Console.Write("> ");
                string response = Console.ReadLine();
                
                
                string date = DateTime.Now.ToShortDateString();

                
                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._prompText = prompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Name of the file to upload (example, diary.txt):");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("File name to save (example, diary.txt):");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
}
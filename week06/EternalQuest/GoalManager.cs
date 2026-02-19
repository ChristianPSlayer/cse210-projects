using System;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public void Start()
        {
            string choice = "";
            while (choice != "6")
            {
                Console.WriteLine($"\nYou have {_score} points.");
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoalDetails(); break;
                    case "3": SaveGoals(); break;
                    case "4": LoadGoals(); break;
                    case "5": RecordEvent(); break;
                }
            }  
        }
        public void ListGoalDetails()
        {
            Console.WriteLine("\nYour Goals:");
            foreach (Goal g in _goals)
            {
                Console.WriteLine(g.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string type = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
                _goals.Add(new SimpleGoal(name, desc, points));
            else if (type == "2")
                _goals.Add(new EternalGoal(name, desc, points));
            else if (type == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoal(name, desc, points, target, bonus));
            }
        }

        public void RecordEvent()
        {
            ListGoalNames();
            Console.Write("Which goal did you accomplish? ");
            int index = int.Parse(Console.ReadLine()) - 1;

            Goal goal = _goals[index];
            goal.RecordEvent(); //polymorphism, each type of goal knows how to record its event 
            
            // Logic for scoring points 
            int pointsEarned = int.Parse(goal.GetStringRepresentation().Split(',')[2]); 
            _score += pointsEarned;
            
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        }
        public void ListGoalNames()
        {
            for(int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString().Split(' ')[1]}");
            }
        }

        public void SaveGoals()
        {
            Console.Write("What is the Filename? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename)) // help master
            {
                outputFile.WriteLine(_score);
                foreach (Goal g in _goals)
                {
                    outputFile.WriteLine(g.GetStringRepresentation());
                }
            }
        }

      public void LoadGoals()
{
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();
    
   
    if (File.Exists(filename))
    {
        string[] lines = System.IO.File.ReadAllLines(filename); 

        
        _score = int.Parse(lines[0]);

       
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":"); 
            
            string type = parts[0];
            string details = parts[1];
            string[] data = details.Split(","); 

           
            if (type == "SimpleGoal")
            {
               
                SimpleGoal sg = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                if (data[3] == "True")
                {
                    sg.RecordEvent(); 
                }
                _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                
                CheckListGoal cg = new CheckListGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]));
                
               
                int currentProgress = int.Parse(data[5]);
                for (int j = 0; j < currentProgress; j++)
                {
                    cg.RecordEvent(); 
                }
                _goals.Add(cg);
            }
        }
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
        
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2020;
        job1._endYear = 2026;
        Job job2 = new Job("Manager","Apple", 2022 , 2023);

        Resume myResume = new Resume();


        myResume._name = "Christian";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        job1.Display();
        job2.Display();

        Console.WriteLine("Nombre:" + myResume._name);
        Console.WriteLine($"firt job in the list: {myResume._jobs[0]._company}");
        Console.WriteLine($"firt job in the list: {myResume._jobs[1]._company}");

        


           
       

    }

}
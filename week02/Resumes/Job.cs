using System;

public class Job
{
    public string  _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

public Job()
    {
        
    }

    public Job(string title, string company, int endYear,int start_Year)
    {
        _jobTitle = title;
        _company = company;
        _endYear = endYear;
        _startYear = start_Year;
    }


    public void Display()
    {
        Console.WriteLine($"{_jobTitle}, {_company}, {_startYear} - {_endYear}");
    }

}
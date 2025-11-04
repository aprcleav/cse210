using System.Diagnostics.Contracts;

// Create class
public class Job
{
    // Responsibilities (member variables)
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Behaviors (methods) - method to display 
    public void DisplayJobs()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
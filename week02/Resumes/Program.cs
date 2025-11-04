using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*
        Class Diagrams:
        ______
        Job

        _company: string
        _jobTitle: string
        _startYear: int
        _endYear: int

        Display(): void
        ______
        Resume

        _name: string
        _jobs: List<Job>

        Display(): void
        ______

        */

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Junior Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2020;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Shallan Davar";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        Job job1 = new Job();
        Job job2 = new Job();
        job1._role= "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2015;
        job1._endYear = 2018;
        job2._role = "Software Engineer";
        job2._company = "Facebook";
        job2._startYear = 2018;
        job2._endYear = 2020;
        resume._name = "Brian Ito";
        resume._jobs = new List<Job>();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}
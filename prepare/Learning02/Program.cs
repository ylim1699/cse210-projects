using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume = new Resume();
        resume._name = "yujin Lim";

        job1._company = "Microsoft";
        job1._jobTitle = "software engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020; 
        job1._endYear = 2023;


        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software development"; 
        job2._startYear = 2024;
        job2._endYear = 2025;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();








        Console.WriteLine("Hello World! This is the Resumes Project.");
    }
}
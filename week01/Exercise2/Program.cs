using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);


        if (percentage >= 90)
        {
            Console.WriteLine("Your letter grade is A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Your letter grade is B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Your letter grade is C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Your letter grade is D");
        }
        else
        {
            Console.WriteLine("Your letter grade is F");
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }



    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**************Grade Calculator**************");

        Console.Write("What is your grade percentage?");
        string grade_percentage = Console.ReadLine();
        string letter_grade = "";
        int grade = int.Parse(grade_percentage);
        if (grade >= 90)
        {
            letter_grade = "A";
        }
        else if (grade >= 80)
        {
            letter_grade = "B";
        }
        else if (grade >= 70)
        {
            letter_grade = "C";
        }
        else if (grade >= 60)
        {
            letter_grade = "D";
        }
        else
        {
            letter_grade = "F";
        }

        int second_digit = grade % 10;
        string sign_grade = "";

        if (grade >= 90)
        {
            if (second_digit >= 3)
            {
                sign_grade = " ";
            }
            else 
            {
                sign_grade = "-";
            }
        }
        else if (grade >= 60 && grade < 90)
        {
            if (second_digit >= 7)
            {
                sign_grade = "+";
            }
            else if (second_digit >= 3 && second_digit < 7)
            {
                sign_grade = " ";
            }
            else
            {
                sign_grade = "-";
            }
        }
        else
        {
            sign_grade = " ";
        }



        Console.WriteLine($"Your letter grade is: {letter_grade} {sign_grade}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Better luck next time!");
        }
        Console.WriteLine();


    }
}
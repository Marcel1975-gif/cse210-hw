using System;
using System.Formats.Asn1;

Console.Write("What is your grade percentage?");
string grade = Console.ReadLine();
int percentage = int.Parse(grade);

int digit = percentage % 10;
string letter = "";



if (percentage >= 90 && percentage <= 100)
{
    if (digit < 3)
    {
        letter = "A-";
    }
    else
    {
        letter = "A";
    }
}
if (percentage >= 80 && percentage < 90)
{
    if (digit < 3)
    {
        letter = "B-";
    }
    else if (digit > 3 && digit < 7)
    {
        letter = "B";
    }
    else
    {
        letter = "B+";
    }

}
if (percentage >= 70 && percentage < 80)
{
    if ((digit < 3))
    {
        letter = "C-";
    }
    else if (digit > 3 && digit < 7)
    {
        letter = "C";
    }
    else
    {
        letter = "C+";
    }
}
if (percentage >= 60 && percentage < 70)
{
    if ((digit < 3))
    {
        letter = "D-";
    }
    else if (digit > 3 && digit < 7)
    {
        letter = "D";
    }
    else
    {
        letter = "D+";
    }
}
if(percentage < 60)
{
    letter = "F";
}

Console.WriteLine($"Your grade is: {letter}");

if (percentage >= 70)
{
    Console.WriteLine("Congratulations! You passed the class!");
}
else
{
    Console.WriteLine("Better luck next time.");
}

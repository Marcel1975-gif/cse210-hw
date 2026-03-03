using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type '0' when finished");
        List<int> numbers = new List<int>();
        int count = 0;
        while (true)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0)
            {
                break;
            }
            numbers.Add(input); 


        }
        Console.WriteLine("You entered the following numbers:");
        for(int i = 0; i < numbers.Count; i++)

        {
            Console.WriteLine(numbers[i]);
            count = count + numbers[i];
        }
        Console.WriteLine("\nThe sum is: " + count);
        Console.WriteLine("The average is: " + ((double)count / numbers.Count));
        Console.WriteLine("The maximum is: " + numbers.Max());
        Console.WriteLine("The smallest positive number is: " + numbers.Where(x => x > 0).Min());
        Console.WriteLine("The sorted list is: " + string.Join(", ", numbers.OrderBy(x => x)));









    }
}
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int item = 0;
        List<int> numbers = new List<int>();

        Console.Write("Enter a list of number or type [0] to finish: ");
        do
        {

            Console.Write("Enter number: ");
            item = int.Parse(Console.ReadLine());


            numbers.Add(item);

        } while (item != 0);
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // variables
        float cont = 0;
        float media = 0;
        float maximum = 0;


        // sum of the numbers

        foreach (int number in numbers)
        {
            cont = cont + number;
        }
        Console.WriteLine($"The sum is: {cont}");

        //average of the numbers

        media = cont / (numbers.Count - 1);
        Console.WriteLine($"The average is: {media}");

        //maximum number
        maximum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The largest is: {maximum}");


        

    }

}
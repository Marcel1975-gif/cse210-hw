using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int item = 0;
        List<int> numbers = new List<int>();



        do
        {

            Console.Write("Enter a list of number or type [0] to finish: ");
            item = int.Parse(Console.ReadLine());


            numbers.Add(item);

        } while (item != 0);
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        int cont = 0;
        foreach (int number in numbers)
        {
            cont = cont + number;
        }
        Console.WriteLine($"The sum is: {cont}");
    }

}
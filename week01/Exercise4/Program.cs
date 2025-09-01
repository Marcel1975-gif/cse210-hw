using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int item;
        List<int> numbers = new List<int>();



        while (item != 0)
        {
            Console.Write("Enter a number or type [0] to scape: ");
            item = int.Parse(Console.ReadLine());
            if (item != 0)
            {
                numbers.Add(item);
            }
            else
            {
                break;
            }
        }
    }

}
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int item = 0;
        List<int> numbers = new List<int>();



        
        
            Console.Write("Enter a number or type [0] to scape: ");
            item = int.Parse(Console.ReadLine());
            while (item != 0)
            {
                numbers.Add(item);
            }
            
        
    }

}
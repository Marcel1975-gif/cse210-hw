using System;

class Program
{
    static void Main(string[] args)
    {
        // part 1 ,2 
     /* Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
            if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("lower");

            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        */

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        int count = 0;
        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("lower");

            }
            count++;
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }
        count++;
        Console.WriteLine($"You guessed it! It took you {count} tries.");
    }
}
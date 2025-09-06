using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string name = EnterName();
        int age = EnterAge();
        int number = EnterFavoriteNumber();
        int square = Square(number);


       
        EnterName();
        EnterAge();
        EnterFavoriteNumber();

        Console.WriteLine($"Hello {name}, the square of your number is {square}.");

    }


        // Function to display welcome message
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        //function to enter name
        static string EnterName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        //function to enter age
        static int EnterAge()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            return age;
        }


        //function to enter favorite number
        static int EnterFavoriteNumber()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        //function to calculate square of a number
        static int Square(int number)
        {
            return number * number;
        }

}
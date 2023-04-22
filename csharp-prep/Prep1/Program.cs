using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        string FirstName, LastName, Value;

        do
        {
            Console.Write("What is your first name? ");
            FirstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            LastName = Console.ReadLine();

            Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}");

            Console.Write("Do you wish to use this program again? Y/N: ");
            Value = Console.ReadLine();

            Console.Clear();

        }while (Value == "Y" | Value == "y");

        Console.WriteLine("Thanks for using this program! Please come back soon");

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        string FirstName, LastName;

        Console.Write("What is your first name? ");
        FirstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}");
    }
}
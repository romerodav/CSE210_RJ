using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        string userName;
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        int userNumber;
        string Value;
        Console.Write("Please enter your favorite number: ");
        Value = Console.ReadLine();
        userNumber = int.Parse(Value);
        return userNumber;
    }

    static int SquareNumber(int Number)
    {
        int squared = Number * Number;
        return squared;
    }

    static void DisplayResult(string Name, int Squared)
    {
        Console.WriteLine($"{Name}, the square of your number is {Squared}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        string Value;

        do
        {
            DisplayWelcome();

            DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));

            Console.Write("Do you wish to use this program again? Y/N: ");
            Value = Console.ReadLine();

            Console.Clear();

        }while (Value == "Y" | Value == "y");

        Console.WriteLine("Thanks for using this program! Please come back soon");

    }
}
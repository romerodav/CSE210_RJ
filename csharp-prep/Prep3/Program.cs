using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string Value;
        int Magic, Guess, Counter;
        Random randomGenerator = new Random();

        do
        {
            //Console.Write("What is the magic number? ");
            //Value = Console.ReadLine();
            //Magic = int.Parse(Value);

            Magic = randomGenerator.Next(1, 101);
            Counter = 0;
            Console.WriteLine("There is a Magig Number and you must guess it!");

            do
            {
                Console.Write("What is your guess? ");
                Value = Console.ReadLine();

                Guess = int.Parse(Value);

                Counter++;

                if (Guess < Magic) Console.WriteLine("Higher");
                else if (Guess > Magic) Console.WriteLine("Lower");
                else Console.WriteLine($"Congratulations: You guessed it! And used {Counter} times");

            }while (Guess != Magic);

            Console.Write("Do you wish to use this program again? Y/N: ");
            Value = Console.ReadLine();

            Console.Clear();

        }while (Value == "Y" | Value == "y");

        Console.WriteLine("Thanks for using this program! Please come back soon");

    }
}
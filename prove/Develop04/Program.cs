using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        string opt;

        do
        {
            Console.Write("Please select one of the following choices:\n1-Start breathing activity\n2-Start reflecting activity\n3-Start listing activity\n4-Quit\nWhat would you like to do? ");
            opt = Console.ReadLine();
            opt = opt.Trim();

            if (opt == "1" | opt == "2" | opt == "3")
            {
                if(opt == "1") Console.WriteLine("Welcome to the Breathing Activity!");
                else
                {
                    if (opt == "2") Console.WriteLine("Welcome to the Reflecting Activity!");
                    else Console.WriteLine("Welcome to the Listing Activity!");
                }
                Console.Write("Please press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
            Console.Clear();
        }while(opt != "4");
        Console.WriteLine("Thank you for using this program! Please come back soon");
    }
}
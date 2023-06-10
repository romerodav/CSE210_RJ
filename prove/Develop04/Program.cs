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
                if(opt == "1") Console.WriteLine("Welcome to the Breathing Activity!\n\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing\n\nHow long, in seconds, would you like for your session?");
                else
                {
                    if (opt == "2") Console.WriteLine("Welcome to the Reflecting Activity!\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life\n\nHow long, in seconds, would you like for your session?");
                    else Console.WriteLine("Welcome to the Listing Activity!\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area\n\nHow long, in seconds, would you like for your session?");
                }
                Console.Write("Please press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
            Console.Clear();
        }while(opt != "4");
        Console.WriteLine("Thank you for using this program! Please come back soon");
    }
}
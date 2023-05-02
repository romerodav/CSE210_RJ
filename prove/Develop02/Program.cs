using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        string Opt;
        do
        {
            Console.WriteLine("Please select one of the following choices:\n1-Write\n2-Display\n3-Load\n4-Save\n5-Quit");
            Opt = Console.ReadLine();
            if (Opt == "1") Console.WriteLine("Hola!");
            Console.Clear();
        }while(Opt != "5");
        Console.WriteLine("Thank you for using this program! Please come back soon");
    }
}
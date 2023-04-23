using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        string Value;
        List<int> Numbers = new List<int>();
        int Aux, Sum, Largest, SmalPos;
        float Average;

        do
        {
            Console.WriteLine("Enter a list of numbers, please type 0 to finish");

            Sum=0;

            do
            {
                Console.Write("Enter number: ");
                Value = Console.ReadLine();
                Aux = int.Parse(Value);
                if (Aux != 0) Numbers.Add(Aux);

            }while(Aux != 0);

            Console.WriteLine($"You have {Numbers.Count} numbers in your list");

            foreach (int Number in Numbers) Sum += Number;
            Console.WriteLine($"Sum: {Sum}");

            Average = (float)Sum / Numbers.Count;
            Console.WriteLine($"Average: {Average}");

            Largest = Numbers[0];
            foreach (int Number in Numbers) if (Number > Largest) Largest = Number;
            Console.WriteLine($"Largest Number: {Largest}");

            SmalPos = Numbers[0];
            foreach (int Number in Numbers) if (Number < SmalPos & Number > 0) SmalPos = Number;
            Console.WriteLine($"Small Positive Number: {SmalPos}");

            Console.WriteLine("Sorted List:");
            Numbers.Sort();
            foreach (int Number in Numbers) Console.WriteLine(Number);

            Console.Write("Do you wish to use this program again? Y/N: ");
            Value = Console.ReadLine();

            Numbers.Clear();
            Console.Clear();

        }while (Value == "Y" | Value == "y");

        Console.WriteLine("Thanks for using this program! Please come back soon");

    }
}
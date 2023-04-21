using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        string Sign, Letter, Value = "1";
        int Numb;

        while (Value == "1")
        {

            Numb = 101;

            while (Numb < 0 | Numb > 100)
            {
                Console.Write("Please enter a number for zero to one hundred: ");
                Letter = Console.ReadLine();
                Numb = int.Parse(Letter);
            }

            if (Numb >= 90) Letter = "A";
            else if (Numb >= 80) Letter = "B";
            else if (Numb >= 70) Letter = "C";
            else if (Numb >= 60) Letter = "D";
            else Letter = "F";

            if (Numb % 10 >= 7) Sign = "+";
            else if (Numb % 10 < 3) Sign = "-";
            else Sign = "";

            if (Numb > 96 | Numb < 60) Sign = "";

            if (Numb >= 70) Console.Write("Congratulations! You passed the course. ");
            else Console.Write("Sorry! Please try it again. You failed the course. ");

            Console.WriteLine($"Your mark is {Letter}{Sign}");

            Console.Write("Do you wish to use this program again? Y/N: ");
            Value = Console.ReadLine();

            if (Value == "Y" | Value == "y")
            {
                Value = "1";
            }
            else
            {
                Value = "0";
            }
            Console.Clear();
        }

        Console.WriteLine("Thanks for using this program! Please come back soon");

    }
}
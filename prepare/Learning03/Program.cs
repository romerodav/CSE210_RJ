using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        Fraction Fract;
        string Aux;
        int numerator, denominator;

        do
        {
            Console.Clear();

            Fract = new Fraction();
            Console.WriteLine("This program show a fraction in the way: " + Fract.GetFractionString() + " or in its decimal value: " + Fract.GetDecimalValue());

            Console.Write("Please enter a whole number as the numerator: ");
            Aux = Console.ReadLine();
            numerator = int.Parse(Aux);

            Fract = new Fraction(numerator);
            Console.WriteLine($"You have enter the number: {Fract.GetDecimalValue()}");

            denominator = 0;
            while(denominator == 0)
            {
                Console.Write("Please enter a whole nonzero number as the denominator: ");
                Aux = Console.ReadLine();
                denominator = int.Parse(Aux);
            }

            Fract = new Fraction(numerator, denominator);
            Console.WriteLine("You have enter the fraction: " + Fract.GetFractionString() + $" or the number: {Fract.GetDecimalValue()}");

            Console.Write("Please change the numerator for another whole number: ");
            Aux = Console.ReadLine();
            numerator = int.Parse(Aux);            

            Fract.SetTop(numerator);
            Console.WriteLine($"You have enter the numerator: {Fract.GetTop()}");

            Console.WriteLine("You have enter the fraction: " + Fract.GetFractionString() + $" or the number: {Fract.GetDecimalValue()}");

            denominator = 0;
            while(denominator == 0)
            {
                Console.Write("Please change the denominator for another whole nonzero number: ");
                Aux = Console.ReadLine();
                denominator = int.Parse(Aux);
            }

            Fract.SetBottom(denominator);
            Console.WriteLine($"You have enter the denominator: {Fract.GetBottom()}");

            Console.WriteLine("You have enter the fraction: " + Fract.GetFractionString() + $" or the number: {Fract.GetDecimalValue()}");

            Console.Write("Do you wish to run this program again? Y/N: ");
            Aux = Console.ReadLine();
        }while(Aux == "Y" | Aux == "y");

        Console.WriteLine("Thank you for using this program! Please come back soon");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");


        string op, color, dimen;
        double dim, dimad;


        do
        {
            Console.Write("Choose the shape you wish to work with:\n\n1-Create a New Goal\n2-Rectangle\n3-Circle\n4-List\n5-Quit\n\nPlease enter your option: ");
            op = Console.ReadLine();
            op = op.Trim();

            if(op == "1" | op == "2" | op == "3" | op == "4" | op == "5")
            {
                if(op == "4") Console.WriteLine($"{op} color {op} and area {op}");
                else
                {
                    Console.Write("Please enter the shape color: ");
                    color = Console.ReadLine();
                    color = color.Trim();

                    if(op == "1")
                    {
                        Console.Write("Please enter the square side: ");
                        dimen = Console.ReadLine();
                        dim = double.Parse(dimen.Trim());

                        Console.WriteLine($"Square color {op} and area {op}");

                    }
                    else
                    {
                        if(op == "2")
                        {
                            Console.Write("Please enter the rectangle width: ");
                            dimen = Console.ReadLine();
                            dim = double.Parse(dimen.Trim());
                            Console.Write("Please enter the rectangle length: ");
                            dimen = Console.ReadLine();
                            dimad = double.Parse(dimen.Trim());

                            Console.WriteLine($"Square color {op} and area {op}");

                        }
                        else
                        {
                            if(op == "3") Console.Write("Please enter the circle radius: ");
                            else
                            {
                                dimen = Console.ReadLine();
                                dim = double.Parse(dimen.Trim());
                            }

                            Console.WriteLine($"Square color {op} and area {op}");

                        }
                    }
                }
                Console.Write("Please press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
            Console.Clear();
        }while(op != "6");
        Console.WriteLine("Thanks for using this program! Please come back soon...");
    }
}
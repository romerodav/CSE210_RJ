using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        string op;
        Goals goals = new Goals();

        do
        {
            Console.Write($"You have {goals.GetPoints()} points\n\nMenu Options:\n\n1-Create a New Goal\n2-List Goals\n3-Save Goals\n4-Load Goals\n5-Record Event\n6-Quit\n\nPlease enter your option: ");
            op = Console.ReadLine();
            op = op.Trim();

            if(op == "1" | op == "2" | op == "3" | op == "4" | op == "5")
            {
                if(op == "1") goals.Create();
                else
                {
                    if(goals.Account() == 0 & op != "4")  Console.WriteLine("There are NO goals created still!");
                    else
                    {
                        if(op == "2" | op == "5")
                        {
                            goals.List();
                            if(op == "5") goals.RecordEvent();
                        }
                        else
                        {
                            goals.FileName();
                            if(op == "3") goals.SaveToFile();
                            else goals.ReadFromFile();
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
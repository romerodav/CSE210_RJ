using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        string opt;
        Breathing breath = new Breathing();
        Reflecting reflect = new Reflecting();
        Listing list = new Listing();
        Spin spinner = new Spin();

        do
        {
            Console.Write("Please select one of the following choices:\n1-Start breathing activity\n2-Start reflecting activity\n3-Start listing activity\n4-Quit\nWhat would you like to do? ");
            opt = Console.ReadLine();
            opt = opt.Trim();

            if (opt == "1" | opt == "2" | opt == "3")
            {
                Console.Clear();
                if(opt == "1")
                {
                    breath.ActivityIntrod();
                    breath.ActivityClose();
                }
                else
                {
                    if (opt == "2")
                    {
                        reflect.ActivityIntrod();
                        reflect.ActivityClose();
                    }
                    else
                    {
                        list.ActivityIntrod();
                        list.ActivityClose();
                    }
                }
                /*Console.Write("Please press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);*/
                spinner.SpinRun();
            }
            Console.Clear();
        }while(opt != "4");
        Console.WriteLine("Thank you for using this program! Please come back soon");
    }
}
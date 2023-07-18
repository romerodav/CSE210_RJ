using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        string op, opt, aux;
        int year, month, day, maxDay;
        double length, distance, speed, laps;
        Running running, run = new Running(5, 2023, 8, 20, 240);
        Cycling cycling, cyc = new Cycling(30, 2023, 9, 15, 50);
        Swimming swimming, swim = new Swimming(10, 2023, 7, 28, 30);
        List<Activity> activities = new List<Activity>(), repository = new List<Activity>(){run, cyc, swim};

        do
        {
            Console.Write("Menu Options:\n\n1-Create a new Activity\n2-Get Summary\n3-Load Pre Recorded Events\n4-Quit\n\nPlease enter your option: ");
            op = Console.ReadLine();
            op = op.Trim();

            if(op == "1" | op == "2" | op == "3")
            {
                if(op == "1")
                {
                    Console.WriteLine("The types of Activities are:\n1-Running\n2-Cycling\n3-Swimming");

                    do
                    {
                        Console.Write("Which type of Activity would you like to create? ");
                        opt = Console.ReadLine();
                        opt = opt.Trim();
                    }while(opt != "1" & opt != "2" & opt != "3");

                    do
                    {
                        do
                        {
                            Console.Write("Please enter the year of the Activity: ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        year = int.Parse(aux);
                    }while(year < 2023);

                    do
                    {
                        do
                        {
                            Console.Write("Please enter the number of month of the Activity: ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        month = int.Parse(aux);
                    }while(month <= 0 | month > 12);

                    switch(month)
                    {
                        case 1: 
                            maxDay = 31;
                            break;
                        case 2: 
                            maxDay = 29;
                            break;
                        case 3: 
                            maxDay = 31;
                            break;
                        case 4: 
                            maxDay = 30;
                            break;
                        case 5: 
                            maxDay = 31;
                            break;
                        case 6: 
                            maxDay = 30;
                            break;
                        case 7: 
                            maxDay = 31;
                            break;
                        case 8: 
                            maxDay = 31;
                            break;
                        case 9: 
                            maxDay = 30;
                            break;
                        case 10: 
                            maxDay = 31;
                            break;
                        case 11: 
                            maxDay = 30;
                            break;
                        case 12: 
                            maxDay = 31;
                            break;
                        default:
                            maxDay = 0;
                            break;
                    }

                    do
                    {
                        do
                        {
                            Console.Write("Please enter the day of the Activity: ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        day = int.Parse(aux);
                    }while(day <= 0 | day > maxDay);

                    do
                    {
                        do
                        {
                            Console.Write("Please enter the length in minutes of the Activity: ");
                            aux = Console.ReadLine();
                            aux = aux.Trim();
                        }while(aux == "");
                        length = double.Parse(aux);
                    }while(length <= 0);

                    if(opt == "1")
                    {
                        do
                        {
                            do
                            {
                                Console.Write("Please enter the distance for the Running in km: ");
                                aux = Console.ReadLine();
                                aux = aux.Trim();
                            }while(aux == "");
                            distance = double.Parse(aux);
                        }while(distance <= 0);

                        running = new Running(distance, year, month, day, length);
                        activities.Add(running);
                    }
                    else
                    {
                        if(opt == "2")
                        {
                            do
                            {
                                do
                                {
                                    Console.Write("Please enter the speed of the Cycling in Kph: ");
                                    aux = Console.ReadLine();
                                    aux = aux.Trim();
                                }while(aux == "");
                                speed = double.Parse(aux);
                            }while(speed <= 0);

                            cycling = new Cycling(speed, year, month, day, length);
                            activities.Add(cycling);
                        }
                        else
                        {
                            do
                            {
                                do
                                {
                                    Console.Write("Please enter the quantity of laps of 50 metres, making by Swimming: ");
                                    aux = Console.ReadLine();
                                    aux = aux.Trim();
                                }while(aux == "");
                                laps = double.Parse(aux);
                            }while(laps <= 0);

                            swimming = new Swimming(laps, year, month, day, length);
                            activities.Add(swimming);
                        }
                    }
                }
                else
                {
                    if(activities.Count == 0 & op != "3")  Console.WriteLine("There are NO Activities tracked still!");
                    else
                    {
                        if(op == "2") foreach(Activity activity in activities) Console.WriteLine($"{activity.GetSummary()}");
                        else
                        {
                            activities.AddRange(repository);
                            Console.WriteLine("Repository added");
                        }
                    }
                }
                Console.Write("Please press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
            Console.Clear();
        }while(op != "4");
        Console.WriteLine("Thanks for using this program! Please come back soon...");
    }
}
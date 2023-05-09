using System;

class Program
{
    static void SaveToFile(List<Entrie> Journ, string FilNam)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(FilNam))
        {
            foreach(Entrie Entr in Journ) outputFile.WriteLine($"{Entr._quest}__{Entr._ans}__{Entr._dateTimeText}");
        }
    }

    static List<Entrie> ReadFromFile(string FilNam)
    {
        Console.WriteLine("Reading List from a file...");
        List<Entrie> Journ = new List<Entrie>();
        Entrie Entr1 = new Entrie(), Entr2 = new Entrie(), Entr3 = new Entrie(), Entr4 = new Entrie(), Entr5 = new Entrie();
        string[] Lines = System.IO.File.ReadAllLines(FilNam);
        foreach(string Line in Lines)
        {
            // Console.WriteLine(Line); // Just as it is recorded in the text file
            string[] Parts = Line.Split("__");
            switch(Parts[0].Substring(0,1))
            {
                case "1": 
                    Entr1._quest = Parts[0];
                    Entr1._ans = Parts[1];
                    Entr1._dateTimeText = Parts[2];
                    Journ.Add(Entr1);
                    break;
                case "2": 
                    Entr2._quest = Parts[0];
                    Entr2._ans = Parts[1];
                    Entr2._dateTimeText = Parts[2];
                    Journ.Add(Entr2);
                    break;
                case "3": 
                    Entr3._quest = Parts[0];
                    Entr3._ans = Parts[1];
                    Entr3._dateTimeText = Parts[2];
                    Journ.Add(Entr3);
                    break;
                case "4": 
                    Entr4._quest = Parts[0];
                    Entr4._ans = Parts[1];
                    Entr4._dateTimeText = Parts[2];
                    Journ.Add(Entr4);
                    break;
                default:
                    Entr5._quest = Parts[0];
                    Entr5._ans = Parts[1];
                    Entr5._dateTimeText = Parts[2];
                    Journ.Add(Entr5);
                    break;
            }
        }
        return Journ;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        DateTime DateAndTime;

        Random randomGenerator = new Random();
        int Rand;

        string Opt, Quest, Ans, DateTimeText, FileName;

        Entrie Ent1 = new Entrie(), Ent2 = new Entrie(), Ent3 = new Entrie(), Ent4 = new Entrie(), Ent5 = new Entrie();
        List<Entrie> Journal = new List<Entrie>();

        do
        {
            Console.Write("Please select one of the following choices:\n1-Write\n2-Display\n3-Load\n4-Save\n5-Quit\nWhat would you like to do: ");
            Opt = Console.ReadLine();
            if (Opt == "1")
            {
                Rand = randomGenerator.Next(1, 6);
                Ans = "";
                DateTimeText = "";

                switch(Rand)
                {
                    case 1: 
                        Quest = "1-Who was the most interesting person I interacted with today?";
                        break;
                    case 2: 
                        Quest = "2-What was the best part of my day?";
                        break;
                    case 3: 
                        Quest = "3-How did I see the hand of the Lord in my life today?";
                        break;
                    case 4: 
                        Quest = "4-What was the strongest emotion I felt today?";
                        break;
                    default:
                        Quest = "5-If I had one thing I could do over today, what would it be?";
                        break;
                }
                Console.WriteLine(Quest);
                while (Ans == "")
                {
                    Console.Write("Please write something about: ");
                    Ans =  Console.ReadLine();
                }

                DateAndTime = DateTime.Now;
                DateTimeText = DateAndTime.ToShortDateString() + " at " + DateAndTime.ToShortTimeString();

                switch(Rand)
                {
                    case 1:
                        Ent1._quest = Quest;
                        Ent1._ans = Ans;
                        Ent1._dateTimeText = DateTimeText;
                        Journal.Add(Ent1);
                        break;
                    case 2:
                        Ent2._quest = Quest;
                        Ent2._ans = Ans;
                        Ent2._dateTimeText = DateTimeText;
                        Journal.Add(Ent2);
                        break;
                    case 3:
                        Ent3._quest = Quest;
                        Ent3._ans = Ans;
                        Ent3._dateTimeText = DateTimeText;
                        Journal.Add(Ent3);
                        break;
                    case 4:
                        Ent4._quest = Quest;
                        Ent4._ans = Ans;
                        Ent4._dateTimeText = DateTimeText;
                        Journal.Add(Ent4);
                        break;
                    default:
                        Ent5._quest = Quest;
                        Ent5._ans = Ans;
                        Ent5._dateTimeText = DateTimeText;
                        Journal.Add(Ent5);
                        break;
                }
            }

            if (Opt == "2")
            {
                if(Journal.Count != 0) foreach(Entrie Ent in Journal) Ent.ShowEntrie();
                else Console.WriteLine("Journal List is empty!");
                Console.Write("Press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }

            if (Opt == "3")
            {
                FileName = "";
                while (FileName == "")
                {
                    Console.Write("What is the file name: ");
                    FileName = Console.ReadLine();
                }
                Journal.AddRange(ReadFromFile(FileName));

                Console.Write("Press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }

            if (Opt == "4")
            {
                if(Journal.Count != 0)
                {
                    FileName = "";
                    while (FileName == "")
                    {
                        Console.Write("What is the file name: ");
                        FileName = Console.ReadLine();
                    }
                    SaveToFile(Journal,FileName);
                }
                else Console.WriteLine("Journal List is empty!");
                Console.Write("Press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }

            Console.Clear();
        }while(Opt != "5");
        Console.WriteLine("Thank you for using this program! Please come back soon");
    }
}
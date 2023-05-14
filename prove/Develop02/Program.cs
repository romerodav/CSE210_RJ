using System;

class Program
{
    static void SaveToFile(Journal Journ, string FilNam)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(FilNam))
        {
            foreach(Entrie Entr in Journ._entries) outputFile.WriteLine($"{Entr._quest}__{Entr._ans}__{Entr._dateTimeText}");
        }
    }

    static Journal ReadFromFile(string FilNam)
    {
        Console.WriteLine("Reading List from a file...");
        Journal Journ = new Journal();
        string[] Lines = System.IO.File.ReadAllLines(FilNam);
        foreach(string Line in Lines)
        {
            // Console.WriteLine(Line); // Just as it is recorded in the text file
            string[] Parts = Line.Split("__");
            Journ.AddEntrie(Parts[0], Parts[1], Parts[2]);
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
        Journal Jour= new Journal();

        do
        {
            Console.Write("Please select one of the following choices:\n1-Write\n2-Display\n3-Load\n4-Save\n5-Quit\nWhat would you like to do? ");
            Opt = Console.ReadLine();

            if (Opt == "1" | Opt == "2" | Opt == "3" | Opt == "4")
            {
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
                    while (Ans.Trim() == "")
                    {
                        Console.Write("Please write something about: ");
                        Ans =  Console.ReadLine();
                    }

                    DateAndTime = DateTime.Now;
                    DateTimeText = DateAndTime.ToShortDateString() + " at " + DateAndTime.ToLongTimeString();
                    Jour.AddEntrie(Quest, Ans, DateTimeText);
                }
                else
                {
                    if(Jour._entries.Count == 0 & Opt != "3")  Console.WriteLine("Journal List is empty!");
                    else
                    {
                        if(Opt == "2") foreach(Entrie Ent in Jour._entries) Ent.ShowEntrie();
                        else
                        {
                            FileName = "";
                            while (FileName.Trim() == "")
                            {
                                Console.Write("What is the file name? ");
                                FileName = Console.ReadLine();
                            }
                            if (Opt == "3") Jour._entries.AddRange(ReadFromFile(FileName)._entries);
                            else SaveToFile(Jour,FileName);
                        }
                    }
                    Console.Write("Please press <Enter> to exit...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter);
                }
            }
            Console.Clear();
        }while(Opt != "5");
        Console.WriteLine("Thank you for using this program! Please come back soon");
    }
}
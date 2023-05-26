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
        string Opt, Ans, DateTimeText, FileName;
        Journal Jour= new Journal();
        Prompt Question = new Prompt("default");

        do
        {
            Console.Write("Please select one of the following choices:\n1-Write\n2-Display\n3-Load\n4-Save\n5-Quit\nWhat would you like to do? ");
            Opt = Console.ReadLine();

            if (Opt == "1" | Opt == "2" | Opt == "3" | Opt == "4")
            {
                if(Opt == "1")
                {
                    if(Question.QuestQuant() > 0)
                    {
                        Rand = randomGenerator.Next(Question.QuestQuant());
                        Ans = "";
                        DateTimeText = "";

                        Console.WriteLine(Question.ObtainQuest(Rand));
                        while(Ans.Trim() == "")
                        {
                            Console.Write("Please write something about: ");
                            Ans =  Console.ReadLine();
                        }

                        DateAndTime = DateTime.Now;
                        DateTimeText = DateAndTime.ToShortDateString() + " at " + DateAndTime.ToLongTimeString();
                        Jour.AddEntrie(Question.ObtainQuest(Rand), Ans.Trim(), DateTimeText);
                        Question.DelQuest(Rand);
                    }
                    else
                    {
                        Console.Write("Questions are over. Would you like to enter a question for the next time? (Y/N): ");
                        Ans = Console.ReadLine();
                        Ans = Ans.Trim();
                        if(Ans.ToUpper() == "Y")
                        {
                            Ans = "";
                            while(Ans.Trim() == "")
                            {
                                Console.Write("Please write it without the question mark: ");
                                Ans =  Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.Write("Would you like to recover the previous questions for the next time? Y/N: ");
                            Ans =  Console.ReadLine();
                            Ans = Ans.Trim();
                            if(Ans.ToUpper() == "Y") Ans = "default";
                            else Ans = "";
                        }
                        if(Ans != "") Question.AddQuest(Ans.Trim());
                    }
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
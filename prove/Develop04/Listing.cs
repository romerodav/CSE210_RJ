using System.Diagnostics;

public class Listing : Activity
{
    private Random _rand = new Random();

    private List<string> _prompts = new List<string>(){"Who are people that you appreciate", "What are personal strengths of yours", "Who are people that you have helped this week", "When have you felt the Holy Ghost this month", "Who are some of your personal heroes"};

    private Stopwatch sw = new Stopwatch();

    private double lasFrame;

    private double deltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds, dt = firstFrame - lasFrame;

        this.lasFrame = ts.TotalMilliseconds;
        return dt;
    }

    /*public Listing(): base()
    {
    }*/

    public Listing(string welcome = "Welcome to the Listing Activity!", string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", string ending = "Listing", int duration = 0): base(welcome, description, ending, duration)
    {
    }

    public void ListRun()
    {
        sw.Reset();
        this.sw.Start();
        double acc = 0.0;
        ConsoleKeyInfo key;
        int i, wait = 5, pace = 1000;
        string bufStr;
        List<string> buf = new List<string>();

        if (_prompts.Count == 0)
        {
            _prompts.Add("Who are people that you appreciate");
            _prompts.Add("What are personal strengths of yours");
            _prompts.Add("Who are people that you have helped this week");
            _prompts.Add("When have you felt the Holy Ghost this month");
            _prompts.Add("Who are some of your personal heroes");
        }
        i = _rand.Next(_prompts.Count);
        Console.Write($"Please list as many responses you can to the following prompt:\n\n --- {_prompts[i]}? ---\n\nAfter you have written something you had in mind, please press ENTER to continue\n\nYou may begin in ");
        _prompts.RemoveAt(i);
        i = 0;
        while (i < wait)
        {
            Console.Write($"{wait - i}");
            Thread.Sleep(pace);
            Console.Write("\b \b");
            i++;
        }
        Console.Write("\n\n> ");
        i = 0;
        while(acc <= 1000.0 * GetDuration())
        {
            acc += this.deltaTime();
            if(!Console.KeyAvailable) continue;
            else
            {
                key = Console.ReadKey();
                if(key.Key == ConsoleKey.Enter)
                {
                    Console.Write("\n> ");
                    buf.Add("\n");
                    i++;
                }
                else buf.Add(key.KeyChar.ToString());
            }
        }
        Console.WriteLine($"\n\nYou listed {i} complete items!\n");
        bufStr = String.Join<string>("", buf);
        sw.Reset();
    }
}
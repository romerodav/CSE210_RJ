using System.Diagnostics;

public class Reflecting : Activity
{
    private Random _rand = new Random();

    private List<string> _questions = new List<string>(), _prompts = new List<string>(){"stood up for someone else", "did something really difficult", "helped someone in need", "did something truly selfless"};

    Spin _spin = new Spin(7);

    private Stopwatch sw = new Stopwatch();
    private double lasFrame;

    private double deltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds, dt = firstFrame - lasFrame;

        this.lasFrame = ts.TotalMilliseconds;
        return dt;
    }

    /*public Reflecting(): base()
    {
    }*/

    public Reflecting(string welcome = "Welcome to the Reflecting Activity!", string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", string ending = "Reflecting", int duration = 0) : base(welcome, description, ending, duration)
    {
    }

    public void ReflectRun()
    {
        sw.Reset();
        this.sw.Start();
        double acc = 0.0;
        ConsoleKeyInfo key;
        int i, wait = 5, pace = 1000, ban = 0;

        if (_prompts.Count == 0)
        {
            _prompts.Add("stood up for someone else");
            _prompts.Add("did something really difficult");
            _prompts.Add("helped someone in need");
            _prompts.Add("did something truly selfless");
        }
        i = _rand.Next(_prompts.Count);
        Console.WriteLine($"Please consider the following prompt:\n\n --- Think of a time when you {_prompts[i]} ---\n\nWhen you have something in mind, please press ENTER to continue");
        _prompts.RemoveAt(i);
        while (acc <= 1000.0 * GetDuration())
        {
            acc += this.deltaTime();
            if(ban == 0)
            {
                if (!Console.KeyAvailable) continue;
                else
                {
                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Enter)
                    {
                        i = 0;
                        Console.Write("\nNow ponder on each of the following questions as they relates to this experience\nYou may begin in: ");
                        while (i < wait)
                        {
                            Console.Write($"{wait - i}");
                            Thread.Sleep(pace);
                            Console.Write("\b \b");
                            i++;
                        }
                        Console.Clear();
                        ban = 1;
                    }
                }
            }
            else
            {
                if(_questions.Count == 0)
                {
                    _questions.Add("Why was this experience meaningful to you");
                    _questions.Add("Have you ever done anything like this before");
                    _questions.Add("How did you get started");
                    _questions.Add("How did you feel when it was complete");
                    _questions.Add("What made this time different than other times when you were not as successful");
                    _questions.Add("What is your favorite thing about this experience");
                    _questions.Add("What could you learn from this experience that applies to other situations");
                    _questions.Add("What did you learn about yourself through this experience");
                    _questions.Add("How can you keep this experience in mind in the future");
                }
                i = _rand.Next(_questions.Count);
                Console.Write($"> {_questions[i]}? ");
                _spin.SpinRun();
                _questions.RemoveAt(i);
                if(_questions.Count == 0)
                {
                    Console.Clear();
                    if (_prompts.Count == 0)
                    {
                        _prompts.Add("stood up for someone else");
                        _prompts.Add("did something really difficult");
                        _prompts.Add("helped someone in need");
                        _prompts.Add("did something truly selfless");
                    }
                    i = _rand.Next(_prompts.Count);
                    Console.WriteLine($"In the remaining time, we propose you another prompt\nPlease consider the following prompt:\n\n --- Think of a time when you {_prompts[i]} ---\n\nWhen you have something in mind, please press ENTER to continue");
                    _prompts.RemoveAt(i);
                    ban = 0;
                }
            }
        }
        Console.WriteLine();
        sw.Reset();
    }
}
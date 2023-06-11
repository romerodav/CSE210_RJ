public class Activity
{
    private string _welcome, _description, _ending;
    private int _duration;
    private Spin _spinner = new Spin();

    public Activity()
    {
    }

    public Activity(string welcome = "", string description = "", string ending = "", int duration = 0)
    {
        _welcome = welcome;
        _description = description;
        _ending = ending;
        _duration = duration;
    }

    public void SetActivity(string welcome = "", string description = "", string ending = "", int duration = 0)
    {
        _welcome = welcome;
        _description = description;
        _ending = ending;
        _duration = duration;
    }

    public void SetWelcome(string welcome = "")
    {
        _welcome = welcome;
    }

    public void SetDescription(string description = "")
    {
        _description = description;
    }

    public void SetEnding(string ending = "")
    {
        _ending = ending;
    }

    public void SetDuration(int duration = 0)
    {
        _duration = duration;
    }

    public string GetWelcome()
    {
        return _welcome;
    }
    public string GetDescription()
    {
        return _description;
    }

    public string GetEnding()
    {
        return _ending;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ActivityIntrod()
    {
        string aux;
        int seconds;

        Console.WriteLine($"{_welcome}\n\n{_description}\n");
        do
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            aux = Console.ReadLine();
            seconds = int.Parse(aux.Trim());
        }while(seconds <= 0);
        _duration = seconds;
        Console.Clear();
        Console.WriteLine("Get ready...");
        _spinner.SpinRun();
        Console.WriteLine();
    }

    public void ActivityClose()
    {
        Console.WriteLine("Well done!!");
        _spinner.SpinRun();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_ending} Activity");
    }
}
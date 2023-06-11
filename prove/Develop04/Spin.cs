public class Spin
{
    private int _durationSec, _pace;
    List<string> _spinList = new List<string>(){
        "|", "/", "-", "\\", "|", "/", "-", "\\"
    };

    public Spin(int duration = 5, int pace = 750)
    {
        _durationSec = duration;
        _pace = pace;
    }

    public void SetDurationSec(int duration)
    {
        _durationSec = duration;
    }

    public void SetPace(int pace)
    {
        _pace = pace;
    }

    public void SpinRun()
    {
        DateTime startTime = DateTime.Now, endTime = startTime.AddSeconds(_durationSec);
            int i=0;

        while(DateTime.Now < endTime)
        {
            Console.Write(_spinList[i]);
            Thread.Sleep(_pace);
            Console.Write("\b \b");
            i++;
            if(i >= _spinList.Count) i=0;
        }
        Console.WriteLine();
    }
}
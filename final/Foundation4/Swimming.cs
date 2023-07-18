public class Swimming : Activity
{
    private double _laps;

    public Swimming(double laps = 0, int year = 0, int month = 0, int day = 0, double length = 0) : base(year, month, day, length)
    {
        _laps = laps;
        SetActivity("Swimming");
    }

    public double GetLaps()
    {
        return _laps;
    }

    public void SetLaps(double laps)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * .05;
    }

    public override double GetSpeed()
    {
        return _laps * .05 * 60.0 / GetLength();
    }

    public override double GetPace()
    {
        return GetLength() / (_laps * .05);
    }
}
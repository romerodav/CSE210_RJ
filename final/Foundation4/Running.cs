public class Running : Activity
{
    private double _distance;

    public Running(double distance = 0, int year = 0, int month = 0, int day = 0, double length = 0) : base(year, month, day, length)
    {
        _distance = distance;
        SetActivity("Running");
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return _distance * 60.0 / GetLength();
    }

    public override double GetPace()
    {
        return GetLength() / _distance;
    }
}
public class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed = 0, int year = 0, int month = 0, int day = 0, double length = 0) : base(year, month, day, length)
    {
        _speed = speed;
        SetActivity("Cycling");
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return GetLength() * _speed / 60.0;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }
}
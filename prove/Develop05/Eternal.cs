public class Eternal : Goal
{
    public Eternal() : base()
    {
    }

    public Eternal(string name, string descript, int reward, int total = 0, int bonus = 0, int times = 0, int comp = 0) : base(name, descript, reward, total, bonus, times, comp)
    {
    }

    public override string ToFile()
    {
        return $"EternalGoal:{GetName()},{GetDescript()},{GetReward()}";
    }

    public override int Event()
    {
        return GetReward();
    }
}
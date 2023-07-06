public class Check : Goal
{
    public Check() : base()
    {
    }

    public Check(string name, string descript, int reward, int total, int bonus, int times = 0, int comp = 0) : base(name, descript, reward, total, bonus, times, comp)
    {
    }

    public override void Show()
    {
        string complete, current;
        if(GetComp() == 0) complete = " ";
        else complete = "X";
        current = $" -- Currently completed: {GetTimes()}/{GetTotal()}";
        Console.WriteLine($"[{complete}] {GetName()} ({GetDescript()}){current}");
    }

    public override string ToFile()
    {
        return $"CheckListGoal:{GetName()},{GetDescript()},{GetReward()},{GetBonus()},{GetTotal()},{GetTimes()}";
    }

    public override int Event()
    {
        int i;
        
        if(GetComp() != 0) return 0;
        else
        {
            i = GetTimes();
            i++;
            SetTimes(i);
            if(GetTimes() == GetTotal())
            {
                SetComp(1);
                return GetReward() + GetBonus();
            }
            else return GetReward();
        }
    }
}
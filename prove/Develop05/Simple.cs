public class Simple : Goal
{
    public Simple() : base()
    {
    }

    public Simple(string name, string descript, int reward, int total = 0, int bonus = 0, int times = 0, int winBonus = 0, int comp = 0) : base(name, descript, reward, total, bonus, times, winBonus, comp)
    {
    }

    public override string ToFile()
    {
        string final;

        if(GetComp() == 0) final = "False";
        else final = "True";

        return $"SimpleGoal:{GetName()},{GetDescript()},{GetReward()},{final}";
    }

    public override int Event()
    {
        if(GetComp() != 0) return 0;
        else
        {
            SetComp();
            return GetReward();
        }
    }
}
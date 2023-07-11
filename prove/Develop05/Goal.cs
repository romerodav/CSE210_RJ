public abstract class Goal
{
    private string _name, _descript;
    private int _reward, _total, _bonus, _times, _winBonus, _comp;

    public Goal()
    {
        _name = "";
        _descript = "";
        _reward = 0;
        _total = 0;
        _bonus = 0;
        _times = 0;
        _winBonus = 0;
        _comp = 0;
    }

    public Goal(string name, string descript, int reward, int total, int bonus, int times, int winBonus, int comp)
    {
        _name = name;
        _descript = descript;
        _reward = reward;
        _total = total;
        _bonus = bonus;
        _times = times;
        _winBonus = winBonus;
        _comp = comp;
    }

    public void Init(string name, string descript, int reward, int total = 0, int bonus = 0, int times = 0, int winBonus =0, int comp = 0)
    {
        _name = name;
        _descript = descript;
        _reward = reward;
        _total = total;
        _bonus = bonus;
        _times = times;
        _winBonus = winBonus;
        _comp = comp;
    }

    public virtual string GetName()
    {
        return _name;
    }

    public virtual void SetName(string name)
    {
        _name = name;
    }

    public virtual string GetDescript()
    {
        return _descript;
    }

    public virtual void SetDescript(string descript)
    {
        _descript = descript;
    }

    public virtual int GetReward()
    {
        return _reward;
    }

    public virtual void SetReward(int reward)
    {
        _reward = reward;
    }

    public virtual int GetTotal()
    {
        return _total;
    }

    public virtual void SetTotal(int total)
    {
        _total = total;
    }

    public virtual int GetBonus()
    {
        return _bonus;
    }

    public virtual void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public virtual int GetTimes()
    {
        return _times;
    }

    public virtual void SetTimes(int times)
    {
        _times = times;
    }

    public virtual int GetWinBonus()
    {
        return _comp;
    }

    public virtual void SetWinBonus(int winBonus = 1)
    {
        _winBonus = winBonus;
    }

    public virtual int GetComp()
    {
        return _comp;
    }

    public virtual void SetComp(int comp = 1)
    {
        _comp = comp;
    }

    public virtual void Show()
    {
        string complete;
        if(_comp == 0) complete = " ";
        else complete = "X";
        Console.WriteLine($"[{complete}] {_name} ({_descript})");
    }

    public abstract string ToFile();

    public abstract int Event();
}
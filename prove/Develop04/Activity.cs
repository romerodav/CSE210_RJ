public class Activity
{
    private string _welcome, _description, _ending;
    private int _duration;

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

    public void SeEnding(string ending = "")
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
}
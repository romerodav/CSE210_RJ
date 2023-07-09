public class Comment
{
    private string _name, _comment;

    public Comment(string name = "", string comment = "")
    {
        _name = name;
        _comment = comment;
    }

    public void Init(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetComment()
    {
        return _comment;
    }

    public void SetComment(string comment)
    {
        _comment = comment;
    }

    public void Show()
    {
        Console.WriteLine($"{_name} said: {_comment}");
    }
}
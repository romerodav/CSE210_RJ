public class Comment
{
    private string _name, _comment;

    public Comment(string name = "", string comment = "")
    {
        _name = name.Trim();
        _comment = comment.Trim();
    }

    public void Init(string name, string comment)
    {
        _name = name.Trim();
        _comment = comment.Trim();
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name.Trim();
    }

    public string GetComment()
    {
        return _comment;
    }

    public void SetComment(string comment)
    {
        _comment = comment.Trim();
    }

    public void Show()
    {
        Console.WriteLine($"{_name} said: {_comment}");
    }
}
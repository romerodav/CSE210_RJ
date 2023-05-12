public class Entrie
{
    public string _quest, _ans, _dateTimeText;

    public Entrie()
    {
    }

    public Entrie(string q, string a, string dTT)
    {
        _quest = q;
        _ans = a;
        _dateTimeText = dTT;
    }

    public void ShowEntrie()
    {
        Console.WriteLine($"Date and Time: {_dateTimeText} - Question: {_quest}\nYour answer: {_ans}");
    }
}
public class Entrie
{
    public string _quest, _ans, _dateTimeText;

    public Entrie()
    {
    }

    public void ShowEntrie()
    {
        Console.WriteLine($"Date and Time: {_dateTimeText} - Question: {_quest}\nYour answer: {_ans}");
    }
}
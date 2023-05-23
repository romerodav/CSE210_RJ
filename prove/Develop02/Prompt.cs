public class Prompt
{
    public List<string> _prompt;

    public Prompt()
    {
        _prompt= new List<string>();
    }

    public Prompt(string Quest)
    {
        _prompt = new List<string>();
        if(Quest == "default")
        {
            _prompt.Add("1-Who was the most interesting person I interacted with today?");
            _prompt.Add("2-What was the best part of my day?");
            _prompt.Add("3-How did I see the hand of the Lord in my life today?");
            _prompt.Add("4-What was the strongest emotion I felt today?");
            _prompt.Add("5-If I had one thing I could do over today, what would it be?");
        }
        else _prompt.Add(Quest);

    }

    public void AddQuest(string NewQuest)
    {
        _prompt.Add($"{_prompt.Count}-{NewQuest}?");
    }

    public int QuestQuant()
    {
        return _prompt.Count;
    }

    public string ObtainQuest(int QuestNumber)
    {
	    if(QuestNumber >= 0 & QuestNumber < _prompt.Count) return _prompt[QuestNumber];
        else return "";
    }

    public void ListQuest()
    {
        foreach(string Quest in _prompt) Console.WriteLine(Quest);
    }
}
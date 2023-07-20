public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker = "", int capacity = 0, string title = "", string descript = "", int year = 0, int month = 0, int day = 0, int hour = 0, int minute = 0) : base(title, descript, year, month, day, hour, minute)
    {
        SetEvenType("Lecture");
        _speaker = speaker.Trim();
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker.Trim();
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public string GetFullDet()
    {
        return $"{GetStanDet()}\nEvent: {GetEvenType()}\nSpeaker: {_speaker}\nCapacity: {_capacity} people";
    }
}
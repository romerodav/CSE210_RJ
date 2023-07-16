public class Reception : Event
{
    private string _rsvpMail;

    public Reception(string rsvpMail, string title = "", string descript = "", int year = 0, int month = 0, int day = 0, int hour = 0, int minute = 0) : base(title, descript, year, month, day, hour, minute)
    {
        SetEvenType("Reception");
        _rsvpMail = rsvpMail.Trim();
    }

    public string GetRSVPMail()
    {
        return _rsvpMail;
    }

    public void SetRSVPMail(string rsvpMail)
    {
        _rsvpMail = rsvpMail.Trim();
    }

    public string FullDet()
    {
        return $"{GetStanDet()}\nEvent: {GetEvenType()}\nSpeaker: {_rsvpMail}";
    }
}
public class Outdoor : Event
{
    private string _weatherFor;

    public Outdoor(string weatherFor, string title = "", string descript = "", int year = 0, int month = 0, int day = 0, int hour = 0, int minute = 0) : base(title, descript, year, month, day, hour, minute)
    {
        SetEvenType("Outdoor Gathering");
        _weatherFor = weatherFor.Trim();
    }

    public string GetWeatherFor()
    {
        return _weatherFor;
    }

    public void SetRSVPMail(string weatherFor)
    {
        _weatherFor = weatherFor.Trim();
    }

    public string GetFullDet()
    {
        return $"{GetStanDet()}\nEvent: {GetEvenType()}\nWeather Forecast: {_weatherFor}";
    }
}
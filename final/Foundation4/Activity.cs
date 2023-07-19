public abstract class Activity
{
    private int _year, _month, _day;
    private double _length;
    private string _activity = "";

    public Activity(int year = 0, int month = 0, int day = 0, double length = 0)
    {
        _year = year;
        _month = month;
        _day = day;
        _length = length;
    }

    public void Init(int year, int month, int day, double length)
    {
        _year = year;
        _month = month;
        _day = day;
        _length = length;
    }

    public string GetActivity()
    {
        return _activity;
    }

    public void SetActivity(string activity)
    {
        _activity = activity;
    }

    public int GetYear()
    {
        return _year;
    }

    public void SetYear(int year)
    {
        _year = year;
    }

    public int GetMonth()
    {
        return _month;
    }

    public void SetMonth(int month)
    {
        _month = month;
    }

    public int GetDay()
    {
        return _day;
    }

    public void SetDay(int day)
    {
        _day = day;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public string GetDate()
    {
        string month;

        switch(_month)
        {
            case 1: 
                month = "Jan";
                break;
            case 2: 
                month = "Feb";
                break;
            case 3: 
                month = "Mar";
                break;
            case 4: 
                month = "Apr";
                break;
            case 5: 
                month = "May";
                break;
            case 6: 
                month = "Jun";
                break;
            case 7: 
                month = "Jul";
                break;
            case 8: 
                month = "Aug";
                break;
            case 9: 
                month = "Sep";
                break;
            case 10: 
                month = "Oct";
                break;
            case 11: 
                month = "Nov";
                break;
            case 12: 
                month = "Dec";
                break;
            default:
                month = "Error";
                break;
        }

        return $"{_day.ToString("D2")} {month} {_year}";
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{GetDate()} {_activity} ({_length} min): Distance {GetDistance():N1} Km, Speed {GetSpeed():N1} kph, Pace {GetPace():N1} min per km";
    }
}
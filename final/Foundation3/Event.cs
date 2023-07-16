public class Event
{
    private string _type = "", _title, _descript;
    private int _year, _month, _day, _hour, _minute;
    private Address _address;

    public Event(string title = "", string descript = "", int year = 0, int month = 0, int day = 0, int hour = 0, int minute = 0)
    {
        _title = title.Trim();
        _descript = descript.Trim();
        _year = year;
        _month = month;
        _day = day;
        _hour = hour;
        _minute = minute;
        _address = new Address();
    }

    public void Init(string title, string descript = "", int year = 0, int month = 0, int day = 0, int hour = 0, int minute = 0)
    {
        _title = title.Trim();
        _descript = descript.Trim();
        _year = year;
        _month = month;
        _day = day;
        _hour = hour;
        _minute = minute;
    }

    public string GetEvenType()
    {
        return _type;
    }

    public void SetEvenType(string type)
    {
        _type = type.Trim();
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title.Trim();
    }

    public string GetDescript()
    {
        return _descript;
    }

    public void SetDescript(string descript)
    {
        _descript = descript.Trim();
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

    public int GetHour()
    {
        return _hour;
    }

    public void SetHour(int hour)
    {
        _hour = hour;
    }

    public int GetMinute()
    {
        return _minute;
    }

    public void SetMinute(int minute)
    {
        _minute = minute;
    }

    public string GetDate()
    {
        string month, day;

        switch(_month)
        {
            case 1: 
                month = "January";
                break;
            case 2: 
                month = "February";
                break;
            case 3: 
                month = "March";
                break;
            case 4: 
                month = "April";
                break;
            case 5: 
                month = "May";
                break;
            case 6: 
                month = "June";
                break;
            case 7: 
                month = "July";
                break;
            case 8: 
                month = "August";
                break;
            case 9: 
                month = "September";
                break;
            case 10: 
                month = "October";
                break;
            case 11: 
                month = "November";
                break;
            case 12: 
                month = "December";
                break;
            default:
                month = "Error";
                break;
        }

        switch(_day)
        {
            case 1: 
                day = "st";
                break;
            case 2: 
                day = "nd";
                break;
            default:
                day = "th";
                break;
        }

        return $"{month} {_day}{day} {_year}";
    }

    public string GetTime()
    {
        return $"{_hour}:{_minute}";
    }

    public void IntroAddress(string number, string street, string city, string stateOrProv, string country)
    {
        _address.SetNumber(number.Trim());
        _address.SetStreet(street.Trim());
        _address.SetCity(city.Trim());
        _address.SetStateOrProv(stateOrProv.Trim());
        _address.SetCountry(country.Trim());
    }

    public string GetNumber()
    {
        return _address.GetNumber();
    }

    public void SetNumber(string number)
    {
        _address.SetNumber(number.Trim());
    }

    public string GetStreet()
    {
        return _address.GetStreet();
    }

    public void SetStreet(string street)
    {
        _address.SetStreet(street.Trim());
    }

    public string GetCity()
    {
        return _address.GetCity();
    }

    public void SetCity(string city)
    {
        _address.SetCity(city.Trim());
    }

    public string GetStateOrProv()
    {
        return _address.GetStateOrProv();
    }

    public void SetStateOrProv(string stateOrProv)
    {
        _address.SetStateOrProv(stateOrProv.Trim());
    }

    public string GetCountry()
    {
        return _address.GetCountry();
    }

    public void SetCountry(string country)
    {
        _address.SetCountry(country.Trim());
    }

    public int IsInUSA()
    {
        if (_address.GetCountry().ToUpper() == "USA") return 1;
        else return 0;
    }

    public string GetSingleAddress()
    {
        return $"{_address.GetNumber()} {_address.GetStreet()}\n{_address.GetCity()}\n{_address.GetStateOrProv()}, {_address.GetCountry()}";
    }

    public string GetStanDet()
    {
        return $"Title: {_title}\nDescription: {_descript}\n{GetDate()} {GetTime()}\nAddress: {GetSingleAddress()}";
    }

    public string GetShortDescript()
    {
        return $"Type of event: {_type}\nTitle: {_title}\n{GetDate()}";
    }
}
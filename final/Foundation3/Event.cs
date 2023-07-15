public class Event
{
    private string _title, _descript;
    private int _year, _month, _day, _hour, _minute;
    private Address _address;

    public Event(string title = "", string descript = "", int year = 0, int month = 0, int day = 0, int hour = 0, int minute = 0)
    {
        _title = title;
        _descript = descript;
        _year = year;
        _month = month;
        _day = day;
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
        _minute = minute;
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
        return _year;
    }

    public void SetHour(int year)
    {
        _year = year;
    }

    public int GetMinute()
    {
        return _minute;
    }

    public void SetMinute(int minute)
    {
        _minute = minute;
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

    public string SingleAddress()
    {
        return $"{_address.GetNumber()} {_address.GetStreet()}\n{_address.GetCity()}\n{_address.GetStateOrProv()}, {_address.GetCountry()}";
    }
}
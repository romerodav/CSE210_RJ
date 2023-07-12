public class Address
{
    private string _number, _street, _city, _stateOrProv, _country;

    public Address(string number = "", string street = "", string city = "", string stateOrProv = "", string country = "")
    {
        _number = number.Trim();
        _street = street.Trim();
        _city = city.Trim();
        _stateOrProv = stateOrProv.Trim();
        _country = country.Trim();
    }

    public void Init(string number, string street, string city, string stateOrProv, string country)
    {
        _number = number.Trim();
        _street = street.Trim();
        _city = city.Trim();
        _stateOrProv = stateOrProv.Trim();
        _country = country.Trim();
    }

    public string GetNumber()
    {
        return _number;
    }

    public void SetNumber(string number)
    {
        _number = number.Trim();
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street.Trim();
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city.Trim();
    }

    public string GetStateOrProv()
    {
        return _stateOrProv;
    }

    public void SetStateOrProv(string stateOrProv)
    {
        _stateOrProv = stateOrProv.Trim();
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country.Trim();
    }

    public int ItIsInUSA()
    {
        if(_country.ToUpper() == "USA") return 1;
        else return 0;
    }

    public string SingleAddress()
    {
        return $"{_number} {_street}\n{_city}\n{_stateOrProv}, {_country}";
    }
}
public class Customer
{
    private string _name;
    private Address _address = new Address();

    public Customer(string name = "", string number = "", string street = "", string city = "", string stateOrProv = "", string country = "")
    {
        _name = name.Trim();
        _address.Init(number, street, city, stateOrProv, country);
    }

    public void Init(string name, string number, string street, string city, string stateOrProv, string country)
    {
        _name = name.Trim();
        _address.Init(number, street, city, stateOrProv, country);
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name.Trim();
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

    public string GetAddress()
    {
        return $"{_name}\n{_address.SingleAddress()}";
    }

    public void SetAddress(Address address)
    {
        _address.SetNumber(address.GetNumber());
        _address.SetStreet(address.GetStreet());
        _address.SetCity(address.GetCity());
        _address.SetStateOrProv(address.GetStateOrProv());
        _address.SetCountry(address.GetCountry());
    }

    public int LiveInUSA()
    {
        return _address.IsInUSA();
    }
}
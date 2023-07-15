public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(string custName = "", string number = "", string street = "", string city = "", string stateOrProv = "", string country = "")
    {
        _customer = new Customer(custName.Trim(), number.Trim(), street.Trim(), city.Trim(), stateOrProv.Trim(), country.Trim());
        _products = new List<Product>();
    }

    public void Init(string custName, string number, string street, string city, string stateOrProv, string country)
    {
        _customer = new Customer(custName.Trim(), number.Trim(), street.Trim(), city.Trim(), stateOrProv.Trim(), country.Trim());
    }

    public string GetCustName()
    {
        return _customer.GetName();
    }

    public void SetCustName(string custName)
    {
        _customer.SetName(custName.Trim());
    }

    public string GetAddressNumber()
    {
        return _customer.GetNumber();
    }

    public void SetAddressNumber(string addresNumber)
    {
        _customer.SetNumber(addresNumber.Trim());
    }

    public string GetStreet()
    {
        return _customer.GetStreet();
    }

    public void SetStreet(string street)
    {
        _customer.SetStreet(street.Trim());
    }

    public string GetCity()
    {
        return _customer.GetCity();
    }

    public void SetCity(string city)
    {
        _customer.SetCity(city.Trim());
    }

    public string GetStateOrProv()
    {
        return _customer.GetStateOrProv();
    }

    public void SetStateOrProv(string stateOrProv)
    {
        _customer.SetStateOrProv(stateOrProv.Trim());
    }

    public string GetCountry()
    {
        return _customer.GetCountry();
    }

    public void SetCountry(string country)
    {
        _customer.SetCountry(country.Trim());
    }

    public double GetShippingCost()
    {
        if(_customer.LiveInUSA() != 0) return 5;
        else return 35;
    }

    public int HowManyProductHas()
    {
        return _products.Count;
    }

    public void AddProduct(string name, int id, double price, int quantity)
    {
        _products.Add(new Product(name.Trim(), id, price, quantity));
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetAddress()}\nShipping Cost $ {GetShippingCost(),42:N2}";    
    }

    public string PackingLabel()
    {
        double subTotal = 0;
        string packingLabel = "Product Name      Id      Price    Quantity    SubTotal\n";
        foreach(Product product in _products)
        {
            packingLabel += product.List() + "\n";
            subTotal += product.SubT();
        }
        packingLabel += $"SubTotal $ {subTotal,47:N2}";
        return packingLabel;
    }

    public double TotalCost()
    {
        double totalCost = 0;
        foreach(Product product in _products) totalCost += product.SubT();
        totalCost += GetShippingCost();
        return totalCost;
    }
}
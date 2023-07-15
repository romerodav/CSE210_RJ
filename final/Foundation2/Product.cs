public class Product
{
    private string _name;
    private int _id, _quantity;
    private double _price;

    public Product()
    {
        _name = "";
        _id = 0;
        _price = 0;
        _quantity = 0;       
    }

    public Product(string name, int id, double price = 0, int quantity = 0)
    {
        _name = name.Trim();
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public void Init(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name.Trim();
    }

    public int GetId()
    {
        return _id;
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double SubT()
    {
        return _price * _quantity;
    }

    public string List()
    {
        return $"{_name,-16} {_id} {_price,13:N2} {_quantity,8} {(_price * _quantity),14:N2}";
    }
}
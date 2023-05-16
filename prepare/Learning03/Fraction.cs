public class Fraction
{
    private int _top, _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int buttom)
    {
        _bottom = buttom;
    }

    public string GetFractionString()
    {
        string Fract = $"{_top}/{_bottom}";
        return Fract;    
    }

    public double GetDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
}
public class Fraction
{   
    private int _top;
    private int _bottom;

    // Default constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constr with one parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constr with two parameter
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the numerator
    public int GetTop()
    {
        return _top;
    }

    // Setter for the numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Returns fraction as string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
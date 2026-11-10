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
}
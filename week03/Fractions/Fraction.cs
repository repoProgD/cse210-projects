public class Fraction
{
    private int _top;
    private int _bottom;
    
    // Constructors, why is there more than one? 
    public Fraction() // particular case 1/1
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int WholeNumber)   //general case WholeNumber/1
    {
        _top = WholeNumber;
        _bottom = 1; 
    }

    public Fraction(int top, int bottom)  // the most general case
    {
        _top = top;
        _bottom = bottom;   // mmmm what if bottom = 0?
                            // there must be some validation here
    }
    
    // Setters and Getters
    public int GetTop()
    {
        return _top;
    }

    public int SetTop(int top)
    {
        return _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public int SetBottom(int bottom)
    {
        return _bottom = bottom;
    }
    
    // Used to internally call the fraction, then it's displayed
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}
using System;

public class Fraction
{
    private int _top;
    private int _bottom;


    // Default to 1/1 with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with 1 parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with 2 parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Method to obtain the chain representation of the fraction
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to obtain the value of the decimal fraction
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    // Getters
    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    // Setters
    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


}
public class Fraction {
    private int _top { get; set; }
    private int _bottom { get; set; }

    public Fraction() {
        _top = 0;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString() {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue() {
        return (double) _top / _bottom;
    }
}
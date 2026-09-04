namespace GeometricFigures.Backend;
public class Kite : Rhombus
{
    // Fields
    private double _b;

    // Constructors
    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
    {
        B = b;
    }

    // Properties
    public double B 
    { 
        get => _b;
        set => _b = ValidateB(value);
    }

    // Public Methods
    public override double GetArea()
    {
        double Area = (D1 * D2) / 2;
        return Area;
    }
    public override double GetPerimeter()
    {
        double Perimeter = 2 * (A + B);
        return Perimeter;
    }

    // Private Methods
    private double ValidateB(double B)
    {
        if (B <= 0)
        {
            throw new Exception("Side length must be greater than zero.");
        }
        return B;
    }
}

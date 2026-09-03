namespace Backend;

public class Rhombus : Square
{
    // Fields
    private double _d1;
    private double _d2;

    // Constructors
    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }
    // Properties
    public double D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }
    public double D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }
    // Public Methods
    public override double GetArea()
    {
        double Area = (D1 * D2) / 2;
        return Area;
    }
    public override double GetPerimeter()
    {
        double Perimeter = 4 * A;
        return Perimeter;
    }
    // Private Methods
    private double ValidateD1(double D1)
    {
        if (D1 <= 0)
        {
            throw new ArgumentException("Diagonal 1 must be greater than zero.");
        }
        return D1;
    }
    private double ValidateD2(double D2)
    {
        if (D2 <= 0)
        {
            throw new ArgumentException("Diagonal 2 must be greater than zero.");
        }
        return D2;
    }
}

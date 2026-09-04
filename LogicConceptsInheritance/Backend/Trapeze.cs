namespace GeometricFigures.Backend;
public class Trapeze : Triangle
{
    // Fields 
    private double _d;

    // Constructors

    public Trapeze(string name,  double a, double b, double c, double d, double h) : 
        base(name, a, b, c, h)
    {
        D = d;
    }

    // Properties
    public double D
    { 
        get => _d; 
        set => _d = ValidateD(value);
    }

    // Public Methods

    public override double GetArea()
    {
        double Area = ((B + D) * H) / 2;
        return Area;
    }
    public override double GetPerimeter()
    {
        double Perimeter = A + B + C + D;
        return Perimeter;
    }

    // Private Methods

    private double ValidateD(double D)
    {
        if (D <= 0)
        {
            throw new Exception("Side length must be greater than zero.");
        }
        return D;
    }
}

namespace Backend;

public class Triangle: Rectangle
{
    // Fields     
    private double _c;
    private double _h;

    // Constructors
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = _c;
        H = _h;
    }

    // Properties

    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Public Methods

    public override double GetArea()
    {
        double Area = (B * H) / 2;
        return Area;
    }
    public override double GetPerimeter()
    {
        double Perimeter = A + B + C;
        return Perimeter;
    }

    // Private Methods

    private double ValidateC(double C)
    {
        if (C <= 0)
        {
            throw new ArgumentException("Side length must be greater than zero.");
        }
        return C;
    }
    private double ValidateH(double H)
    {
        if (H <= 0)
        {
            throw new ArgumentException("Height must be greater than zero.");
        }
        return H;
    }
}

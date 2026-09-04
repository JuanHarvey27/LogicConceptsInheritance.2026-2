namespace GeometricFigures.Backend;
public class Parallelogram : Rectangle
{
    // Fields 
    private double _h;
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    // Properties

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Public Methods

    public override double GetArea()
    {
        double Area = B * H;
        return Area;
    }
    public override double GetPerimeter()
    {
        double Perimeter = 2 * (A + B);
        return Perimeter;
    }

    // Private Methods

    private double ValidateH(double H)
    {
        if (H <= 0)
        {
            throw new Exception("Height must be greater than zero.");
        }
        return H;
    }
}

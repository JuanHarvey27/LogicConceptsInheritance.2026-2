using System;
namespace Backend;

internal class Square : GeometricFigure
{
    // Fields
    private double _a;

    // Constructors
    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    // Properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Public Methods
    public override double GetArea()
    {
        double Area = Math.Pow(A, 2);
        return Area;
    }

    public override double GetPerimeter()
    {
        double Perimeter = 4 * A;
        return Perimeter;
    }

    // Private Methods
    private double ValidateA(double A)
    {
        if (A <= 0)
        {
            throw new ArgumentException("Side length must be greater than zero.");
        }
        return A;
    }
}

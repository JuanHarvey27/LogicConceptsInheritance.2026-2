using System;
namespace Backend;

public class Circle : GeometricFigure
{
    // Fields 
    private double _r;
    // Constructors
    public Circle(string name, double r) : base(name)
    {
        R = r;
    }
    // Properties
    public double R 
    { 
        get => _r; 
        set =>_r = ValidateR(value);
    }

    // Public Methods
    public override double GetArea()
    {
        double Area = Math.PI * Math.Pow(R, 2);
        return Area;
    }

    public override double GetPerimeter()
    {
        double Perimeter = 2 * Math.PI * R;
        return Perimeter;
    }

    // Private Methods

    private double ValidateR(double R)
    {
        if (R <= 0)
        {
            throw new ArgumentException("Radius must be greater than zero.");
        }
        return R;
    }
}

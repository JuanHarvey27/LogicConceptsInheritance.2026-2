namespace Backend;

public class Rectangle : Square
{
    // Fields
    private double _b;

    // Constructors
    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = _b;
    }

    // Properties
    public double B 
    { 
        get=>_b; 
        set=>_b=ValidateB(value); 
    }

    // Public Methods
    public override double GetArea()
    {
        double Area = A * B;
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
            throw new ArgumentException("Side length must be greater than zero.");
        }
        return B;
    }
}

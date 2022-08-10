namespace GeometryFigures;

public class Rectangle : IFigure
{
    private double _a;
    private double _b;

    public Rectangle(double a, double b)
    {
        if (a <= 0 || b <= 0)
            throw new Exception();
        _a = a;
        _b = b;
    }

    public double GetPerimeter() => Math.Round(2 * (_a + _b), GlobalConstants.Precision);
    public double GetArea() => Math.Round(_a * _b, GlobalConstants.Precision);
}
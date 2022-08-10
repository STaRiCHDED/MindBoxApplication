namespace GeometryFigures;

public class Circle : IFigure
{
    private double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new Exception();
        _radius = radius;
    }

    public double GetPerimeter()
    {
        return Math.Round(2 * Math.PI * _radius, GlobalConstants.Precision);
    }

    public double GetArea()
    {
        return Math.Round(Math.Pow(_radius, 2) * Math.PI, GlobalConstants.Precision);
    }
}
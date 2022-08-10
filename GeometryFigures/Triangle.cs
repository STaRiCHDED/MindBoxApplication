namespace GeometryFigures;

public class Triangle : IFigure
{
    private double _a;
    private double _b;
    private double _c;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new Exception();
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new Exception();
        _a = a;
        _b = b;
        _c = c;
    }

    public double GetPerimeter()
    {
        return Math.Round(_a + _b + _c, GlobalConstants.Precision);
    }

    public double GetArea()
    {
        var p = (_a + _b + _c) / 2f;
        return Math.Round(Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c)), GlobalConstants.Precision);
    }

    public bool IsRectangular()
    {
        var edges = new[] {_a, _b, _c};
        Array.Sort(edges);
        return Math.Pow(edges[2], 2) == Math.Pow(edges[0], 2) + Math.Pow(edges[1], 2);
    }
}
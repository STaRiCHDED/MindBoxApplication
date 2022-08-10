using System;
using GeometryFigures;
using NUnit.Framework;

namespace UnitTest;

public class PerimeterTests
{
    [TestCase(2, 4, 12)]
    [TestCase(3.2, 4.5, 15.4)]
    [TestCase(4.5, 9.7, 28.4)]
    [TestCase(345.28, 589.49, 1869.54)]
    [TestCase(2985.598, 3098.154, 12167.504)]
    public void GetPerimeterRectangleMethod_WithGivenSides_ShouldReturnCorrectPerimeter(double a, double b,
        double result)
    {
        //Arrange
        IFigure temp = new Rectangle(a, b);
        //Act
        var actualResult = temp.GetPerimeter();
        //Assert
        Assert.AreEqual(actualResult, result);
    }

    [TestCase(5, 4, 8, 17)]
    [TestCase(5.2, 4.5, 7.8, 17.5)]
    [TestCase(12.5, 19.8, 28.9, 61.2)]
    [TestCase(371.4, 746.1, 648.8, 1766.3)]
    [TestCase(3531.623, 2892.582, 5803.8987, 12228.1037)]
    public void GetPerimeterTriangleMethod_WithGivenSides_ShouldReturnCorrectPerimeter(double a, double b, double c,
        double result)
    {
        //Arrange
        IFigure temp = new Triangle(a, b, c);
        //Act
        var actualResult = temp.GetPerimeter();
        //Assert
        Assert.AreEqual(actualResult, result);
    }

    [TestCase(2, 12.56637)]
    [TestCase(3.7, 23.247790)]
    [TestCase(12.5, 78.53982)]
    [TestCase(371.4, 2333.57502)]
    [TestCase(3531.623, 22189.84174)]
    public void GetPerimeter_WithGivenRadius_ShouldReturnCorrectPerimeter(double radius, double result)
    {
        //Arrange
        IFigure temp = new Circle(radius);
        //Act
        var actualResult = temp.GetPerimeter();
        //Assert
        Assert.AreEqual(actualResult, result);
    }
}

public class AreaTests
{
    [TestCase(2, 4, 8)]
    [TestCase(3.2, 4.5, 14.4)]
    [TestCase(4.5, 9.7, 43.65)]
    [TestCase(345.28, 589.49, 203539.1072)]
    [TestCase(2985.598, 3098.154, 9249842.38609)]
    public void GetAreaRectangleMethod_WithGivenSides_ShouldReturnCorrectArea(double a, double b, double result)
    {
        //Arrange
        IFigure temp = new Rectangle(a, b);
        //Act
        var actualResult = temp.GetArea();
        //Assert
        Assert.AreEqual(actualResult, result);
    }

    [TestCase(5, 4, 8, 8.18153)]
    [TestCase(5.2, 4.5, 7.8, 11.19888)]
    [TestCase(12.5, 19.8, 28.9, 100.84081)]
    [TestCase(371.4, 746.1, 648.8, 120480.88837)]
    [TestCase(3531.623, 2892.582, 5803.8987, 3971859.47657)]
    public void GetAreaTriangleMethod_WithGivenSides_ShouldReturnCorrectArea(double a, double b, double c,
        double result)
    {
        //Arrange
        IFigure temp = new Triangle(a, b, c);
        //Act
        var actualResult = temp.GetArea();
        //Assert
        Assert.AreEqual(actualResult, result);
    }

    [TestCase(2, 12.56637)]
    [TestCase(3.7, 43.0084)]
    [TestCase(12.5, 490.87385)]
    [TestCase(371.4, 433344.88179)]
    [TestCase(3531.623, 39183077.73491)]
    public void GetArea_WithGivenRadius_ShouldReturnCorrectArea(double radius, double result)
    {
        //Arrange
        IFigure temp = new Circle(radius);
        //Act
        var actualResult = temp.GetArea();
        //Assert
        Assert.AreEqual(actualResult, result);
    }
}

public class NegativeAndZeroNumberExceptions
{
    [TestCase(-1, 5)]
    [TestCase(8.9, -4.6)]
    [TestCase(-2.6, -6.8)]
    [TestCase(0, 1)]
    [TestCase(1, 0)]
    public void RectangleConstructor_WithGivenSides_ShouldThrowException(double a, double b)
    {
        //Arrange
        IFigure temp = null;
        //Act
        try
        {
            temp = new Rectangle(a, b);
            Assert.Fail();
        }
        catch (Exception)
        {
            //Assert
            Assert.Pass();
        }
    }

    [TestCase(-5, -8, -6)]
    [TestCase(-3.4, 4.5, 5.6)]
    [TestCase(2.8, -3.7, 1.6)]
    [TestCase(2.2, 3.3, -2.5)]
    [TestCase(2.4, 0, 3)]
    [TestCase(3, 2, 0)]
    public void TriangleConstructor_WithGivenSides_ShouldThrowException(double a, double b, double c)
    {
        //Arrange
        IFigure temp = null;
        //Act
        try
        {
            temp = new Triangle(a, b, c);
            Assert.Fail();
        }
        catch (Exception)
        {
            //Assert
            Assert.Pass();
        }
    }

    [TestCase(-9)]
    [TestCase(-6.8)]
    [TestCase(0)]
    public void CircleConstructor_WithGivenRadius_ShouldThrowException(double radius)
    {
        //Arrange
        IFigure temp = null;
        //Act
        try
        {
            temp = new Circle(radius);
            Assert.Fail();
        }
        catch (Exception)
        {
            //Assert
            Assert.Pass();
        }
    }
}

public class TriangleExistenceException
{
    [TestCase(5, 50, 6)]
    [TestCase(3.4, 40.5, 5.6)]
    [TestCase(2.8, 3.7, 106.6)]
    [TestCase(205.2, 3.3, 2.5)]
    public void TriangleConstructor_WithGivenOneBigSide_ShouldThrowException(double a, double b, double c)
    {
        //Arrange
        IFigure temp = null;
        //Act
        try
        {
            temp = new Triangle(a, b, c);
            Assert.Fail();
        }
        catch (Exception)
        {
            //Assert
            Assert.Pass();
        }
    }
}

public class TriangleSquareness
{
    [TestCase(3, 4, 5)]
    [TestCase(5, 12, 13)]
    [TestCase(8.0, 15.0, 17.0)]
    public void IsRectangular_WithGivenSides_ShouldReturnTrue(double a, double b, double c)
    {
        //Arrange
        var temp = new Triangle(a, b, c);
        //Act
        var actualResult = temp.IsRectangular();
        //Assert
        Assert.True(actualResult);
    }

    [TestCase(2, 5, 5)]
    [TestCase(9, 12, 14)]
    [TestCase(8.0, 10.0, 9.0)]
    public void IsRectangular_WithGivenSides_ShouldReturnFalse(double a, double b, double c)
    {
        //Arrange
        var temp = new Triangle(a, b, c);
        //Act
        var actualResult = temp.IsRectangular();
        //Assert
        Assert.False(actualResult);
    }
}
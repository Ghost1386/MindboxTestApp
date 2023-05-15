namespace MindboxTestApp.Test;

public class TriangleTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [TestCase(1, 2, 3)]
    [TestCase(1.5, 6, 4.3)]
    [TestCase(12.2, 23.8, 6.7)]
    public void TestForСanTriangleExist_ThrowArgumentException(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }
    
    [TestCase(3, 4, 5, ExpectedResult = 6)]
    [TestCase(7, 13, 16, ExpectedResult = 44.497190922573978d)]
    [TestCase(5.78, 9.14, 7.9332, ExpectedResult = 22.702374408114892d)]
    public double TestForCalculateAreaOfFigureTriangle(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        var square = triangle.CalculateAreaOfTriangle();
        
        return square;
    }
    
    [TestCase(3, 4, 5, ExpectedResult = true)]
    [TestCase(3, 4, 6, ExpectedResult = false)]
    public bool TestForIsTriangleRightAngled(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        var actualResult = triangle.IsTriangleRightAngled();

        return actualResult;
    }
}
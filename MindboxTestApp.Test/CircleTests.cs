namespace MindboxTestApp.Test;

public class CircleTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [TestCase(0)]
    public void TestForCircleWithRadiusEqualZero_ThrowArgumentException(double radiusForTest)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radiusForTest));
    }
    
    [TestCase(5)]
    [TestCase(13)]
    [TestCase(34)]
    public void TestForCircleWithNormalRadius(double radiusForTest)
    {
        var circle = new Circle(radiusForTest);
        
        var expectedSquare = Math.PI * Math.Pow(radiusForTest, 2);

        var square = circle.CalculateAreaOfCircle();
        
        Assert.That(square, Is.EqualTo(expectedSquare));
    }
}
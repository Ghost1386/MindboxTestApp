namespace MindboxTestApp;

public class Circle : ICircle
{
    private static double Radius { get; set; }
    
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException(nameof(radius));
        }

        Radius = radius;
    }
    
    public double CalculateAreaOfCircle()
    {
        var square = Math.PI * Math.Pow(Radius, 2);
        
        return square;
    }
}
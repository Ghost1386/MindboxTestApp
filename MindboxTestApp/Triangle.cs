namespace MindboxTestApp;

public class Triangle : ITriangle
{
    private const double CalculationAccuracy = 1e-7;
    private static double SideA { get; set; }
    private static double SideB { get; set; }
    private static double SideC { get; set; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("Such a triangle cannot exist");
        }
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateAreaOfTriangle()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;

        var square = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) 
                                                * (semiPerimeter - SideB) 
                                                * (semiPerimeter - SideC));

        return square;
    }

    public bool IsTriangleRightAngled()
    {
        var maxSide = Math.Max(SideA, Math.Max(SideB, SideC));

        if (Math.Abs(maxSide - SideA) < CalculationAccuracy)
        {
            return Math.Abs(Math.Pow(SideA, 2) - (Math.Pow(SideB, 2) + Math.Pow(SideC, 2))) < CalculationAccuracy;
        }
        
        if (Math.Abs(maxSide - SideB) < CalculationAccuracy)
        {
            return Math.Abs(Math.Pow(SideB, 2) - (Math.Pow(SideA, 2) + Math.Pow(SideC, 2))) < CalculationAccuracy;
        }
        
        return Math.Abs(Math.Pow(SideC, 2) - (Math.Pow(SideB, 2) + Math.Pow(SideA, 2))) < CalculationAccuracy;
    }
}
using System;

class TRTriangle
{
    private double sideLength;

    public TRTriangle()
    {
        sideLength = 1.0;
    }

    public TRTriangle(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public TRTriangle(TRTriangle triangle)
    {
        this.sideLength = triangle.sideLength;
    }

    public void InputData()
    {
        Console.Write("Введiть довжину сторони: ");
        sideLength = Convert.ToDouble(Console.ReadLine());
    }

    public void OutputData()
    {
        Console.WriteLine($"Довжина сторони трикутника: {sideLength}");
    }

    public double GetArea()
    {
        return (Math.Sqrt(3) / 4) * Math.Pow(sideLength, 2);
    }

    public double GetPerimeter()
    {
        return 3 * sideLength;
    }

    public bool IsEqual(TRTriangle otherTriangle)
    {
        return this.sideLength == otherTriangle.sideLength;
    }

    public static TRTriangle operator +(TRTriangle a, TRTriangle b)
    {
        return new TRTriangle(a.sideLength + b.sideLength);
    }

    public static TRTriangle operator -(TRTriangle a, TRTriangle b)
    {
        return new TRTriangle(a.sideLength - b.sideLength);
    }

    public static TRTriangle operator *(TRTriangle a, double scalar)
    {
        return new TRTriangle(a.sideLength * scalar);
    }
}
class Program
{
    static void Main(string[] args)
    {
        TRTriangle triangle1 = new TRTriangle();
        TRTriangle triangle2 = new TRTriangle();

        Console.WriteLine("Введiть данi для першого трикутника:");
        triangle1.InputData();
        Console.WriteLine("Введiть данi для другого трикутника:");
        triangle2.InputData();

        triangle1.OutputData();
        triangle2.OutputData();

        Console.WriteLine($"Площа трикутника 1: {triangle1.GetArea()}");
        Console.WriteLine($"Периметр трикутника 1: {triangle1.GetPerimeter()}");

        Console.WriteLine($"Трикутники рiвнi: {triangle1.IsEqual(triangle2)}");

        TRTriangle triangle3 = triangle1 + triangle2;
        TRTriangle triangle4 = triangle1 - triangle2;
        TRTriangle triangle5 = triangle1 * 2;

        triangle3.OutputData();
        triangle4.OutputData();
        triangle5.OutputData();
    }
}

public class MediansOfTriangle
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите длину стороны a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину стороны b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину стороны c:");
        double c = double.Parse(Console.ReadLine());

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Треугольник с такими сторонами не существует.");
            return;
        }

        double ma = CalculateMedian(b, c, a);
        Console.WriteLine($"Медиана ma: {ma}");
        double mb = CalculateMedian(a, c, b);
        Console.WriteLine($"Медиана mb: {mb}");
        double mc = CalculateMedian(a, b, c);
        Console.WriteLine($"Медиана mc: {mc}");
    }

    public static double CalculateMedian(double side1, double side2, double side3)
    {

        return 0.5 * Math.Sqrt(2 * (side1 * side1) + 2 * (side2 * side2) - (side3 * side3));
    }
}
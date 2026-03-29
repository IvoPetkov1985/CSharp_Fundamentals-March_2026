namespace _03.LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLength = GetLength(x1, y1, x2, y2);
            double secondLength = GetLength(x3, y3, x4, y4);

            if (firstLength >= secondLength)
            {
                PrintResult(x1, y1, x2, y2);
            }
            else
            {
                PrintResult(x3, y3, x4, y4);
            }
        }

        static double GetLength(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }

        static double GetDistanceToCenter(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        static void PrintResult(double x1, double y1, double x2, double y2)
        {
            if (GetDistanceToCenter(x1, y1) <= GetDistanceToCenter(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}

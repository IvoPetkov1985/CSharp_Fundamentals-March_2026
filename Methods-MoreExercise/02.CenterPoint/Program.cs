namespace _02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstPointX = double.Parse(Console.ReadLine());
            double firstPointY = double.Parse(Console.ReadLine());
            double secondPointX = double.Parse(Console.ReadLine());
            double secondPointY = double.Parse(Console.ReadLine());

            double firstDistance = GetPointDistance(firstPointX, firstPointY);
            double secondDistance = GetPointDistance(secondPointX, secondPointY);

            if (firstDistance < secondDistance)
            {
                Console.WriteLine($"({firstPointX}, {firstPointY})");
            }
            else if (firstDistance > secondDistance)
            {
                Console.WriteLine($"({secondPointX}, {secondPointY})");
            }
            else
            {
                Console.WriteLine($"({firstPointX}, {firstPointY})");
            }
        }

        static double GetPointDistance(double x, double y)
        {
            double result = Math.Sqrt(Math.Abs(x * x) + Math.Abs(y * y));
            return result;
        }
    }
}

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int area = GetArea(sideA, sideB);
            Console.WriteLine(area);
        }

        static int GetArea(int sideA, int sideB)
        {
            int area = sideA * sideB;
            return area;
        }
    }
}

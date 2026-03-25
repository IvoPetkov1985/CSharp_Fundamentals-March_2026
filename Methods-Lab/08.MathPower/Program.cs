namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculatePower(baseNumber, power));
        }

        static double CalculatePower(double number, int power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            long firstFactorial = CalculateFactorial(firstNumber);
            long secondFactorial = CalculateFactorial(secondNumber);
            Console.WriteLine(DivideFactorials(firstFactorial, secondFactorial));
        }

        static long CalculateFactorial(int number)
        {
            long result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        static string DivideFactorials(long first, long second)
        {
            double result = first / (double)second;
            return $"{result:F2}";
        }
    }
}

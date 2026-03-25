namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operand = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            double result = Calculate(firstNumber, operand, secondNumber);
            Console.WriteLine(result);
        }

        static double Calculate(int x1, string operand, int x2)
        {
            switch (operand)
            {
                case "+": return x1 + x2;
                case "-": return x1 - x2;
                case "*": return x1 * x2;
                case "/": return x1 / (double)x2;
            }

            return 0;
        }
    }
}

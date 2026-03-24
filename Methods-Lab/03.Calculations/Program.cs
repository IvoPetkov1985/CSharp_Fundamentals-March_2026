namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (calculation == "add")
            {
                Add(firstNumber, secondNumber);
            }
            else if (calculation == "subtract")
            {
                Subtract(firstNumber, secondNumber);
            }
            else if (calculation == "multiply")
            {
                Multiply(firstNumber, secondNumber);
            }
            else if (calculation == "divide")
            {
                Divide(firstNumber, secondNumber);
            }
        }

        static void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }

        static void Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }

        static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        static void Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}

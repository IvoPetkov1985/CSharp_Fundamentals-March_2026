namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            double diff = Math.Abs(firstNumber - secondNumber);
            bool areEqual = true;

            if (diff > eps)
            {
                areEqual = false;
            }

            Console.WriteLine(areEqual);
        }
    }
}

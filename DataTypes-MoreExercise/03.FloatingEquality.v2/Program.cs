namespace _03.FloatingEquality.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precision = 0.000001;

            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double diff = Math.Abs(firstNumber - secondNumber);
            bool areEqual = diff < precision;

            Console.WriteLine(areEqual);
        }
    }
}

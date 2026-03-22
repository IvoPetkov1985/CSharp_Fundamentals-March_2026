using System.Numerics;

namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());

            BigInteger result = ((firstNumber + secondNumber) / thirdNumber) * forthNumber;
            Console.WriteLine(result);
        }
    }
}

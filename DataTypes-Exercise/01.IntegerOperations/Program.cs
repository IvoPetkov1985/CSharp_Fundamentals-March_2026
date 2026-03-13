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

            int sum = firstNumber + secondNumber;
            int division = sum / thirdNumber;
            int multiplication = division * forthNumber;

            Console.WriteLine(multiplication);
        }
    }
}

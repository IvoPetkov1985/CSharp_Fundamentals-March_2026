namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());

            for (int currentNumber = 2; currentNumber <= upperLimit; currentNumber++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor < currentNumber; divisor++)
                {
                    if (currentNumber % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", currentNumber, isPrime ? "true" : "false");
            }
        }
    }
}

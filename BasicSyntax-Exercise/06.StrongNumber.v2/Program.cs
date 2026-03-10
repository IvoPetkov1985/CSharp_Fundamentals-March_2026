namespace _06.StrongNumber.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int numberCopy = inputNumber;
            int sumFactorials = 0;

            while (numberCopy > 0)
            {
                int currentDigit = numberCopy % 10;
                int factorial = 1;

                for (int i = 2; i <= currentDigit; i++)
                {
                    factorial *= i;
                }

                sumFactorials += factorial;
                numberCopy /= 10;
            }

            if (sumFactorials == inputNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

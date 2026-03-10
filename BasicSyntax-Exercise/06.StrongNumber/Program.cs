namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            string numberAsString = inputNumber.ToString();
            int factorialsSum = 0;

            for (int i = 0; i < numberAsString.Length; i++)
            {
                int digit = int.Parse(numberAsString[i].ToString());
                int factorial = 1;

                for (int j = 1; j <= digit; j++)
                {
                    factorial *= j;
                }

                factorialsSum += factorial;
            }

            if (factorialsSum == inputNumber)
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

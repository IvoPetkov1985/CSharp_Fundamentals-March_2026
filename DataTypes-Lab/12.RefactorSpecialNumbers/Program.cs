namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());

            for (int number = 1; number <= upperLimit; number++)
            {
                int sumDigits = 0;
                int copy = number;

                while (copy > 0)
                {
                    sumDigits += copy % 10;
                    copy /= 10;
                }

                bool isSpecialNum = sumDigits == 5 || sumDigits == 7 || sumDigits == 11;
                Console.WriteLine("{0} -> {1}", number, isSpecialNum);
            }

        }
    }
}

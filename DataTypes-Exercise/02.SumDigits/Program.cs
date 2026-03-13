namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int sumDigits = 0;
            string numberAsString = inputNumber.ToString();

            for (int i = 0; i < numberAsString.Length; i++)
            {
                int digit = int.Parse(numberAsString[i].ToString());
                sumDigits += digit;
            }

            Console.WriteLine(sumDigits);
        }
    }
}

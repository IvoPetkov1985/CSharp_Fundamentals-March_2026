namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            if (bigNumber == null || bigNumber == "0" ||  multiplyer == 0)
            {
                Console.WriteLine("0");
                return;
            }

            List<int> digits = new();

            int remainder = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());
                int product = currentDigit * multiplyer + remainder;
                digits.Add(product % 10);
                remainder = product / 10;
            }

            if (remainder > 0)
            {
                digits.Add(remainder);
            }

            digits.Reverse();
            Console.WriteLine(string.Join(string.Empty, digits));
        }
    }
}

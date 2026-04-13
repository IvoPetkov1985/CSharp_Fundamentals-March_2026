namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            if (bigNumber == "0" || multiplyer == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int[] productNumber = new int[bigNumber.Length + 1];
            int carry = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = bigNumber[i] - '0';
                int product = digit * multiplyer + carry;
                productNumber[i + 1] = product % 10;
                carry = product / 10;
            }

            productNumber[0] = carry;
            Console.WriteLine(string.Join(string.Empty, productNumber).TrimStart('0'));
        }
    }
}

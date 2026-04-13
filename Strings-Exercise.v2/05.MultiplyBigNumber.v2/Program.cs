namespace _05.MultiplyBigNumber.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            if (bigNumber == null || bigNumber == "0" || multiplyer == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int[] productNumber = new int[bigNumber.Length + 1];

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int product = multiplyer * (bigNumber[i] - '0');
                productNumber[i + 1] += product;

                if (productNumber[i + 1] >= 10)
                {
                    productNumber[i] += productNumber[i + 1] / 10;
                    productNumber[i + 1] %= 10;
                }
            }

            Console.WriteLine(string.Join(string.Empty, productNumber).TrimStart('0'));
        }
    }
}

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();
                int sum = 0;

                foreach (char symbol in text)
                {
                    if (symbol == 'A' || symbol == 'a' ||
                        symbol == 'O' || symbol == 'o' ||
                        symbol == 'U' || symbol == 'u' ||
                        symbol == 'E' || symbol == 'e' ||
                        symbol == 'I' || symbol == 'i')
                    {
                        sum += (int)symbol * text.Length;
                    }
                    else
                    {
                        sum += (int)symbol / text.Length;
                    }
                }

                numbers[i] = sum;
            }

            Console.WriteLine(string.Join(Environment.NewLine, numbers.OrderBy(x => x)));
        }
    }
}

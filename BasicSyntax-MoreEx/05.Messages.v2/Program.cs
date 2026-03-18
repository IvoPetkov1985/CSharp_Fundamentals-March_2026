namespace _05.Messages.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < count; i++)
            {
                string inputLine = Console.ReadLine();
                int num = int.Parse(inputLine[0].ToString());
                int length = inputLine.Length;
                int multiplier = 3;
                int aCode = 97;

                char letter = (char)(aCode + ((num - 2) * multiplier) + (length - 1));

                if (num >= 8)
                {
                    letter++;
                }

                if (num == 0)
                {
                    letter = ' ';
                }

                message += letter;
            }

            Console.WriteLine(message);
        }
    }
}

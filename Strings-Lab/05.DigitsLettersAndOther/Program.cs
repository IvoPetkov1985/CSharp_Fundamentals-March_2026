namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            foreach (char c in inputLine)
            {
                if (c >= 48 && c <= 57)
                {
                    digits += c;
                }
                else if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
                {
                    letters += c;
                }
                else
                {
                    others += c;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}

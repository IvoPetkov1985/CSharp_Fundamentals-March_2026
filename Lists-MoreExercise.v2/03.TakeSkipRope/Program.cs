namespace _03.TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            List<int> digits = new();
            List<char> nonDigits = new();

            foreach (char symbol in inputText)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Add(int.Parse(symbol.ToString()));
                }
                else
                {
                    nonDigits.Add(symbol);
                }
            }

            List<int> takeList = new();
            List<int> skipList = new();

            for (int i = 0; i < digits.Count; i++)
            {
                int currentDigit = digits[i];

                if (i % 2 == 0)
                {
                    takeList.Add(currentDigit);
                }
                else
                {
                    skipList.Add(currentDigit);
                }
            }

            string resultString = string.Empty;
            int index = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i];
                int skip = skipList[i];
                List<char> charctersToAdd = nonDigits.Skip(index).Take(take).ToList();
                resultString += string.Join(string.Empty, charctersToAdd);
                index += (take + skip);
            }

            Console.WriteLine(resultString);
        }
    }
}

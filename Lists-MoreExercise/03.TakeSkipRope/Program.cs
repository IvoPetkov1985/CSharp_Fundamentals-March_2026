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
                    int digit = int.Parse(symbol.ToString());
                    digits.Add(digit);
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
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);
                }
                else
                {
                    skipList.Add(digits[i]);
                }
            }

            List<char> resultList = new();
            int index = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i];
                int skip = skipList[i];
                List<char> temp = nonDigits.Skip(index).Take(take).ToList();
                resultList.AddRange(temp);
                index += take + skip;
            }

            Console.WriteLine(string.Join("", resultList));
        }
    }
}

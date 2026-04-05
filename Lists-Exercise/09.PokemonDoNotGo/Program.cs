namespace _09.PokemonDoNotGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> removedNumbers = new();

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedNumber;

                if (index < 0)
                {
                    removedNumber = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (index >= 0 && index < numbers.Count)
                {
                    removedNumber = numbers[index];
                    numbers.RemoveAt(index);
                }
                else
                {
                    removedNumber = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }

                removedNumbers.Add(removedNumber);

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= removedNumber)
                    {
                        numbers[i] += removedNumber;
                    }
                    else
                    {
                        numbers[i] -= removedNumber;
                    }
                }
            }

            Console.WriteLine(removedNumbers.Sum());
        }
    }
}

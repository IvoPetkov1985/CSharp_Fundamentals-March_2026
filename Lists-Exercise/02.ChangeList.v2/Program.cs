namespace _02.ChangeList.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int value = int.Parse(tokens[1]);

                if (command == "Delete")
                {
                    int[] filtered = Array.FindAll(numbers, x => x != value);
                    numbers = filtered;
                }
                else if (command == "Insert")
                {
                    int position = int.Parse(tokens[2]);

                    if (position >= 0 && position <= numbers.Length)
                    {
                        int[] firstArray = numbers.Take(position).ToArray();
                        int[] secondArray = new int[numbers.Length - (position - 1)];
                        secondArray[0] = value;
                        Array.Copy(numbers, position, secondArray, 1, numbers.Length - position);
                        int[] resultArray = firstArray.Concat(secondArray).ToArray();
                        numbers = resultArray;
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int element = int.Parse(tokens[1]);

                switch (command)
                {
                    case "Delete":
                        numbers = DeleteElements(numbers, element);
                        break;
                    case "Insert":
                        int position = int.Parse(tokens[2]);
                        numbers = InsertElement(numbers, element, position);
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> InsertElement(List<int> numbers, int element, int position)
        {
            numbers.Insert(position, element);
            return numbers;
        }

        static List<int> DeleteElements(List<int> numbers, int value)
        {
            numbers.RemoveAll(x => x == value);
            return numbers;
        }
    }
}

namespace _04.ListOperations
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

            while (commandLine != "End")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers = AddNumber(numbers, numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers = InsertNumber(numbers, indexToInsert, numberToInsert);
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers = RemoveNumber(numbers, indexToRemove);
                        break;
                    case "Shift":
                        string direction = tokens[1];
                        int count = int.Parse(tokens[2]);
                        count %= numbers.Count;

                        if (direction == "left")
                        {
                            List<int> shiftedPart = numbers.GetRange(0, count);
                            numbers.RemoveRange(0, count);
                            numbers.AddRange(shiftedPart);
                        }
                        else if (direction == "right")
                        {
                            List<int> shiftedPart = numbers.GetRange(numbers.Count - count, count);
                            numbers.RemoveRange(numbers.Count - count, count);
                            numbers.InsertRange(0, shiftedPart);
                        }

                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> RemoveNumber(List<int> numbers, int indexToRemove)
        {
            if (IsIndexValid(indexToRemove, numbers.Count))
            {
                numbers.RemoveAt(indexToRemove);
            }

            return numbers;
        }

        static List<int> InsertNumber(List<int> numbers, int index, int numberToInsert)
        {
            if (IsIndexValid(index, numbers.Count))
            {
                numbers.Insert(index, numberToInsert);
            }

            return numbers;
        }

        static List<int> AddNumber(List<int> numbers, int numberToAdd)
        {
            numbers.Add(numberToAdd);
            return numbers;
        }

        static bool IsIndexValid(int index, int count)
        {
            if (index >= 0 && index < count)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid index");
                return false;
            }
        }
    }
}

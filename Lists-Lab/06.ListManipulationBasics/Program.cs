namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int value = int.Parse(tokens[1]);

                if (command == "Add")
                {
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    numbers.Remove(value);
                }
                else if (command == "RemoveAt")
                {
                    numbers.RemoveAt(value);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, value);
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

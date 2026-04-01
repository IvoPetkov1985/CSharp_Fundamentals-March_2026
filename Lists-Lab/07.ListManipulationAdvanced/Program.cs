namespace _07.ListManipulationAdvanced
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
            bool changesMade = false;

            while (commandLine != "end")
            {
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                }
                else if (command == "Remove")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
                else if (command == "Contains")
                {
                    int searchedNumber = int.Parse(tokens[1]);

                    if (numbers.Contains(searchedNumber))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (command == "PrintOdd")
                {
                    IEnumerable<int> oddNumbers = numbers.Where(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (command == "GetSum")
                {
                    int sumNumbers = numbers.Sum();
                    Console.WriteLine(sumNumbers);
                }
                else if (command == "Filter")
                {
                    string condition = tokens[1];
                    int value = int.Parse(tokens[2]);

                    switch (condition)
                    {
                        case "<":
                            IEnumerable<int> smallerNumbers = numbers.Where(x => x < value);
                            Console.WriteLine(string.Join(" ", smallerNumbers));
                            break;
                        case ">":
                            IEnumerable<int> greaterNumbers = numbers.Where(x => x > value);
                            Console.WriteLine(string.Join(" ", greaterNumbers));
                            break;
                        case ">=":
                            IEnumerable<int> greaterOrEqualNumbers = numbers.Where(x => x >= value);
                            Console.WriteLine(string.Join(" ", greaterOrEqualNumbers));
                            break;
                        case "<=":
                            IEnumerable<int> smallerOrEqualNumbers = numbers.Where(x => x <= value);
                            Console.WriteLine(string.Join(" ", smallerOrEqualNumbers));
                            break;
                    }
                }

                if (command == "Add" || command == "Remove" || command == "RemoveAt" || command == "Insert")
                {
                    changesMade = true;
                }

                commandLine = Console.ReadLine();
            }

            if (changesMade == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}

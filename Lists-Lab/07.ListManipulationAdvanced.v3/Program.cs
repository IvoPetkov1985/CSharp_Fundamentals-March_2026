namespace _07.ListManipulationAdvanced.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool changesMade = false;
            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    int[] numbersWithAddedValue = new int[numbers.Length + 1];
                    Array.Copy(numbers, numbersWithAddedValue, numbers.Length);
                    numbersWithAddedValue[numbersWithAddedValue.Length - 1] = numberToAdd;
                    numbers = numbersWithAddedValue;
                }
                else if (command == "Remove")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    int indexToRemove = Array.IndexOf(numbers, numberToRemove);

                    if (indexToRemove > -1)
                    {
                        numbers = RemoveNumberFromArray(numbers, indexToRemove);
                    }
                }
                else if (command == "RemoveAt")
                {
                    int indexToRemoveAt = int.Parse(tokens[1]);
                    numbers = RemoveNumberFromArray(numbers, indexToRemoveAt);
                }
                else if (command == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    int[] firstPart = numbers.Take(indexToInsert).ToArray();
                    int[] secondPart = numbers.TakeLast(numbers.Length - indexToInsert).ToArray();
                    int[] resultArray = new int[numbers.Length + 1];
                    Array.Copy(firstPart, resultArray, firstPart.Length);
                    resultArray[indexToInsert] = numberToInsert;
                    Array.Copy(secondPart, 0, resultArray, indexToInsert + 1, secondPart.Length);
                    numbers = resultArray;
                }
                else if (command == "Contains")
                {
                    int searchedValue = int.Parse(tokens[1]);

                    if (Array.Exists(numbers, x => x == searchedValue))
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
                    Console.WriteLine(string.Join(" ", Array.FindAll(numbers, x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", Array.FindAll(numbers, x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = tokens[1];
                    int value = int.Parse(tokens[2]);

                    switch (condition)
                    {
                        case "<": Console.WriteLine(string.Join(" ", Array.FindAll(numbers, x => x < value))); break;
                        case ">": Console.WriteLine(string.Join(" ", Array.FindAll(numbers, x => x > value))); break;
                        case ">=": Console.WriteLine(string.Join(" ", Array.FindAll(numbers, x => x >= value))); break;
                        case "<=": Console.WriteLine(string.Join(" ", Array.FindAll(numbers, x => x <= value))); break;
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

        static int[] RemoveNumberFromArray(int[] numbers, int index)
        {
            int[] firstPart = numbers.Take(index).ToArray();
            int[] secondPart = numbers.TakeLast(numbers.Length - index - 1).ToArray();
            int[] resultArray = firstPart.Concat(secondPart).ToArray();
            return resultArray;
        }
    }
}

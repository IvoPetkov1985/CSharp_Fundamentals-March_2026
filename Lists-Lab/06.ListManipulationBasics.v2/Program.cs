namespace _06.ListManipulationBasics.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                string[] tokens = commandLine
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Add")
                {
                    int[] arrayWithAddedNum = new int[numbers.Length + 1];
                    int numToAdd = int.Parse(tokens[1]);

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        arrayWithAddedNum[i] = numbers[i];
                    }

                    arrayWithAddedNum[arrayWithAddedNum.Length - 1] = numToAdd;
                    numbers = arrayWithAddedNum;
                }
                else if (command == "Remove")
                {
                    int numberToRemove = int.Parse(tokens[1]);

                    if (numbers.Contains(numberToRemove))
                    {
                        int numberIndex = Array.IndexOf(numbers, numberToRemove);
                        int[] tempArray1 = numbers.Take(numberIndex).ToArray();
                        int[] tempArray2 = numbers.TakeLast(numbers.Length - (numberIndex + 1)).ToArray();
                        int[] arrayWithoutNumber = tempArray1.Concat(tempArray2).ToArray();
                        numbers = arrayWithoutNumber;
                    }
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    int[] firstTempArray = numbers.Take(index).ToArray();
                    int[] secondTempArray = numbers.TakeLast(numbers.Length - (index + 1)).ToArray();
                    int[] resultArray = firstTempArray.Concat(secondTempArray).ToArray();
                    numbers = resultArray;
                }
                else if (command == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    int[] arrayWithInsertedNumber = new int[indexToInsert + 1];
                    int[] secondPart = numbers.TakeLast(numbers.Length - indexToInsert).ToArray();

                    for (int i = 0; i < arrayWithInsertedNumber.Length; i++)
                    {
                        arrayWithInsertedNumber[i] = numbers[i];
                    }

                    arrayWithInsertedNumber[arrayWithInsertedNumber.Length - 1] = numberToInsert;
                    int[] finalArray = arrayWithInsertedNumber.Concat(secondPart).ToArray();
                    numbers = finalArray;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

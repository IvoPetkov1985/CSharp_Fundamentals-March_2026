namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(" ");
                string command = tokens[0];

                if (command == "exchange")
                {
                    int index = int.Parse(tokens[1]);

                    if (index >= 0 && index < numbers.Length)
                    {
                        int[] firstArray = numbers.Take(index + 1).ToArray();
                        int[] secondArray = numbers.Skip(index + 1).Take(numbers.Length - (index + 1)).ToArray();
                        int[] resultArray = secondArray.Concat(firstArray).ToArray();
                        numbers = resultArray;
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "max")
                {
                    string numberType = tokens[1];

                    if (numberType == "even")
                    {
                        int[] evenNumbers = GetEvenNumbers(numbers);

                        if (evenNumbers.Length > 0)
                        {
                            int maxNumber = GetMaxNumber(evenNumbers);
                            int maxNumberIndex = Array.LastIndexOf(numbers, maxNumber);
                            Console.WriteLine(maxNumberIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (numberType == "odd")
                    {
                        int[] oddNumbers = GetOddNumbers(numbers);

                        if (oddNumbers.Length > 0)
                        {
                            int maxOddNumber = GetMaxNumber(oddNumbers);
                            int maxOddNumberIndex = Array.LastIndexOf(numbers, maxOddNumber);
                            Console.WriteLine(maxOddNumberIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command == "min")
                {
                    string numberType = tokens[1];

                    if (numberType == "even")
                    {
                        int[] evenNumbers = GetEvenNumbers(numbers);

                        if (evenNumbers.Length > 0)
                        {
                            int minEvenNumber = GetMinNumber(evenNumbers);
                            int minEvenNumberIndex = Array.LastIndexOf(numbers, minEvenNumber);
                            Console.WriteLine(minEvenNumberIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (numberType == "odd")
                    {
                        int[] oddNumbers = GetOddNumbers(numbers);

                        if (oddNumbers.Length > 0)
                        {
                            int minOddNumber = GetMinNumber(oddNumbers);
                            int minOddNumberIndex = Array.LastIndexOf(numbers, minOddNumber);
                            Console.WriteLine(minOddNumberIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command == "first")
                {
                    int count = int.Parse(tokens[1]);

                    if (count <= numbers.Length)
                    {
                        string numbersType = tokens[2];

                        if (numbersType == "even")
                        {
                            int[] firstEvenNumbers = GetEvenNumbers(numbers).Take(count).ToArray();
                            Console.WriteLine($"[{string.Join(", ", firstEvenNumbers)}]");
                        }
                        else if (numbersType == "odd")
                        {
                            int[] firstOddNumbers = GetOddNumbers(numbers).Take(count).ToArray();
                            Console.WriteLine($"[{string.Join(", ", firstOddNumbers)}]");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
                else if (command == "last")
                {
                    int count = int.Parse(tokens[1]);

                    if (count <= numbers.Length)
                    {
                        string numbersType = tokens[2];

                        if (numbersType == "even")
                        {
                            int[] lastEvenNumbers = GetEvenNumbers(numbers).TakeLast(count).ToArray();
                            Console.WriteLine($"[{string.Join(", ", lastEvenNumbers)}]");
                        }
                        else if (numbersType == "odd")
                        {
                            int[] lastOddNumbers = GetOddNumbers(numbers).TakeLast(count).ToArray();
                            Console.WriteLine($"[{string.Join(", ", lastOddNumbers)}]");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static int[] GetEvenNumbers(int[] numbers)
        {
            int[] evenNumbers = numbers.Where(x => x % 2 == 0).ToArray();
            return evenNumbers;
        }

        static int[] GetOddNumbers(int[] numbers)
        {
            int[] oddNumbers = numbers.Where(x => x % 2 != 0).ToArray();
            return oddNumbers;
        }

        static int GetMaxNumber(int[] numbers)
        {
            int maxNumber = numbers.Max();
            return maxNumber;
        }

        static int GetMinNumber(int[] numbers)
        {
            int minNumber = numbers.Min();
            return minNumber;
        }
    }
}

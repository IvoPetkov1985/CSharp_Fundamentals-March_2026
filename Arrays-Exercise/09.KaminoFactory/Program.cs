namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int bestStartIndex = -1;
            int bestSequenceSum = 0;
            int bestCounter = 0;
            int[] bestDna = new int[dnaLength];
            int sampleNumber = 0;
            int bestSampleNumber = 0;

            while (true)
            {
                string inputSequence = Console.ReadLine();

                if (inputSequence == "Clone them!")
                {
                    break;
                }

                int[] currentSequence = inputSequence
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sampleNumber++;
                int counter = 0;
                int longestCounter = 0;
                int startIndex = -1;

                for (int i = 0; i < currentSequence.Length; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        counter++;

                        if (counter > longestCounter)
                        {
                            longestCounter = counter;
                            startIndex = i - (counter - 1);
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }

                int currentSequenceSum = currentSequence.Sum();
                bool isBetter = false;

                if (longestCounter > bestCounter)
                {
                    isBetter = true;
                }
                else if (longestCounter == bestCounter)
                {
                    if (startIndex < bestStartIndex)
                    {
                        isBetter = true;
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSequenceSum > bestSequenceSum)
                        {
                            isBetter = true;
                        }
                    }
                }

                if (isBetter || sampleNumber == 1)
                {
                    bestCounter = longestCounter;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestDna = currentSequence;
                    bestSampleNumber = sampleNumber;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}

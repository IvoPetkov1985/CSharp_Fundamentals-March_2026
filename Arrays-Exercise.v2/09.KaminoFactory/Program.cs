namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int[] bestSequence = new int[dnaLength];
            int bestCounter = 0;
            int bestIndex = int.MaxValue;
            int bestNumber = 0;
            int bestSum = 0;

            int dnaNumber = 0;

            while (true)
            {
                string dnaSequenceInput = Console.ReadLine();

                if (dnaSequenceInput == "Clone them!")
                {
                    break;
                }

                int[] dnaSequence = dnaSequenceInput
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                dnaNumber++;
                int startIndex = -1;
                int counter = 0;
                int sequenceBestCounter = 0;

                for (int i = 0; i < dnaLength; i++)
                {
                    if (dnaSequence[i] == 1)
                    {
                        counter++;

                        if (counter > sequenceBestCounter)
                        {
                            sequenceBestCounter = counter;
                            startIndex = i - (counter - 1);
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }

                int dnaSum = dnaSequence.Sum();
                bool isBetter = false;

                if (sequenceBestCounter > bestCounter)
                {
                    isBetter = true;
                }
                else if (sequenceBestCounter == bestCounter)
                {
                    if (startIndex < bestIndex)
                    {
                        isBetter = true;
                    }
                    else if (startIndex == bestIndex)
                    {
                        if (dnaSum > bestSum)
                        {
                            isBetter = true;
                        }
                    }
                }

                if (isBetter == true || dnaNumber == 1)
                {
                    bestSequence = dnaSequence;
                    bestNumber = dnaNumber;
                    bestSum = dnaSum;
                    bestCounter = sequenceBestCounter;
                    bestIndex = startIndex;
                }
            }

            Console.WriteLine($"Best DNA sample {bestNumber} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
